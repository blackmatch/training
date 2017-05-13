namespace training.trainee
{
    partial class TraineeForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.refreshCourseBtn = new System.Windows.Forms.Button();
            this.courseDetailBtn = new System.Windows.Forms.Button();
            this.courseDgView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updatePwdBtn = new System.Windows.Forms.Button();
            this.editInfoBtn = new System.Windows.Forms.Button();
            this.ageLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.jobNumberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseDgView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(638, 322);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage1.Controls.Add(this.refreshCourseBtn);
            this.tabPage1.Controls.Add(this.courseDetailBtn);
            this.tabPage1.Controls.Add(this.courseDgView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(630, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "我的课程";
            // 
            // refreshCourseBtn
            // 
            this.refreshCourseBtn.Location = new System.Drawing.Point(110, 26);
            this.refreshCourseBtn.Name = "refreshCourseBtn";
            this.refreshCourseBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshCourseBtn.TabIndex = 3;
            this.refreshCourseBtn.Text = "刷新";
            this.refreshCourseBtn.UseVisualStyleBackColor = true;
            // 
            // courseDetailBtn
            // 
            this.courseDetailBtn.Location = new System.Drawing.Point(6, 26);
            this.courseDetailBtn.Name = "courseDetailBtn";
            this.courseDetailBtn.Size = new System.Drawing.Size(75, 23);
            this.courseDetailBtn.TabIndex = 1;
            this.courseDetailBtn.Text = "查看详情";
            this.courseDetailBtn.UseVisualStyleBackColor = true;
            this.courseDetailBtn.Click += new System.EventHandler(this.courseDetailBtn_Click);
            // 
            // courseDgView
            // 
            this.courseDgView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.courseDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.istName,
            this.beginDate,
            this.endDate,
            this.addr,
            this.remark});
            this.courseDgView.Location = new System.Drawing.Point(6, 67);
            this.courseDgView.Name = "courseDgView";
            this.courseDgView.RowTemplate.Height = 23;
            this.courseDgView.Size = new System.Drawing.Size(618, 210);
            this.courseDgView.TabIndex = 0;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "课程名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // istName
            // 
            this.istName.DataPropertyName = "istName";
            this.istName.HeaderText = "教员";
            this.istName.Name = "istName";
            this.istName.ReadOnly = true;
            // 
            // beginDate
            // 
            this.beginDate.DataPropertyName = "beginDate";
            this.beginDate.HeaderText = "开始日期";
            this.beginDate.Name = "beginDate";
            this.beginDate.ReadOnly = true;
            // 
            // endDate
            // 
            this.endDate.DataPropertyName = "endDate";
            this.endDate.HeaderText = "结束日期";
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            // 
            // addr
            // 
            this.addr.DataPropertyName = "addr";
            this.addr.HeaderText = "培训地点";
            this.addr.Name = "addr";
            this.addr.ReadOnly = true;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "备注";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.updatePwdBtn);
            this.tabPage2.Controls.Add(this.editInfoBtn);
            this.tabPage2.Controls.Add(this.ageLabel);
            this.tabPage2.Controls.Add(this.genderLabel);
            this.tabPage2.Controls.Add(this.jobNumberLabel);
            this.tabPage2.Controls.Add(this.nameLabel);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(630, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "个人信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // updatePwdBtn
            // 
            this.updatePwdBtn.Location = new System.Drawing.Point(193, 253);
            this.updatePwdBtn.Name = "updatePwdBtn";
            this.updatePwdBtn.Size = new System.Drawing.Size(75, 23);
            this.updatePwdBtn.TabIndex = 9;
            this.updatePwdBtn.Text = "修改密码";
            this.updatePwdBtn.UseVisualStyleBackColor = true;
            this.updatePwdBtn.Click += new System.EventHandler(this.updatePwdBtn_Click);
            // 
            // editInfoBtn
            // 
            this.editInfoBtn.Location = new System.Drawing.Point(33, 253);
            this.editInfoBtn.Name = "editInfoBtn";
            this.editInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.editInfoBtn.TabIndex = 8;
            this.editInfoBtn.Text = "修改信息";
            this.editInfoBtn.UseVisualStyleBackColor = true;
            this.editInfoBtn.Click += new System.EventHandler(this.editInfoBtn_Click);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(89, 166);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(29, 12);
            this.ageLabel.TabIndex = 7;
            this.ageLabel.Text = "年龄";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(89, 129);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(29, 12);
            this.genderLabel.TabIndex = 6;
            this.genderLabel.Text = "性别";
            // 
            // jobNumberLabel
            // 
            this.jobNumberLabel.AutoSize = true;
            this.jobNumberLabel.Location = new System.Drawing.Point(89, 90);
            this.jobNumberLabel.Name = "jobNumberLabel";
            this.jobNumberLabel.Size = new System.Drawing.Size(29, 12);
            this.jobNumberLabel.TabIndex = 5;
            this.jobNumberLabel.Text = "工号";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(89, 49);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 12);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "年龄：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "工号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // TraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(662, 344);
            this.Controls.Add(this.tabControl1);
            this.Name = "TraineeForm";
            this.Text = "我是学员";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseDgView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button refreshCourseBtn;
        private System.Windows.Forms.Button courseDetailBtn;
        private System.Windows.Forms.DataGridView courseDgView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button updatePwdBtn;
        private System.Windows.Forms.Button editInfoBtn;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label jobNumberLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn istName;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
    }
}