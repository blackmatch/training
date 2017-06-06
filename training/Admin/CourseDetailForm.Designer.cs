namespace training.Admin
{
    partial class CourseDetailForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.beginDateLabel = new System.Windows.Forms.Label();
            this.istNameLabel = new System.Windows.Forms.Label();
            this.addrLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.traineeCountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteTraineeBtn = new System.Windows.Forms.Button();
            this.addTraineeBtn = new System.Windows.Forms.Button();
            this.traineeInfoDgView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeInfoDgView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.endDateLabel);
            this.panel1.Controls.Add(this.beginDateLabel);
            this.panel1.Controls.Add(this.istNameLabel);
            this.panel1.Controls.Add(this.addrLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.courseNameLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 133);
            this.panel1.TabIndex = 0;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(406, 68);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(53, 12);
            this.endDateLabel.TabIndex = 10;
            this.endDateLabel.Text = "结束日期";
            // 
            // beginDateLabel
            // 
            this.beginDateLabel.AutoSize = true;
            this.beginDateLabel.Location = new System.Drawing.Point(406, 18);
            this.beginDateLabel.Name = "beginDateLabel";
            this.beginDateLabel.Size = new System.Drawing.Size(53, 12);
            this.beginDateLabel.TabIndex = 9;
            this.beginDateLabel.Text = "开始日期";
            // 
            // istNameLabel
            // 
            this.istNameLabel.AutoSize = true;
            this.istNameLabel.Location = new System.Drawing.Point(96, 68);
            this.istNameLabel.Name = "istNameLabel";
            this.istNameLabel.Size = new System.Drawing.Size(41, 12);
            this.istNameLabel.TabIndex = 8;
            this.istNameLabel.Text = "教员名";
            // 
            // addrLabel
            // 
            this.addrLabel.AutoSize = true;
            this.addrLabel.Location = new System.Drawing.Point(96, 112);
            this.addrLabel.Name = "addrLabel";
            this.addrLabel.Size = new System.Drawing.Size(29, 12);
            this.addrLabel.TabIndex = 7;
            this.addrLabel.Text = "地址";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "开始日期：";
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(96, 18);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(53, 12);
            this.courseNameLabel.TabIndex = 4;
            this.courseNameLabel.Text = "课程名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "结束日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "培训地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "教员：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程名称：";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.traineeCountLabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.deleteTraineeBtn);
            this.panel2.Controls.Add(this.addTraineeBtn);
            this.panel2.Controls.Add(this.traineeInfoDgView);
            this.panel2.Location = new System.Drawing.Point(12, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 227);
            this.panel2.TabIndex = 1;
            // 
            // traineeCountLabel
            // 
            this.traineeCountLabel.AutoSize = true;
            this.traineeCountLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.traineeCountLabel.ForeColor = System.Drawing.Color.Red;
            this.traineeCountLabel.Location = new System.Drawing.Point(506, 19);
            this.traineeCountLabel.Name = "traineeCountLabel";
            this.traineeCountLabel.Size = new System.Drawing.Size(17, 16);
            this.traineeCountLabel.TabIndex = 4;
            this.traineeCountLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "该课程学员总人数为：";
            // 
            // deleteTraineeBtn
            // 
            this.deleteTraineeBtn.Location = new System.Drawing.Point(115, 18);
            this.deleteTraineeBtn.Name = "deleteTraineeBtn";
            this.deleteTraineeBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteTraineeBtn.TabIndex = 2;
            this.deleteTraineeBtn.Text = "删除学员";
            this.deleteTraineeBtn.UseVisualStyleBackColor = true;
            this.deleteTraineeBtn.Click += new System.EventHandler(this.deleteTraineeBtn_Click);
            // 
            // addTraineeBtn
            // 
            this.addTraineeBtn.Location = new System.Drawing.Point(15, 18);
            this.addTraineeBtn.Name = "addTraineeBtn";
            this.addTraineeBtn.Size = new System.Drawing.Size(75, 23);
            this.addTraineeBtn.TabIndex = 1;
            this.addTraineeBtn.Text = "添加学员";
            this.addTraineeBtn.UseVisualStyleBackColor = true;
            this.addTraineeBtn.Click += new System.EventHandler(this.addTraineeBtn_Click);
            // 
            // traineeInfoDgView
            // 
            this.traineeInfoDgView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.traineeInfoDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traineeInfoDgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.gender,
            this.age,
            this.score});
            this.traineeInfoDgView.Location = new System.Drawing.Point(13, 47);
            this.traineeInfoDgView.Name = "traineeInfoDgView";
            this.traineeInfoDgView.RowTemplate.Height = 23;
            this.traineeInfoDgView.Size = new System.Drawing.Size(671, 177);
            this.traineeInfoDgView.TabIndex = 0;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "性别";
            this.gender.Name = "gender";
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "年龄";
            this.age.Name = "age";
            // 
            // score
            // 
            this.score.DataPropertyName = "score";
            this.score.HeaderText = "分数";
            this.score.Name = "score";
            // 
            // CourseDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(565, 360);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CourseDetailForm";
            this.Text = "课程详情";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeInfoDgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label beginDateLabel;
        private System.Windows.Forms.Label istNameLabel;
        private System.Windows.Forms.Label addrLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label traineeCountLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteTraineeBtn;
        private System.Windows.Forms.Button addTraineeBtn;
        private System.Windows.Forms.DataGridView traineeInfoDgView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
    }
}