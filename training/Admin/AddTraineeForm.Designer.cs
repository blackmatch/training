namespace training.Admin
{
    partial class AddTraineeForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.jobNumTB = new System.Windows.Forms.TextBox();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.genderComBo = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "工号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "年龄：";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(153, 67);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(243, 21);
            this.nameTB.TabIndex = 5;
            // 
            // jobNumTB
            // 
            this.jobNumTB.Location = new System.Drawing.Point(153, 115);
            this.jobNumTB.Name = "jobNumTB";
            this.jobNumTB.Size = new System.Drawing.Size(243, 21);
            this.jobNumTB.TabIndex = 6;
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(153, 204);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(243, 21);
            this.ageTB.TabIndex = 8;
            // 
            // genderComBo
            // 
            this.genderComBo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComBo.FormattingEnabled = true;
            this.genderComBo.Items.AddRange(new object[] {
            "男",
            "女"});
            this.genderComBo.Location = new System.Drawing.Point(153, 162);
            this.genderComBo.MaxDropDownItems = 2;
            this.genderComBo.Name = "genderComBo";
            this.genderComBo.Size = new System.Drawing.Size(243, 20);
            this.genderComBo.TabIndex = 9;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(153, 272);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(321, 272);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 11;
            this.okBtn.Text = "确定";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // AddTraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(556, 359);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.genderComBo);
            this.Controls.Add(this.ageTB);
            this.Controls.Add(this.jobNumTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTraineeForm";
            this.Text = "新增学员";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox jobNumTB;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.ComboBox genderComBo;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
    }
}