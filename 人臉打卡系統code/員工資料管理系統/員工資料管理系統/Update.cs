using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 人臉辨識打卡系統;

namespace 員工資料管理系統
{
    public partial class Update : Form
    {
        Database db = new Database();
        public int id;
        public Image i;
        public string name;
        public string uid;
        public string position;
        public string department;
        public Update(int id, Image i, string name, string uid, string position, string dep)
        {
            InitializeComponent();
            this.i = i;
            this.name = name;
            this.uid = uid;
            this.position = position;
            this.department = dep;
            this.id = id;

            add_pictureBox.Image = i;
            name_textBox.Text = name;
            uid_textBox.Text = uid;
            position_textBox.Text = position;
            department_textBox.Text = department;
        }

        public delegate void u(Update u);
        public event u update;
        private void add_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            name = name_textBox.Text;
            uid = uid_textBox.Text;
            position = position_textBox.Text;
            department = department_textBox.Text;
            update.Invoke(this);
        }

        private void cancel_add_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
