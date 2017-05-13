namespace training.Admin
{
    partial class CourseAddTraineeForm
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
            this.traineeDgView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.traineeDgView)).BeginInit();
            this.SuspendLayout();
            // 
            // traineeDgView
            // 
            this.traineeDgView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.traineeDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traineeDgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.jobNumber});
            this.traineeDgView.Location = new System.Drawing.Point(12, 60);
            this.traineeDgView.MultiSelect = false;
            this.traineeDgView.Name = "traineeDgView";
            this.traineeDgView.RowTemplate.Height = 23;
            this.traineeDgView.Size = new System.Drawing.Size(258, 268);
            this.traineeDgView.TabIndex = 0;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // jobNumber
            // 
            this.jobNumber.DataPropertyName = "jobNumber";
            this.jobNumber.HeaderText = "工号";
            this.jobNumber.Name = "jobNumber";
            this.jobNumber.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "温馨提示：请勿重复添加学员到同一个课程。";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(295, 120);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "确定";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(295, 204);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // CourseAddTraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(551, 352);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.traineeDgView);
            this.Name = "CourseAddTraineeForm";
            this.Text = "添加学员到课程";
            ((System.ComponentModel.ISupportInitialize)(this.traineeDgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView traineeDgView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNumber;
    }
}