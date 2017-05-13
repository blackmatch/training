namespace training.Admin
{
    partial class EditTraineeForm
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
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.genderComBo = new System.Windows.Forms.ComboBox();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.jobNumTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(389, 287);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 21;
            this.okBtn.Text = "确定";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(221, 287);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // genderComBo
            // 
            this.genderComBo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComBo.FormattingEnabled = true;
            this.genderComBo.Items.AddRange(new object[] {
            "男",
            "女"});
            this.genderComBo.Location = new System.Drawing.Point(221, 147);
            this.genderComBo.MaxDropDownItems = 2;
            this.genderComBo.Name = "genderComBo";
            this.genderComBo.Size = new System.Drawing.Size(243, 20);
            this.genderComBo.TabIndex = 19;
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(221, 189);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(243, 21);
            this.ageTB.TabIndex = 18;
            // 
            // jobNumTB
            // 
            this.jobNumTB.Enabled = false;
            this.jobNumTB.Location = new System.Drawing.Point(221, 100);
            this.jobNumTB.Name = "jobNumTB";
            this.jobNumTB.Size = new System.Drawing.Size(243, 21);
            this.jobNumTB.TabIndex = 17;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(221, 52);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(243, 21);
            this.nameTB.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "年龄：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "工号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "姓名：";
            // 
            // EditTraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(574, 345);
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
            this.Name = "EditTraineeForm";
            this.Text = "修改学员信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox genderComBo;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.TextBox jobNumTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}