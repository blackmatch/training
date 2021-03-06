﻿namespace training.Admin
{
    partial class EditCourseForm
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
            this.istComBo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.remarkRichTB = new System.Windows.Forms.RichTextBox();
            this.addrTB = new System.Windows.Forms.TextBox();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.beginDatePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // istComBo
            // 
            this.istComBo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.istComBo.FormattingEnabled = true;
            this.istComBo.Location = new System.Drawing.Point(135, 166);
            this.istComBo.Name = "istComBo";
            this.istComBo.Size = new System.Drawing.Size(292, 20);
            this.istComBo.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "分配教员：";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(338, 321);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 25;
            this.okBtn.Text = "确认";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(135, 321);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 24;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // remarkRichTB
            // 
            this.remarkRichTB.Location = new System.Drawing.Point(135, 208);
            this.remarkRichTB.Name = "remarkRichTB";
            this.remarkRichTB.Size = new System.Drawing.Size(292, 96);
            this.remarkRichTB.TabIndex = 23;
            this.remarkRichTB.Text = "";
            // 
            // addrTB
            // 
            this.addrTB.Location = new System.Drawing.Point(135, 122);
            this.addrTB.Name = "addrTB";
            this.addrTB.Size = new System.Drawing.Size(292, 21);
            this.addrTB.TabIndex = 22;
            // 
            // endDatePicker
            // 
            this.endDatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(135, 77);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(292, 21);
            this.endDatePicker.TabIndex = 21;
            // 
            // beginDatePicker
            // 
            this.beginDatePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.beginDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.beginDatePicker.Location = new System.Drawing.Point(135, 40);
            this.beginDatePicker.Name = "beginDatePicker";
            this.beginDatePicker.Size = new System.Drawing.Size(292, 21);
            this.beginDatePicker.TabIndex = 20;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(135, 6);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(292, 21);
            this.nameTB.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "备注：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "培训地点：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "结束时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "开始时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "课程名称：";
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(532, 356);
            this.Controls.Add(this.istComBo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.remarkRichTB);
            this.Controls.Add(this.addrTB);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.beginDatePicker);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditCourseForm";
            this.Text = "修改课程";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox istComBo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.RichTextBox remarkRichTB;
        private System.Windows.Forms.TextBox addrTB;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker beginDatePicker;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}