using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using facial_recognition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 人臉辨識打卡系統
{
    public partial class Form1 : Form
    {
        Capture c;
        Setting s;
        Database db;
        Facial_Recognize f;
        
        string ip;

        public void console()
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (s.Contains("select"))
                {
                    db.exec(s);
                    string label = "";
                    try
                    {
                        foreach (DataRow row in db.dataTable.Rows)
                        {
                            foreach (DataColumn column in db.dataTable.Columns)
                            {
                                label += row[column] + " ";
                            }
                            label += "\n";
                        }
                    }
                    catch { }

                    Console.WriteLine(label);
                }
                else if(s.Contains("OpenCamera"))
                {
                    Thread t = new Thread(openCam);
                    t.Start();
                }
                else if (s.Contains("exit"))
                {
                    FreeConsole();
                    Application.Exit();
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("歡迎使用人臉辨識系統");
            Console.WriteLine("如有問題請重新啟動程式或告知開發人員");
            Console.WriteLine("Get setting...");
            s = new Setting();

            Console.WriteLine("Get database...");
            db = new Database();

            Console.WriteLine("Training data...");
            f = new Facial_Recognize();
            train();
            
            Thread t = new Thread(openCam);
            t.Start();
            Thread t2 = new Thread(console);
            t2.Start();
            
            s.changed += load;
            CurrentTime.Start();
            ip = s.ip;
            home_page();
        }
        public void load()
        {
            CompanyName.Text = s.CompanyName;
            if(ip != s.ip)
                openCam();
            settings_page();
        }
        [System.Runtime.InteropServices.DllImport("Kernel32")]
        public static extern void FreeConsole();
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.close();
            Console.WriteLine("closed");
            FreeConsole();
        }

        private void UpdateTime(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            day1.Text = DateTime.Now.Month.ToString() + "月" + DateTime.Now.Day.ToString() + "日" + "週" + getWeek(DateTime.Now.DayOfWeek.ToString());
            day.Text = DateTime.Now.Month.ToString() + "月" + DateTime.Now.Day.ToString() + "日" + "週" + getWeek(DateTime.Now.DayOfWeek.ToString());
            string getWeek(string s)
            {
                switch (s)
                {
                    case "Monday": return "一";
                    case "Tuesday": return "二";
                    case "Wednesday": return "三";
                    case "Thursday": return "四";
                    case "Friday": return "五";
                    case "Saturday": return "六";
                    case "Sunday": return "日";
                    default: return "系統無法判斷";
                }
            }
        }

        #region callPage
        private void start_Click(object sender, EventArgs e)
        {
            checked_page();
        }
        string workorhome;
        private void home_Click(object sender, EventArgs e)
        {
            workorhome = "home";
            camera_page();
        }
        private void work_Click(object sender, EventArgs e)
        {
            workorhome = "work";
            camera_page();
        }
        private void setting_Click(object sender, EventArgs e)
        {
            settings_page();
        }
        private void backhome_Click(object sender, EventArgs e)
        {
            home_page();
        }

        private void recognition_Click(object sender, EventArgs e)
        {
            checked_page();
        }

        private void add_Click(object sender, EventArgs e)
        {
            add_page();
        }
        
        #endregion
        #region page
        private void home_page()
        {
            CompanyName.Text = s.CompanyName;
            home_panel.Dock = DockStyle.Fill;
            camera_panel.Dock = DockStyle.None;
            setting_panel.Dock = DockStyle.None;
            checked_panel.Dock = DockStyle.None;
            hint_panel.Dock = DockStyle.None;
            add_panel.Dock = DockStyle.None;
        }
        private void checked_page()
        {
            checked_panel.Dock = DockStyle.Fill;
            setting_panel.Dock = DockStyle.None;
            camera_panel.Dock = DockStyle.None;
            home_panel.Dock = DockStyle.None;
            hint_panel.Dock = DockStyle.None;
            add_panel.Dock = DockStyle.None;
        }
        private void camera_page()
        {
            camera_panel.Dock = DockStyle.Fill;
            home_panel.Dock = DockStyle.None;
            setting_panel.Dock = DockStyle.None;
            checked_panel.Dock = DockStyle.None;
            hint_panel.Dock = DockStyle.None;
            add_panel.Dock = DockStyle.None;
        }

        private void settings_page()
        {
            IP_textBox.Text = s.ip;
            company_textBox.Text = s.CompanyName;
            setting_panel.Dock = DockStyle.Fill;
            camera_panel.Dock = DockStyle.None;
            home_panel.Dock = DockStyle.None;
            checked_panel.Dock = DockStyle.None;
            hint_panel.Dock = DockStyle.None;
            add_panel.Dock = DockStyle.None;
        }
        private void setting_submit_Click(object sender, EventArgs e)
        {
            s.ip = IP_textBox.Text;
            s.CompanyName = company_textBox.Text;
            s.save();
        }
        private void setting_reset_Click(object sender, EventArgs e)
        {
            s.ip = s.Dip;
            s.CompanyName = s.DCompanyName;
            s.save();
        }
        private void hint()
        {
            name_hint.Text = name;
            time_hint.Text = DateTime.Now.ToString();
            hint_panel.Dock = DockStyle.Fill;
            setting_panel.Dock = DockStyle.None;
            camera_panel.Dock = DockStyle.None;
            home_panel.Dock = DockStyle.None;
            checked_panel.Dock = DockStyle.None;
            add_panel.Dock = DockStyle.None;
        }
        private void admit_button_Click(object sender, EventArgs e)
        {
            db.record(labels, DateTime.Now, workorhome);
            times = 0;
            checked_page();
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            times = 0;
            checked_page();
        }

        private void add_page()
        {
            name_textBox.Text = "";
            position_textBox.Text = "";
            department_textBox.Text = "";
            uid_textBox.Text = "";
            add_panel.Dock = DockStyle.Fill;
            hint_panel.Dock = DockStyle.None;
            setting_panel.Dock = DockStyle.None;
            camera_panel.Dock = DockStyle.None;
            home_panel.Dock = DockStyle.None;
            checked_panel.Dock = DockStyle.None;
        }
        void show(object sender, EventArgs e)
        {
            Mat cam = new Mat();
            c.Retrieve(cam);
            try
            {
                Image<Bgr, byte> i;
                if (add_panel.Dock == DockStyle.Fill)
                {
                    i = f.add(cam);
                    if (!i.Mat.IsEmpty)
                    {
                        i = i.Resize(300, 300, Inter.Cubic);
                        IntPtr gdibitmap = i.Bitmap.GetHbitmap();
                        add_pictureBox.Image = Image.FromHbitmap(gdibitmap);
                        DeleteObject(gdibitmap);
                    }
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message.ToString());
            }
            GC.Collect();
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text!="" && position_textBox.Text != "" && department_textBox.Text != "" && uid_textBox.Text != "")
            {
                DirectoryInfo d = new DirectoryInfo("face/");
                int l = 1;
                while(true) { 
                    FileInfo f = new FileInfo("face/" + l.ToString() + ".png");
                    if (!f.Exists)
                    {
                        break;
                    }
                    else
                    {
                        l++;
                    }
                    
                }
                add_pictureBox.Image.Save("face/"+ l .ToString() + ".png");
                db.add(l, name_textBox.Text, position_textBox.Text, department_textBox.Text, uid_textBox.Text);
                train();
                home_page();
            }
            else
            {
                MessageBox.Show("請填寫完整資料");
            }
        }
        private void cancel_add_button_Click(object sender, EventArgs e)
        {
            home_page();
        }
        #endregion
        #region camera
        bool grab = false;
        private void openCam()
        {
            c = new Capture(s.ip);
            Console.WriteLine("Connect to " + s.ip);
            c.FlipHorizontal = true;
            c.ImageGrabbed += process;
            c.ImageGrabbed += show;
            c.Start();
            

        }
        private void Camera_panel_DockChanged(object sender, EventArgs e)
        {
            if (camera_panel.Dock == DockStyle.None)
            {
                grab = false;
            }
            else if (camera_panel.Dock == DockStyle.Fill)
            {
                grab = true;
            }
        }
        private void train()
        {
            DirectoryInfo d = new DirectoryInfo("face/");
            if(!d.Exists)
                d.Create();

            List<Image<Gray, byte>> images = new List<Image<Gray, byte>>();
            List<int> labels = new List<int>();
            foreach (FileInfo f in d.GetFiles())
            {
                images.Add(new Image<Gray, byte>(f.FullName).Resize(100, 100, Inter.Cubic));
                labels.Add(int.Parse(f.Name.Replace(".png", "")));
            }
            if (d.GetFiles().Count() != 0)
                f.Train(images, labels);
        }
        int times = 0;
        int labels;
        string name;
        private void process(object sender, EventArgs e)
        {
            Mat cam = new Mat();
            c.Retrieve(cam);

            if (grab)
            {
                ShowImage(f.Recognize(cam));
                if (times < 100)
                {
                    if (labels == f.label)
                    {
                        times++;
                    }
                    else
                    {
                        labels = f.label;
                        times = 0;
                    }
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write( "label " + labels + ": " + times);
                }
                else if (times == 100 && grab && labels != 0)
                {
                    name = db.getName(labels);
                    Console.WriteLine("name:" + name);
                    MethodInvoker m = new MethodInvoker(hint);
                    this.BeginInvoke(m, null);
                }
                else if(times == 100 && grab)
                {
                    times = 0;
                }
            }
            else
                ShowImage(cam);
        }

        public void ShowImage(Mat processed)
        {
            //顯示圖片
            try
            {
                IntPtr gdibitmap = processed.Bitmap.GetHbitmap();
                image.Image = Image.FromHbitmap(gdibitmap);
                DeleteObject(gdibitmap);
            }
            catch { }
            GC.Collect();
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);
        #endregion
        
    }
}
