using facial_recognition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using 人臉辨識打卡系統;
using DataTable = System.Data.DataTable;
using Point = System.Drawing.Point;
using System.IO;

namespace 員工資料管理系統
{
    public partial class Form1 : Form
    {
        Database db = new Database();
        Setting s = new Setting();
        public Form1()
        {
            InitializeComponent();
            init();
            s.changed += load;
            getData();
            employees_page();
        }
        public void init()
        {
            company_textBox.Text = s.CompanyName;
            CompanyName.Text = s.CompanyName;
        }
        public void load()
        {
            CompanyName.Text = s.CompanyName;
            settings_page();
        }
        
        private void employees_Click(object sender, EventArgs e)
        {
            employees_page();
        }
        private void del_Click(object sender, EventArgs e)
        {
            foreach (employee.employee emp in emp_flowLayoutPanel.Controls.Cast<employee.employee>())
            {
                if (emp.Isfocus)
                {
                    db.search("員工", "UID='" + emp.UID + "'");
                    db.del("dbo.員工", "UID='"+emp.UID+"'");
                    FileInfo file = new FileInfo(emp.ID.ToString() + ".png");
                    file.Delete();
                }
            }
            getData();
        }
        private void select_Click(object sender, EventArgs e)
        {
            foreach (employee.employee emp in emp_flowLayoutPanel.Controls.Cast<employee.employee>())
            {
                ((employee.employee)emp).focusable = true;
                ((employee.employee)emp).Isfocus = true;
            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            del.Visible = false;
            select.Visible = false;
            cancel.Visible = false;
            foreach (employee.employee emp in emp_flowLayoutPanel.Controls.Cast<employee.employee>())
            {
                ((employee.employee)emp).focusable = false;
                ((employee.employee)emp).Isfocus = false;
            }
        }

        private void toExcel_button_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                toExcel(saveFileDialog.FileName);
            }
        }

        private void setting_Click(object sender, EventArgs e)
        {
            settings_page();
        }
        private void setting_submit_Click(object sender, EventArgs e)
        {
            s.CompanyName = company_textBox.Text;
            s.save();
        }
        private void setting_reset_Click(object sender, EventArgs e)
        {
            s.ip = s.Dip;
            s.CompanyName = s.DCompanyName;
            s.save();
        }
        
        public void employees_page()
        {
            emp_panel.Dock = DockStyle.Fill;
            setting_panel.Dock = DockStyle.None;
        }
        public void settings_page()
        {
            company_textBox.Text = s.CompanyName;
            setting_panel.Dock = DockStyle.Fill;
            emp_panel.Dock = DockStyle.None;
        }


        public void getData()
        {
            
            foreach (employee.employee emp in emp_flowLayoutPanel.Controls.Cast<employee.employee>())
            {
                emp_flowLayoutPanel.Controls.Clear() ;
            }
            db.search("員工");
            DataTable data = db.dataTable;
            DataView dv = data.DefaultView;
            dv.Sort = "部門";
            data = dv.ToTable();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                employee.employee e = new employee.employee();
                e.ID = int.Parse(data.Rows[i]["ID"].ToString());
                e.UID = data.Rows[i]["UID"].ToString().Trim();
                e.姓名 = data.Rows[i]["姓名"].ToString().Trim();
                e.部門 = data.Rows[i]["部門"].ToString().Trim();
                e.職位 = data.Rows[i]["職位"].ToString().Trim();
                e.Location = new Point(3, 3);
                Image img = Image.FromFile("face/" + data.Rows[i]["ID"].ToString() + ".png");
                e.image = img;
                e.onClick += new System.EventHandler(getEmp);
                e.onDoubleClick += new System.EventHandler(update);
                e.Isfocus = false;
                this.emp_flowLayoutPanel.Controls.Add(e);
            }
        }
        private void update(object sender, EventArgs e)
        {
            Console.WriteLine("132");
            Update u = new Update(((employee.employee)sender).ID, ((employee.employee)sender).image, ((employee.employee)sender).姓名, ((employee.employee)sender).UID, ((employee.employee)sender).職位, ((employee.employee)sender).部門);
            u.Show();
            u.update += U_update;
        }

        private void U_update(Update u)
        {
            db.update(u.id, u.name, u.position, u.department, u.uid);
            getData();
        }

        private void getEmp(object sender, EventArgs e)
        {
            del.Visible = true;
            select.Visible = true;
            cancel.Visible = true;
            foreach (employee.employee emp in emp_flowLayoutPanel.Controls.Cast<employee.employee>())
            {
                ((employee.employee)emp).focusable = true;
            }
            ((employee.employee)sender).Isfocus = true;
        }

        private void toExcel(string path)
        {
            db.search("打卡紀錄");
            DataTable dtrecord = db.dataTable;
            ApplicationClass xlsxapp = new ApplicationClass();
            Workbook wbook = xlsxapp.Workbooks.Add(true);
            Worksheet wsheet = (Worksheet)wbook.Worksheets.get_Item(1);

            wsheet.Cells[1, 1] = "UID";
            wsheet.Cells[1, 2] = "姓名";
            wsheet.Cells[1, 3] = "打卡時間";
            wsheet.Cells[1, 4] = "上下班";

            for(int i=0; i<dtrecord.Rows.Count; i++)
            {
                try
                {
                    db.search("員工", "ID=" + dtrecord.Rows[i]["ID"].ToString());
                    wsheet.Cells[2 + i, 1] = db.dataTable.Rows[0]["UID"];
                    wsheet.Cells[2 + i, 2] = db.dataTable.Rows[0]["姓名"];
                    wsheet.Cells[2 + i, 3] = dtrecord.Rows[i]["時間"].ToString();
                    wsheet.Cells[2 + i, 4] = dtrecord.Rows[i]["上下班"];
                }
                catch
                {
                    wsheet.Cells[2 + i, 1] = dtrecord.Rows[i]["ID"];
                    wsheet.Cells[2 + i, 2] = "查無此人";
                    wsheet.Cells[2 + i, 3] = dtrecord.Rows[i]["時間"].ToString();
                    wsheet.Cells[2 + i, 4] = dtrecord.Rows[i]["上下班"];
                }
                
            }

            wbook.SaveAs(path);
            xlsxapp.Quit();
        }
    }
}
