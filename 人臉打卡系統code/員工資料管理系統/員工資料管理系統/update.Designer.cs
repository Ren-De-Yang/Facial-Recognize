namespace 員工資料管理系統
{
    partial class Update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancel_add_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.department_textBox = new System.Windows.Forms.TextBox();
            this.apartment_label = new System.Windows.Forms.Label();
            this.position_textBox = new System.Windows.Forms.TextBox();
            this.position_label = new System.Windows.Forms.Label();
            this.uid_textBox = new System.Windows.Forms.TextBox();
            this.uid_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.add_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.add_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_add_button
            // 
            this.cancel_add_button.Location = new System.Drawing.Point(238, 371);
            this.cancel_add_button.Name = "cancel_add_button";
            this.cancel_add_button.Size = new System.Drawing.Size(136, 57);
            this.cancel_add_button.TabIndex = 21;
            this.cancel_add_button.Text = "取消";
            this.cancel_add_button.UseVisualStyleBackColor = true;
            this.cancel_add_button.Click += new System.EventHandler(this.cancel_add_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(64, 371);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(136, 57);
            this.add_button.TabIndex = 20;
            this.add_button.Text = "更新";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // department_textBox
            // 
            this.department_textBox.Location = new System.Drawing.Point(163, 276);
            this.department_textBox.Name = "department_textBox";
            this.department_textBox.Size = new System.Drawing.Size(239, 22);
            this.department_textBox.TabIndex = 18;
            // 
            // apartment_label
            // 
            this.apartment_label.AutoSize = true;
            this.apartment_label.Location = new System.Drawing.Point(53, 279);
            this.apartment_label.Name = "apartment_label";
            this.apartment_label.Size = new System.Drawing.Size(29, 12);
            this.apartment_label.TabIndex = 17;
            this.apartment_label.Text = "部門";
            // 
            // position_textBox
            // 
            this.position_textBox.Location = new System.Drawing.Point(163, 183);
            this.position_textBox.Name = "position_textBox";
            this.position_textBox.Size = new System.Drawing.Size(239, 22);
            this.position_textBox.TabIndex = 16;
            // 
            // position_label
            // 
            this.position_label.AutoSize = true;
            this.position_label.Location = new System.Drawing.Point(53, 186);
            this.position_label.Name = "position_label";
            this.position_label.Size = new System.Drawing.Size(29, 12);
            this.position_label.TabIndex = 15;
            this.position_label.Text = "職位";
            // 
            // uid_textBox
            // 
            this.uid_textBox.Location = new System.Drawing.Point(163, 97);
            this.uid_textBox.Name = "uid_textBox";
            this.uid_textBox.Size = new System.Drawing.Size(239, 22);
            this.uid_textBox.TabIndex = 14;
            // 
            // uid_label
            // 
            this.uid_label.AutoSize = true;
            this.uid_label.Location = new System.Drawing.Point(53, 100);
            this.uid_label.Name = "uid_label";
            this.uid_label.Size = new System.Drawing.Size(25, 12);
            this.uid_label.TabIndex = 13;
            this.uid_label.Text = "UID";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(163, 26);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(239, 22);
            this.name_textBox.TabIndex = 12;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(53, 29);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(29, 12);
            this.name_label.TabIndex = 11;
            this.name_label.Text = "姓名";
            // 
            // add_pictureBox
            // 
            this.add_pictureBox.Location = new System.Drawing.Point(459, 21);
            this.add_pictureBox.Name = "add_pictureBox";
            this.add_pictureBox.Size = new System.Drawing.Size(288, 283);
            this.add_pictureBox.TabIndex = 19;
            this.add_pictureBox.TabStop = false;
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel_add_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.add_pictureBox);
            this.Controls.Add(this.department_textBox);
            this.Controls.Add(this.apartment_label);
            this.Controls.Add(this.position_textBox);
            this.Controls.Add(this.position_label);
            this.Controls.Add(this.uid_textBox);
            this.Controls.Add(this.uid_label);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.name_label);
            this.Name = "update";
            this.Text = "update";
            ((System.ComponentModel.ISupportInitialize)(this.add_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_add_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox department_textBox;
        private System.Windows.Forms.Label apartment_label;
        private System.Windows.Forms.TextBox position_textBox;
        private System.Windows.Forms.Label position_label;
        private System.Windows.Forms.TextBox uid_textBox;
        private System.Windows.Forms.Label uid_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.PictureBox add_pictureBox;
    }
}