namespace training.instructor
{
    partial class InstructorForm
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updatePwdBtn = new System.Windows.Forms.Button();
            this.editInfoBtn = new System.Windows.Forms.Button();
            this.ageLabel = new System.Windows.Forms.Label();
            this.istNumLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabControl1.Size = new System.Drawing.Size(646, 324);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.refreshCourseBtn);
            this.tabPage1.Controls.Add(this.courseDetailBtn);
            this.tabPage1.Controls.Add(this.courseDgView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "课程管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // refreshCourseBtn
            // 
            this.refreshCourseBtn.Location = new System.Drawing.Point(113, 33);
            this.refreshCourseBtn.Name = "refreshCourseBtn";
            this.refreshCourseBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshCourseBtn.TabIndex = 2;
            this.refreshCourseBtn.Text = "刷新";
            this.refreshCourseBtn.UseVisualStyleBackColor = true;
            // 
            // courseDetailBtn
            // 
            this.courseDetailBtn.Location = new System.Drawing.Point(6, 33);
            this.courseDetailBtn.Name = "courseDetailBtn";
            this.courseDetailBtn.Size = new System.Drawing.Size(75, 23);
            this.courseDetailBtn.TabIndex = 1;
            this.courseDetailBtn.Text = "查看详情";
            this.courseDetailBtn.UseVisualStyleBackColor = true;
            this.courseDetailBtn.Click += new System.EventHandler(this.courseDetailBtn_Click);
            // 
            // courseDgView
            // 
            this.courseDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.beginDate,
            this.endDate,
            this.addr,
            this.remark});
            this.courseDgView.Location = new System.Drawing.Point(6, 86);
            this.courseDgView.MultiSelect = false;
            this.courseDgView.Name = "courseDgView";
            this.courseDgView.RowTemplate.Height = 23;
            this.courseDgView.Size = new System.Drawing.Size(626, 206);
            this.courseDgView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.updatePwdBtn);
            this.tabPage2.Controls.Add(this.editInfoBtn);
            this.tabPage2.Controls.Add(this.ageLabel);
            this.tabPage2.Controls.Add(this.istNumLabel);
            this.tabPage2.Controls.Add(this.genderLabel);
            this.tabPage2.Controls.Add(this.nameLabel);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "我的信息";
            // 
            // updatePwdBtn
            // 
            this.updatePwdBtn.Location = new System.Drawing.Point(257, 238);
            this.updatePwdBtn.Name = "updatePwdBtn";
            this.updatePwdBtn.Size = new System.Drawing.Size(75, 23);
            this.updatePwdBtn.TabIndex = 9;
            this.updatePwdBtn.Text = "修改密码";
            this.updatePwdBtn.UseVisualStyleBackColor = true;
            // 
            // editInfoBtn
            // 
            this.editInfoBtn.Location = new System.Drawing.Point(61, 238);
            this.editInfoBtn.Name = "editInfoBtn";
            this.editInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.editInfoBtn.TabIndex = 8;
            this.editInfoBtn.Text = "修改信息";
            this.editInfoBtn.UseVisualStyleBackColor = true;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ageLabel.ForeColor = System.Drawing.Color.Navy;
            this.ageLabel.Location = new System.Drawing.Point(128, 140);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(42, 16);
            this.ageLabel.TabIndex = 7;
            this.ageLabel.Text = "大蓝";
            // 
            // istNumLabel
            // 
            this.istNumLabel.AutoSize = true;
            this.istNumLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.istNumLabel.ForeColor = System.Drawing.Color.Navy;
            this.istNumLabel.Location = new System.Drawing.Point(128, 70);
            this.istNumLabel.Name = "istNumLabel";
            this.istNumLabel.Size = new System.Drawing.Size(42, 16);
            this.istNumLabel.TabIndex = 6;
            this.istNumLabel.Text = "大蓝";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.genderLabel.ForeColor = System.Drawing.Color.Navy;
            this.genderLabel.Location = new System.Drawing.Point(128, 105);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(42, 16);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "大蓝";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.ForeColor = System.Drawing.Color.Navy;
            this.nameLabel.Location = new System.Drawing.Point(128, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 16);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "大蓝";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "年龄：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "教员编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
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
            this.addr.HeaderText = "地点";
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
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 352);
            this.Controls.Add(this.tabControl1);
            this.Name = "InstructorForm";
            this.Text = "我是教员";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label istNumLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button updatePwdBtn;
        private System.Windows.Forms.Button editInfoBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
    }
}