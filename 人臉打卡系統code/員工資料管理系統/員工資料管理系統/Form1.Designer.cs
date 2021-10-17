namespace 員工資料管理系統
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Top_panel = new System.Windows.Forms.Panel();
            this.toExcel_button = new System.Windows.Forms.Button();
            this.employees = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.CompanyName = new System.Windows.Forms.Label();
            this.emp_panel = new System.Windows.Forms.Panel();
            this.select = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.emp_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.setting_reset = new System.Windows.Forms.Button();
            this.setting_submit = new System.Windows.Forms.Button();
            this.company_textBox = new System.Windows.Forms.TextBox();
            this.company_label = new System.Windows.Forms.Label();
            this.setting_panel = new System.Windows.Forms.Panel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Top_panel.SuspendLayout();
            this.emp_panel.SuspendLayout();
            this.setting_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(112)))), ((int)(((byte)(155)))));
            this.Top_panel.Controls.Add(this.toExcel_button);
            this.Top_panel.Controls.Add(this.employees);
            this.Top_panel.Controls.Add(this.setting);
            this.Top_panel.Controls.Add(this.CompanyName);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_panel.Margin = new System.Windows.Forms.Padding(6);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(893, 70);
            this.Top_panel.TabIndex = 1;
            // 
            // toExcel_button
            // 
            this.toExcel_button.FlatAppearance.BorderSize = 0;
            this.toExcel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toExcel_button.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toExcel_button.ForeColor = System.Drawing.Color.White;
            this.toExcel_button.Image = ((System.Drawing.Image)(resources.GetObject("toExcel_button.Image")));
            this.toExcel_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toExcel_button.Location = new System.Drawing.Point(788, 18);
            this.toExcel_button.Name = "toExcel_button";
            this.toExcel_button.Size = new System.Drawing.Size(42, 35);
            this.toExcel_button.TabIndex = 5;
            this.toExcel_button.UseVisualStyleBackColor = true;
            this.toExcel_button.Click += new System.EventHandler(this.toExcel_button_Click);
            // 
            // employees
            // 
            this.employees.FlatAppearance.BorderSize = 0;
            this.employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employees.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.employees.ForeColor = System.Drawing.Color.White;
            this.employees.Image = ((System.Drawing.Image)(resources.GetObject("employees.Image")));
            this.employees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.employees.Location = new System.Drawing.Point(740, 18);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(42, 35);
            this.employees.TabIndex = 4;
            this.employees.UseVisualStyleBackColor = true;
            this.employees.Click += new System.EventHandler(this.employees_Click);
            // 
            // setting
            // 
            this.setting.FlatAppearance.BorderSize = 0;
            this.setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.setting.ForeColor = System.Drawing.Color.White;
            this.setting.Image = ((System.Drawing.Image)(resources.GetObject("setting.Image")));
            this.setting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.setting.Location = new System.Drawing.Point(836, 18);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(42, 35);
            this.setting.TabIndex = 2;
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.CompanyName.ForeColor = System.Drawing.Color.White;
            this.CompanyName.Location = new System.Drawing.Point(11, 15);
            this.CompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(218, 35);
            this.CompanyName.TabIndex = 0;
            this.CompanyName.Text = "CompanyName";
            // 
            // emp_panel
            // 
            this.emp_panel.Controls.Add(this.select);
            this.emp_panel.Controls.Add(this.cancel);
            this.emp_panel.Controls.Add(this.del);
            this.emp_panel.Controls.Add(this.emp_flowLayoutPanel);
            this.emp_panel.Location = new System.Drawing.Point(0, 70);
            this.emp_panel.Name = "emp_panel";
            this.emp_panel.Size = new System.Drawing.Size(0, 0);
            this.emp_panel.TabIndex = 2;
            // 
            // select
            // 
            this.select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select.Location = new System.Drawing.Point(100, 26);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(94, 41);
            this.select.TabIndex = 5;
            this.select.Text = "全選";
            this.select.UseVisualStyleBackColor = true;
            this.select.Visible = false;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // cancel
            // 
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Location = new System.Drawing.Point(375, 26);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(94, 41);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Visible = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // del
            // 
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.Location = new System.Drawing.Point(236, 26);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(94, 41);
            this.del.TabIndex = 3;
            this.del.Text = "刪除";
            this.del.UseVisualStyleBackColor = true;
            this.del.Visible = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // emp_flowLayoutPanel
            // 
            this.emp_flowLayoutPanel.Location = new System.Drawing.Point(17, 73);
            this.emp_flowLayoutPanel.Name = "emp_flowLayoutPanel";
            this.emp_flowLayoutPanel.Size = new System.Drawing.Size(861, 444);
            this.emp_flowLayoutPanel.TabIndex = 0;
            // 
            // setting_reset
            // 
            this.setting_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_reset.Font = new System.Drawing.Font("新細明體", 15F);
            this.setting_reset.Location = new System.Drawing.Point(459, 390);
            this.setting_reset.Name = "setting_reset";
            this.setting_reset.Size = new System.Drawing.Size(117, 48);
            this.setting_reset.TabIndex = 26;
            this.setting_reset.Text = "重置";
            this.setting_reset.UseVisualStyleBackColor = true;
            this.setting_reset.Click += new System.EventHandler(this.setting_reset_Click);
            // 
            // setting_submit
            // 
            this.setting_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_submit.Font = new System.Drawing.Font("新細明體", 15F);
            this.setting_submit.Location = new System.Drawing.Point(213, 390);
            this.setting_submit.Name = "setting_submit";
            this.setting_submit.Size = new System.Drawing.Size(117, 48);
            this.setting_submit.TabIndex = 25;
            this.setting_submit.Text = "更改";
            this.setting_submit.UseVisualStyleBackColor = true;
            this.setting_submit.Click += new System.EventHandler(this.setting_submit_Click);
            // 
            // company_textBox
            // 
            this.company_textBox.Font = new System.Drawing.Font("新細明體", 15F);
            this.company_textBox.Location = new System.Drawing.Point(347, 87);
            this.company_textBox.Name = "company_textBox";
            this.company_textBox.Size = new System.Drawing.Size(297, 31);
            this.company_textBox.TabIndex = 22;
            // 
            // company_label
            // 
            this.company_label.AutoSize = true;
            this.company_label.Font = new System.Drawing.Font("新細明體", 15F);
            this.company_label.Location = new System.Drawing.Point(164, 90);
            this.company_label.Name = "company_label";
            this.company_label.Size = new System.Drawing.Size(131, 20);
            this.company_label.TabIndex = 21;
            this.company_label.Text = "Company Name";
            // 
            // setting_panel
            // 
            this.setting_panel.Controls.Add(this.setting_reset);
            this.setting_panel.Controls.Add(this.setting_submit);
            this.setting_panel.Controls.Add(this.company_textBox);
            this.setting_panel.Controls.Add(this.company_label);
            this.setting_panel.Location = new System.Drawing.Point(0, 70);
            this.setting_panel.Name = "setting_panel";
            this.setting_panel.Size = new System.Drawing.Size(0, 0);
            this.setting_panel.TabIndex = 4;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xlsx";
            this.saveFileDialog.Filter = "匯出excel|*.xlsx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 600);
            this.Controls.Add(this.setting_panel);
            this.Controls.Add(this.emp_panel);
            this.Controls.Add(this.Top_panel);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Top_panel.ResumeLayout(false);
            this.Top_panel.PerformLayout();
            this.emp_panel.ResumeLayout(false);
            this.setting_panel.ResumeLayout(false);
            this.setting_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.Button employees;
        private System.Windows.Forms.Panel emp_panel;
        private System.Windows.Forms.FlowLayoutPanel emp_flowLayoutPanel;
        private System.Windows.Forms.Button setting_reset;
        private System.Windows.Forms.Button setting_submit;
        private System.Windows.Forms.TextBox company_textBox;
        private System.Windows.Forms.Label company_label;
        private System.Windows.Forms.Panel setting_panel;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button toExcel_button;
    }
}

