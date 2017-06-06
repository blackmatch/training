namespace training.common
{
    partial class UpdatePwdForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oldPwdTextBox = new System.Windows.Forms.TextBox();
            this.newPwdTextBox2 = new System.Windows.Forms.TextBox();
            this.newPwdTextBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "旧密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认新密码：";
            // 
            // oldPwdTextBox
            // 
            this.oldPwdTextBox.Location = new System.Drawing.Point(137, 40);
            this.oldPwdTextBox.Name = "oldPwdTextBox";
            this.oldPwdTextBox.Size = new System.Drawing.Size(148, 21);
            this.oldPwdTextBox.TabIndex = 3;
            this.oldPwdTextBox.UseSystemPasswordChar = true;
            // 
            // newPwdTextBox2
            // 
            this.newPwdTextBox2.Location = new System.Drawing.Point(137, 125);
            this.newPwdTextBox2.Name = "newPwdTextBox2";
            this.newPwdTextBox2.Size = new System.Drawing.Size(148, 21);
            this.newPwdTextBox2.TabIndex = 4;
            this.newPwdTextBox2.UseSystemPasswordChar = true;
            // 
            // newPwdTextBox
            // 
            this.newPwdTextBox.Location = new System.Drawing.Point(137, 87);
            this.newPwdTextBox.Name = "newPwdTextBox";
            this.newPwdTextBox.Size = new System.Drawing.Size(148, 21);
            this.newPwdTextBox.TabIndex = 5;
            this.newPwdTextBox.UseSystemPasswordChar = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(81, 219);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(210, 219);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 7;
            this.okBtn.Text = "确定";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // UpdatePwdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 271);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.newPwdTextBox);
            this.Controls.Add(this.newPwdTextBox2);
            this.Controls.Add(this.oldPwdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePwdForm";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldPwdTextBox;
        private System.Windows.Forms.TextBox newPwdTextBox2;
        private System.Windows.Forms.TextBox newPwdTextBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
    }
}