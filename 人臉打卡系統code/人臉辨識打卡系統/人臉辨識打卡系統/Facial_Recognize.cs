using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using 人臉辨識打卡系統;

namespace facial_recognition
{
    class Facial_Recognize
    {
        FaceRecognizer LBPH;
        FaceRecognizer FISHER;
        FaceRecognizer EIGEN;
        CascadeClassifier faceclassify = new CascadeClassifier("haarcascade_frontalface_alt2.xml");
        FaceRecognizer.PredictionResult pr = new FaceRecognizer.PredictionResult();
        Rectangle[] facepos;
        Rectangle s;

        public string type = "LBPH";
        public Size min= new Size(100, 100);
        public Size max = new Size(300, 300);
        int t = 0;

        public bool getFace = false;
        public int label;

        bool isTrained = false;
        public void Train(List<Image<Gray, byte>> img, List<int> label)
        {
            switch(type){
                case "EIGEN":
                    EIGEN = new EigenFaceRecognizer(80, 1000);
                    EIGEN.Train<Gray, byte>(img.ToArray(), label.ToArray());
                    break;
                case "LBPH":
                    LBPH = new LBPHFaceRecognizer(1, 8, 8, 8, 100);
                    LBPH.Train<Gray, byte>(img.ToArray(), label.ToArray());
                    break;
                case "FISHER":
                    FISHER = new FisherFaceRecognizer(0, 1000);
                    FISHER.Train<Gray, byte>(img.ToArray(), label.ToArray());
                    break;
            }
            isTrained = true;
        }
        public Mat Recognize(Mat oriimg)
        {
            Mat img = new Mat();
            Image<Bgr, byte> gamma = oriimg.ToImage<Bgr, byte>();
            gamma._GammaCorrect(0.5d);
            oriimg = gamma.Mat;
            //灰階化
            CvInvoke.CvtColor(oriimg, img, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            //均衡化人臉灰度圖像
            CvInvoke.EqualizeHist(img, img);
            facepos = faceclassify.DetectMultiScale(img, 1.1, 3, min, max);
            
            //畫出人臉位置
            if (facepos.Length > 0)
            {
                Graphics.FromImage(oriimg.Bitmap).DrawRectangle(new Pen(Color.Red, 2), facepos[0]);
                getFace = true;

                if(isTrained)
                    predict(facepos[0]);
            }

            void predict(Rectangle rect)
            {
                try
                {
                    Font font = new Font("微軟正黑體", 16, GraphicsUnit.Pixel);
                    SolidBrush fontLine = new SolidBrush(Color.Yellow);
                    Image<Gray, byte> s = img.ToImage<Gray, byte>().GetSubRect(rect);
                    pr = LBPH.Predict(s.Resize(100, 100, Inter.Cubic));
                    label = pr.Label;
                    Graphics.FromImage(oriimg.Bitmap).DrawString(pr.Label.ToString(), font, fontLine, 0, 0);
                    //Console.WriteLine(pr.Distance);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return oriimg;
        }
        public Image<Bgr, byte> add(Mat oriimg)
        {
            Rectangle[] face;
            Mat img = new Mat();
            //灰階化
            CvInvoke.CvtColor(oriimg, img, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            //均衡化人臉灰度圖像
            CvInvoke.EqualizeHist(img, img);
            face = faceclassify.DetectMultiScale(img, 1.1, 3, min, max);

            Mat i = new Mat();
            //畫出人臉位置
            if (face.Length > 0)
            {
                i =  oriimg.ToImage<Bgr, byte>().GetSubRect(face[0]).Mat;
            }
            Image<Bgr, byte> r = i.ToImage<Bgr, byte>();
            //r._GammaCorrect(0.5d);
            return r;
        }
    }
}
