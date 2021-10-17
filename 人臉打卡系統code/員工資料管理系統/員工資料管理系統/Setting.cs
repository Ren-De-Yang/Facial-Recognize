using System;
using System.Collections;
using System.IO;
using System.Text;

namespace facial_recognition
{
    class Setting
    {
        public string CompanyName = "test";
        public string ip = "http://192.168.1.2:4747/video";

        //DEFAULT VALUES
        public string DCompanyName = "test";
        public string Dip = "http://192.168.1.2:4747/video";


        private FileInfo fi = new FileInfo("setting");
        private FileStream fs;
        private StreamReader sr;
        private StreamWriter sw;

        public Setting()
        {
            if (!fi.Exists)
            {
                create();
            }
            DirectoryInfo D = new DirectoryInfo("face");
            if (!D.Exists)
                D.Create();
            read();
        }
        private void create()
        {
            fs = fi.Create();
            fs.Close();
            write();
        }
        private void write()
        {
            fs = fi.OpenWrite();
            sw = new StreamWriter(fs, Encoding.Default);
            sw.WriteLine("CompanyName: " + CompanyName);
            sw.WriteLine("ip: " + ip);
            sw.Close();
        }
        private void read()
        {
            fs = new FileStream(fi.FullName, FileMode.Open);
            sr = new StreamReader(fs, Encoding.Default);

            for (int i = 0; i < 2; i++)
            {
                string str = sr.ReadLine();
                string title = str.Split(':')[0];
                int t = str.IndexOf(':') + 2;
                string content = str.Substring(t);
                Console.WriteLine(title + ": " + content);
                switch (title)
                {
                    case "CompanyName":
                        CompanyName = content;
                        break;
                    case "ip":
                        ip = content;
                        break;
                }
            }
            fs.Close();
            sr.Close();
            write();
        }
        public delegate void c();
        public event c changed;
        public void save()
        {
            Console.WriteLine("save");
            write();
            changed.Invoke();
        }
    }
}
