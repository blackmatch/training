namespace training
{
    partial class EntryForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.adminPwdTextBox = new System.Windows.Forms.TextBox();
            this.adminUserNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.istPwdTextBox = new System.Windows.Forms.TextBox();
            this.istNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.traineePwdTextBox = new System.Windows.Forms.TextBox();
            this.traineeJobNumberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTabControl
            // 
            this.loginTabControl.Controls.Add(this.tabPage1);
            this.loginTabControl.Controls.Add(this.tabPage2);
            this.loginTabControl.Controls.Add(this.tabPage3);
            this.loginTabControl.Location = new System.Drawing.Point(12, 42);
            this.loginTabControl.Name = "loginTabControl";
            this.loginTabControl.SelectedIndex = 0;
            this.loginTabControl.Size = new System.Drawing.Size(472, 272);
            this.loginTabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.adminPwdTextBox);
            this.tabPage1.Controls.Add(this.adminUserNameTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(464, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "管理员入口";
            // 
            // adminPwdTextBox
            // 
            this.adminPwdTextBox.Location = new System.Drawing.Point(126, 109);
            this.adminPwdTextBox.Name = "adminPwdTextBox";
            this.adminPwdTextBox.Size = new System.Drawing.Size(199, 21);
            this.adminPwdTextBox.TabIndex = 3;
            this.adminPwdTextBox.UseSystemPasswordChar = true;
            // 
            // adminUserNameTextBox
            // 
            this.adminUserNameTextBox.Location = new System.Drawing.Point(126, 47);
            this.adminUserNameTextBox.Name = "adminUserNameTextBox";
            this.adminUserNameTextBox.Size = new System.Drawing.Size(199, 21);
            this.adminUserNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.istPwdTextBox);
            this.tabPage2.Controls.Add(this.istNumberTextBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(464, 246);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "教员入口";
            // 
            // istPwdTextBox
            // 
            this.istPwdTextBox.Location = new System.Drawing.Point(122, 104);
            this.istPwdTextBox.Name = "istPwdTextBox";
            this.istPwdTextBox.Size = new System.Drawing.Size(198, 21);
            this.istPwdTextBox.TabIndex = 3;
            this.istPwdTextBox.UseSystemPasswordChar = true;
            // 
            // istNumberTextBox
            // 
            this.istNumberTextBox.Location = new System.Drawing.Point(122, 41);
            this.istNumberTextBox.Name = "istNumberTextBox";
            this.istNumberTextBox.Size = new System.Drawing.Size(198, 21);
            this.istNumberTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "登录密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "教员编号：";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.traineePwdTextBox);
            this.tabPage3.Controls.Add(this.traineeJobNumberTextBox);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(464, 246);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "学员入口";
            // 
            // traineePwdTextBox
            // 
            this.traineePwdTextBox.Location = new System.Drawing.Point(116, 102);
            this.traineePwdTextBox.Name = "traineePwdTextBox";
            this.traineePwdTextBox.Size = new System.Drawing.Size(197, 21);
            this.traineePwdTextBox.TabIndex = 3;
            this.traineePwdTextBox.UseSystemPasswordChar = true;
            // 
            // traineeJobNumberTextBox
            // 
            this.traineeJobNumberTextBox.Location = new System.Drawing.Point(116, 46);
            this.traineeJobNumberTextBox.Name = "traineeJobNumberTextBox";
            this.traineeJobNumberTextBox.Size = new System.Drawing.Size(197, 21);
            this.traineeJobNumberTextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "工号：";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(200, 333);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 27);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "登录";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(511, 383);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginTabControl);
            this.Name = "EntryForm";
            this.Text = "欢迎使用上海元达网络培训管理系统";
            this.loginTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl loginTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox adminPwdTextBox;
        private System.Windows.Forms.TextBox adminUserNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox istPwdTextBox;
        private System.Windows.Forms.TextBox istNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox traineePwdTextBox;
        private System.Windows.Forms.TextBox traineeJobNumberTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;

    }
}

