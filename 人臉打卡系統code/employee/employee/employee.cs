using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee
{
    [Designer(typeof(property))]
    [DefaultEvent("onClick")]
    public partial class employee: UserControl
    {
        string department;
        string position;
        int id;
        string uid;
        string name;
        bool focus;
        bool isfocus = false;
        Image Image;
        public employee()
        {
            InitializeComponent();
            checkBox1.Visible = focus;
            isfocus = true;
        }
        public string 部門
        {
            get => department;
            set
            {
                department = value;
                label1.Text = department + "    " + uid + "    " + name;
            }
        }
        public string 職位
        {
            get => position;
            set
            {
                position = value;
            }
        }
        public int ID
        {
            get => id;
            set
            {
                id = value;
            }
        }
        public string UID
        {
            get => uid;
            set
            {
                uid = value;
                label1.Text = department + "    " + uid + "    " + name;
            }
        }
        public string 姓名
        {
            get => name;
            set
            {
                name = value;
                label1.Text = department + "    " + uid + "    " + name;
            }
        }
        public Image image
        {
            get => Image;
            set
            {
                Image = value;
                pictureBox1.Image = Image;
            }
        }

        public bool focusable
        {
            get => focus;
            set
            {
                focus = value;
                checkBox1.Visible = focus;
            }
        }

        [DefaultValue(false)]
        public bool Isfocus
        {
            get => isfocus;
            set
            {
                isfocus = value;
                if(isfocus)
                    checkBox1.CheckState = CheckState.Checked;
                else
                    checkBox1.CheckState = CheckState.Unchecked;
            }
        }

        public event EventHandler onClick;
        private void button_Click(object sender, EventArgs e)
        {
            if (onClick != null)
            {
                if (!focus)
                {
                    onClick((object)this, e);
                    Isfocus = true;
                } 
                else
                    Isfocus = !isfocus;
            }
        }
        public event EventHandler onDoubleClick;
        private void button_DoubleClick(object sender, EventArgs e)
        {
            if (onDoubleClick != null)
            {
                onDoubleClick((object)this, e);
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(189, 195, 199);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
        }
    }
}
