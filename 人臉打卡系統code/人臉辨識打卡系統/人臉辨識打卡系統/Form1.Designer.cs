namespace 人臉辨識打卡系統
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CurrentTime = new System.Windows.Forms.Timer(this.components);
            this.CompanyName = new System.Windows.Forms.Label();
            this.Top_panel = new System.Windows.Forms.Panel();
            this.recognition = new System.Windows.Forms.Button();
            this.backhome = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.setting_panel = new System.Windows.Forms.Panel();
            this.setting_reset = new System.Windows.Forms.Button();
            this.setting_submit = new System.Windows.Forms.Button();
            this.IP_textBox = new System.Windows.Forms.TextBox();
            this.ip_label = new System.Windows.Forms.Label();
            this.company_textBox = new System.Windows.Forms.TextBox();
            this.company_label = new System.Windows.Forms.Label();
            this.home_panel = new System.Windows.Forms.Panel();
            this.day1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.camera_panel = new System.Windows.Forms.Panel();
            this.image = new System.Windows.Forms.PictureBox();
            this.checked_panel = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.work = new System.Windows.Forms.Button();
            this.day = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.hint_panel = new System.Windows.Forms.Panel();
            this.cancel_button = new System.Windows.Forms.Button();
            this.admit_button = new System.Windows.Forms.Button();
            this.time_hint = new System.Windows.Forms.Label();
            this.name_hint = new System.Windows.Forms.Label();
            this.finish_hint = new System.Windows.Forms.Label();
            this.emp_panel = new System.Windows.Forms.Panel();
            this.employees_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.add_panel = new System.Windows.Forms.Panel();
            this.cancel_add_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.add_pictureBox = new System.Windows.Forms.PictureBox();
            this.department_textBox = new System.Windows.Forms.TextBox();
            this.apartment_label = new System.Windows.Forms.Label();
            this.position_textBox = new System.Windows.Forms.TextBox();
            this.position_label = new System.Windows.Forms.Label();
            this.uid_textBox = new System.Windows.Forms.TextBox();
            this.uid_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.Top_panel.SuspendLayout();
            this.setting_panel.SuspendLayout();
            this.home_panel.SuspendLayout();
            this.camera_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.checked_panel.SuspendLayout();
            this.hint_panel.SuspendLayout();
            this.emp_panel.SuspendLayout();
            this.add_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentTime
            // 
            this.CurrentTime.Tick += new System.EventHandler(this.UpdateTime);
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
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(112)))), ((int)(((byte)(155)))));
            this.Top_panel.Controls.Add(this.recognition);
            this.Top_panel.Controls.Add(this.backhome);
            this.Top_panel.Controls.Add(this.setting);
            this.Top_panel.Controls.Add(this.add);
            this.Top_panel.Controls.Add(this.CompanyName);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_panel.Margin = new System.Windows.Forms.Padding(6);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(851, 70);
            this.Top_panel.TabIndex = 0;
            // 
            // recognition
            // 
            this.recognition.FlatAppearance.BorderSize = 0;
            this.recognition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recognition.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.recognition.ForeColor = System.Drawing.Color.White;
            this.recognition.Image = ((System.Drawing.Image)(resources.GetObject("recognition.Image")));
            this.recognition.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.recognition.Location = new System.Drawing.Point(646, 18);
            this.recognition.Name = "recognition";
            this.recognition.Size = new System.Drawing.Size(42, 35);
            this.recognition.TabIndex = 4;
            this.recognition.UseVisualStyleBackColor = true;
            this.recognition.Click += new System.EventHandler(this.recognition_Click);
            // 
            // backhome
            // 
            this.backhome.FlatAppearance.BorderSize = 0;
            this.backhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backhome.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.backhome.ForeColor = System.Drawing.Color.White;
            this.backhome.Image = ((System.Drawing.Image)(resources.GetObject("backhome.Image")));
            this.backhome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backhome.Location = new System.Drawing.Point(598, 18);
            this.backhome.Name = "backhome";
            this.backhome.Size = new System.Drawing.Size(42, 35);
            this.backhome.TabIndex = 3;
            this.backhome.UseVisualStyleBackColor = true;
            this.backhome.Click += new System.EventHandler(this.backhome_Click);
            // 
            // setting
            // 
            this.setting.FlatAppearance.BorderSize = 0;
            this.setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.setting.ForeColor = System.Drawing.Color.White;
            this.setting.Image = ((System.Drawing.Image)(resources.GetObject("setting.Image")));
            this.setting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.setting.Location = new System.Drawing.Point(742, 18);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(42, 35);
            this.setting.TabIndex = 2;
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // add
            // 
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add.Location = new System.Drawing.Point(694, 18);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(42, 35);
            this.add.TabIndex = 1;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // setting_panel
            // 
            this.setting_panel.Controls.Add(this.setting_reset);
            this.setting_panel.Controls.Add(this.setting_submit);
            this.setting_panel.Controls.Add(this.IP_textBox);
            this.setting_panel.Controls.Add(this.ip_label);
            this.setting_panel.Controls.Add(this.company_textBox);
            this.setting_panel.Controls.Add(this.company_label);
            this.setting_panel.Location = new System.Drawing.Point(0, 70);
            this.setting_panel.Name = "setting_panel";
            this.setting_panel.Size = new System.Drawing.Size(0, 0);
            this.setting_panel.TabIndex = 3;
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
            // IP_textBox
            // 
            this.IP_textBox.Font = new System.Drawing.Font("新細明體", 15F);
            this.IP_textBox.Location = new System.Drawing.Point(347, 124);
            this.IP_textBox.Name = "IP_textBox";
            this.IP_textBox.Size = new System.Drawing.Size(297, 31);
            this.IP_textBox.TabIndex = 24;
            // 
            // ip_label
            // 
            this.ip_label.AutoSize = true;
            this.ip_label.Font = new System.Drawing.Font("新細明體", 15F);
            this.ip_label.Location = new System.Drawing.Point(164, 127);
            this.ip_label.Name = "ip_label";
            this.ip_label.Size = new System.Drawing.Size(25, 20);
            this.ip_label.TabIndex = 23;
            this.ip_label.Text = "IP";
            // 
            // company_textBox
            // 
            this.company_textBox.Font = new System.Drawing.Font("新細明體", 15F);
            this.company_textBox.Location = new System.Drawing.Point(347, 188);
            this.company_textBox.Name = "company_textBox";
            this.company_textBox.Size = new System.Drawing.Size(297, 31);
            this.company_textBox.TabIndex = 22;
            // 
            // company_label
            // 
            this.company_label.AutoSize = true;
            this.company_label.Font = new System.Drawing.Font("新細明體", 15F);
            this.company_label.Location = new System.Drawing.Point(164, 191);
            this.company_label.Name = "company_label";
            this.company_label.Size = new System.Drawing.Size(131, 20);
            this.company_label.TabIndex = 21;
            this.company_label.Text = "Company Name";
            // 
            // home_panel
            // 
            this.home_panel.Controls.Add(this.day1);
            this.home_panel.Controls.Add(this.start);
            this.home_panel.Location = new System.Drawing.Point(0, 70);
            this.home_panel.Name = "home_panel";
            this.home_panel.Size = new System.Drawing.Size(0, 0);
            this.home_panel.TabIndex = 1;
            // 
            // day1
            // 
            this.day1.AutoSize = true;
            this.day1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 50F, System.Drawing.FontStyle.Bold);
            this.day1.Location = new System.Drawing.Point(198, 161);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(232, 85);
            this.day1.TabIndex = 8;
            this.day1.Text = "label1";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(335, 341);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(131, 59);
            this.start.TabIndex = 7;
            this.start.Text = "開始打卡";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // camera_panel
            // 
            this.camera_panel.Controls.Add(this.image);
            this.camera_panel.Location = new System.Drawing.Point(0, 70);
            this.camera_panel.Name = "camera_panel";
            this.camera_panel.Size = new System.Drawing.Size(0, 0);
            this.camera_panel.TabIndex = 2;
            this.camera_panel.DockChanged += new System.EventHandler(this.Camera_panel_DockChanged);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(12, 9);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(784, 540);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // checked_panel
            // 
            this.checked_panel.Controls.Add(this.home);
            this.checked_panel.Controls.Add(this.work);
            this.checked_panel.Controls.Add(this.day);
            this.checked_panel.Controls.Add(this.time);
            this.checked_panel.Location = new System.Drawing.Point(0, 70);
            this.checked_panel.Name = "checked_panel";
            this.checked_panel.Size = new System.Drawing.Size(0, 0);
            this.checked_panel.TabIndex = 4;
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(427, 326);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(104, 58);
            this.home.TabIndex = 10;
            this.home.Text = "下班";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // work
            // 
            this.work.Location = new System.Drawing.Point(255, 326);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(104, 58);
            this.work.TabIndex = 9;
            this.work.Text = "上班";
            this.work.UseVisualStyleBackColor = true;
            this.work.Click += new System.EventHandler(this.work_Click);
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F);
            this.day.Location = new System.Drawing.Point(307, 176);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(61, 35);
            this.day.TabIndex = 8;
            this.day.Text = "day";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft JhengHei UI", 50F, System.Drawing.FontStyle.Bold);
            this.time.Location = new System.Drawing.Point(298, 76);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(183, 85);
            this.time.TabIndex = 7;
            this.time.Text = "time";
            // 
            // hint_panel
            // 
            this.hint_panel.Controls.Add(this.cancel_button);
            this.hint_panel.Controls.Add(this.admit_button);
            this.hint_panel.Controls.Add(this.time_hint);
            this.hint_panel.Controls.Add(this.name_hint);
            this.hint_panel.Controls.Add(this.finish_hint);
            this.hint_panel.Location = new System.Drawing.Point(0, 70);
            this.hint_panel.Name = "hint_panel";
            this.hint_panel.Size = new System.Drawing.Size(0, 0);
            this.hint_panel.TabIndex = 5;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(427, 438);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(136, 57);
            this.cancel_button.TabIndex = 4;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // admit_button
            // 
            this.admit_button.Location = new System.Drawing.Point(168, 438);
            this.admit_button.Name = "admit_button";
            this.admit_button.Size = new System.Drawing.Size(136, 57);
            this.admit_button.TabIndex = 3;
            this.admit_button.Text = "確認";
            this.admit_button.UseVisualStyleBackColor = true;
            this.admit_button.Click += new System.EventHandler(this.admit_button_Click);
            // 
            // time_hint
            // 
            this.time_hint.AutoSize = true;
            this.time_hint.Location = new System.Drawing.Point(241, 326);
            this.time_hint.Name = "time_hint";
            this.time_hint.Size = new System.Drawing.Size(54, 25);
            this.time_hint.TabIndex = 2;
            this.time_hint.Text = "time";
            // 
            // name_hint
            // 
            this.name_hint.AutoSize = true;
            this.name_hint.Location = new System.Drawing.Point(240, 233);
            this.name_hint.Name = "name_hint";
            this.name_hint.Size = new System.Drawing.Size(52, 25);
            this.name_hint.TabIndex = 1;
            this.name_hint.Text = "你好";
            // 
            // finish_hint
            // 
            this.finish_hint.AutoSize = true;
            this.finish_hint.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25F);
            this.finish_hint.Location = new System.Drawing.Point(232, 142);
            this.finish_hint.Name = "finish_hint";
            this.finish_hint.Size = new System.Drawing.Size(155, 43);
            this.finish_hint.TabIndex = 0;
            this.finish_hint.Text = "打卡完成";
            // 
            // emp_panel
            // 
            this.emp_panel.Controls.Add(this.employees_flowLayoutPanel);
            this.emp_panel.Location = new System.Drawing.Point(0, 70);
            this.emp_panel.Name = "emp_panel";
            this.emp_panel.Size = new System.Drawing.Size(0, 0);
            this.emp_panel.TabIndex = 6;
            // 
            // employees_flowLayoutPanel
            // 
            this.employees_flowLayoutPanel.Location = new System.Drawing.Point(17, 76);
            this.employees_flowLayoutPanel.Name = "employees_flowLayoutPanel";
            this.employees_flowLayoutPanel.Size = new System.Drawing.Size(767, 473);
            this.employees_flowLayoutPanel.TabIndex = 0;
            // 
            // add_panel
            // 
            this.add_panel.Controls.Add(this.cancel_add_button);
            this.add_panel.Controls.Add(this.add_button);
            this.add_panel.Controls.Add(this.add_pictureBox);
            this.add_panel.Controls.Add(this.department_textBox);
            this.add_panel.Controls.Add(this.apartment_label);
            this.add_panel.Controls.Add(this.position_textBox);
            this.add_panel.Controls.Add(this.position_label);
            this.add_panel.Controls.Add(this.uid_textBox);
            this.add_panel.Controls.Add(this.uid_label);
            this.add_panel.Controls.Add(this.name_textBox);
            this.add_panel.Controls.Add(this.name_label);
            this.add_panel.Location = new System.Drawing.Point(0, 70);
            this.add_panel.Name = "add_panel";
            this.add_panel.Size = new System.Drawing.Size(0, 0);
            this.add_panel.TabIndex = 7;
            // 
            // cancel_add_button
            // 
            this.cancel_add_button.Location = new System.Drawing.Point(508, 420);
            this.cancel_add_button.Name = "cancel_add_button";
            this.cancel_add_button.Size = new System.Drawing.Size(136, 57);
            this.cancel_add_button.TabIndex = 10;
            this.cancel_add_button.Text = "取消";
            this.cancel_add_button.UseVisualStyleBackColor = true;
            this.cancel_add_button.Click += new System.EventHandler(this.cancel_add_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(156, 420);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(136, 57);
            this.add_button.TabIndex = 9;
            this.add_button.Text = " 新增";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // add_pictureBox
            // 
            this.add_pictureBox.Location = new System.Drawing.Point(523, 68);
            this.add_pictureBox.Name = "add_pictureBox";
            this.add_pictureBox.Size = new System.Drawing.Size(288, 283);
            this.add_pictureBox.TabIndex = 8;
            this.add_pictureBox.TabStop = false;
            // 
            // department_textBox
            // 
            this.department_textBox.Location = new System.Drawing.Point(227, 323);
            this.department_textBox.Name = "department_textBox";
            this.department_textBox.Size = new System.Drawing.Size(239, 33);
            this.department_textBox.TabIndex = 7;
            // 
            // apartment_label
            // 
            this.apartment_label.AutoSize = true;
            this.apartment_label.Location = new System.Drawing.Point(117, 326);
            this.apartment_label.Name = "apartment_label";
            this.apartment_label.Size = new System.Drawing.Size(52, 25);
            this.apartment_label.TabIndex = 6;
            this.apartment_label.Text = "部門";
            // 
            // position_textBox
            // 
            this.position_textBox.Location = new System.Drawing.Point(227, 230);
            this.position_textBox.Name = "position_textBox";
            this.position_textBox.Size = new System.Drawing.Size(239, 33);
            this.position_textBox.TabIndex = 5;
            // 
            // position_label
            // 
            this.position_label.AutoSize = true;
            this.position_label.Location = new System.Drawing.Point(117, 233);
            this.position_label.Name = "position_label";
            this.position_label.Size = new System.Drawing.Size(52, 25);
            this.position_label.TabIndex = 4;
            this.position_label.Text = "職位";
            // 
            // uid_textBox
            // 
            this.uid_textBox.Location = new System.Drawing.Point(227, 144);
            this.uid_textBox.Name = "uid_textBox";
            this.uid_textBox.Size = new System.Drawing.Size(239, 33);
            this.uid_textBox.TabIndex = 3;
            // 
            // uid_label
            // 
            this.uid_label.AutoSize = true;
            this.uid_label.Location = new System.Drawing.Point(117, 147);
            this.uid_label.Name = "uid_label";
            this.uid_label.Size = new System.Drawing.Size(48, 25);
            this.uid_label.TabIndex = 2;
            this.uid_label.Text = "UID";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(227, 73);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(239, 33);
            this.name_textBox.TabIndex = 1;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(117, 76);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(52, 25);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "姓名";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 631);
            this.Controls.Add(this.add_panel);
            this.Controls.Add(this.emp_panel);
            this.Controls.Add(this.hint_panel);
            this.Controls.Add(this.checked_panel);
            this.Controls.Add(this.setting_panel);
            this.Controls.Add(this.camera_panel);
            this.Controls.Add(this.home_panel);
            this.Controls.Add(this.Top_panel);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "人臉辨識打卡系統";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Top_panel.ResumeLayout(false);
            this.Top_panel.PerformLayout();
            this.setting_panel.ResumeLayout(false);
            this.setting_panel.PerformLayout();
            this.home_panel.ResumeLayout(false);
            this.home_panel.PerformLayout();
            this.camera_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.checked_panel.ResumeLayout(false);
            this.checked_panel.PerformLayout();
            this.hint_panel.ResumeLayout(false);
            this.hint_panel.PerformLayout();
            this.emp_panel.ResumeLayout(false);
            this.add_panel.ResumeLayout(false);
            this.add_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer CurrentTime;
        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Panel home_panel;
        private System.Windows.Forms.Panel camera_panel;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Panel setting_panel;
        private System.Windows.Forms.Button setting_reset;
        private System.Windows.Forms.Button setting_submit;
        private System.Windows.Forms.TextBox IP_textBox;
        private System.Windows.Forms.Label ip_label;
        private System.Windows.Forms.TextBox company_textBox;
        private System.Windows.Forms.Label company_label;
        private System.Windows.Forms.Label day1;
        private System.Windows.Forms.Panel checked_panel;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button work;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Panel hint_panel;
        private System.Windows.Forms.Label time_hint;
        private System.Windows.Forms.Label name_hint;
        private System.Windows.Forms.Label finish_hint;
        private System.Windows.Forms.Button recognition;
        private System.Windows.Forms.Button backhome;
        private System.Windows.Forms.Panel emp_panel;
        private System.Windows.Forms.FlowLayoutPanel employees_flowLayoutPanel;
        private System.Windows.Forms.Panel add_panel;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button admit_button;
        private System.Windows.Forms.TextBox uid_textBox;
        private System.Windows.Forms.Label uid_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox department_textBox;
        private System.Windows.Forms.Label apartment_label;
        private System.Windows.Forms.TextBox position_textBox;
        private System.Windows.Forms.Label position_label;
        private System.Windows.Forms.Button cancel_add_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.PictureBox add_pictureBox;
    }
}

