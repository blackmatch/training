namespace training.instructor
{
    partial class IstCourseDetailForm
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
            this.traineePage = new System.Windows.Forms.TabPage();
            this.traineeRefreshBtn = new System.Windows.Forms.Button();
            this.evaluateBtn = new System.Windows.Forms.Button();
            this.traineeInfoDgView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationPage = new System.Windows.Forms.TabPage();
            this.refreshCommentBtn = new System.Windows.Forms.Button();
            this.commentsDgView = new System.Windows.Forms.DataGridView();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.traineePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeInfoDgView)).BeginInit();
            this.evaluationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsDgView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.traineePage);
            this.tabControl1.Controls.Add(this.evaluationPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 343);
            this.tabControl1.TabIndex = 0;
            // 
            // traineePage
            // 
            this.traineePage.BackColor = System.Drawing.Color.SkyBlue;
            this.traineePage.Controls.Add(this.traineeRefreshBtn);
            this.traineePage.Controls.Add(this.evaluateBtn);
            this.traineePage.Controls.Add(this.traineeInfoDgView);
            this.traineePage.Location = new System.Drawing.Point(4, 22);
            this.traineePage.Name = "traineePage";
            this.traineePage.Padding = new System.Windows.Forms.Padding(3);
            this.traineePage.Size = new System.Drawing.Size(733, 317);
            this.traineePage.TabIndex = 0;
            this.traineePage.Text = "学员信息";
            // 
            // traineeRefreshBtn
            // 
            this.traineeRefreshBtn.Location = new System.Drawing.Point(102, 17);
            this.traineeRefreshBtn.Name = "traineeRefreshBtn";
            this.traineeRefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.traineeRefreshBtn.TabIndex = 2;
            this.traineeRefreshBtn.Text = "刷新";
            this.traineeRefreshBtn.UseVisualStyleBackColor = true;
            this.traineeRefreshBtn.Click += new System.EventHandler(this.traineeRefreshBtn_Click);
            // 
            // evaluateBtn
            // 
            this.evaluateBtn.Location = new System.Drawing.Point(6, 17);
            this.evaluateBtn.Name = "evaluateBtn";
            this.evaluateBtn.Size = new System.Drawing.Size(75, 23);
            this.evaluateBtn.TabIndex = 1;
            this.evaluateBtn.Text = "打分";
            this.evaluateBtn.UseVisualStyleBackColor = true;
            this.evaluateBtn.Click += new System.EventHandler(this.evaluateBtn_Click);
            // 
            // traineeInfoDgView
            // 
            this.traineeInfoDgView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.traineeInfoDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traineeInfoDgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.jobNumber,
            this.gender,
            this.age,
            this.score,
            this.evaluation});
            this.traineeInfoDgView.Location = new System.Drawing.Point(6, 56);
            this.traineeInfoDgView.Name = "traineeInfoDgView";
            this.traineeInfoDgView.RowTemplate.Height = 23;
            this.traineeInfoDgView.Size = new System.Drawing.Size(721, 255);
            this.traineeInfoDgView.TabIndex = 0;
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
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "性别";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "年龄";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // score
            // 
            this.score.DataPropertyName = "score";
            this.score.HeaderText = "得分";
            this.score.Name = "score";
            this.score.ReadOnly = true;
            // 
            // evaluation
            // 
            this.evaluation.DataPropertyName = "evaluation";
            this.evaluation.HeaderText = "评语";
            this.evaluation.Name = "evaluation";
            this.evaluation.ReadOnly = true;
            // 
            // evaluationPage
            // 
            this.evaluationPage.Controls.Add(this.refreshCommentBtn);
            this.evaluationPage.Controls.Add(this.commentsDgView);
            this.evaluationPage.Location = new System.Drawing.Point(4, 22);
            this.evaluationPage.Name = "evaluationPage";
            this.evaluationPage.Padding = new System.Windows.Forms.Padding(3);
            this.evaluationPage.Size = new System.Drawing.Size(733, 317);
            this.evaluationPage.TabIndex = 1;
            this.evaluationPage.Text = "评论信息";
            this.evaluationPage.UseVisualStyleBackColor = true;
            // 
            // refreshCommentBtn
            // 
            this.refreshCommentBtn.Location = new System.Drawing.Point(6, 25);
            this.refreshCommentBtn.Name = "refreshCommentBtn";
            this.refreshCommentBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshCommentBtn.TabIndex = 1;
            this.refreshCommentBtn.Text = "刷新";
            this.refreshCommentBtn.UseVisualStyleBackColor = true;
            this.refreshCommentBtn.Click += new System.EventHandler(this.refreshCommentBtn_Click);
            // 
            // commentsDgView
            // 
            this.commentsDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentsDgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.content,
            this.createdAt});
            this.commentsDgView.Location = new System.Drawing.Point(6, 54);
            this.commentsDgView.Name = "commentsDgView";
            this.commentsDgView.RowTemplate.Height = 23;
            this.commentsDgView.Size = new System.Drawing.Size(721, 257);
            this.commentsDgView.TabIndex = 0;
            // 
            // content
            // 
            this.content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.content.DataPropertyName = "content";
            this.content.HeaderText = "内容";
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.Width = 54;
            // 
            // createdAt
            // 
            this.createdAt.DataPropertyName = "createdAt";
            this.createdAt.HeaderText = "时间";
            this.createdAt.Name = "createdAt";
            this.createdAt.ReadOnly = true;
            // 
            // IstCourseDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(765, 367);
            this.Controls.Add(this.tabControl1);
            this.Name = "IstCourseDetailForm";
            this.Text = "课程详情";
            this.tabControl1.ResumeLayout(false);
            this.traineePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.traineeInfoDgView)).EndInit();
            this.evaluationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commentsDgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage traineePage;
        private System.Windows.Forms.TabPage evaluationPage;
        private System.Windows.Forms.Button traineeRefreshBtn;
        private System.Windows.Forms.Button evaluateBtn;
        private System.Windows.Forms.DataGridView traineeInfoDgView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluation;
        private System.Windows.Forms.Button refreshCommentBtn;
        private System.Windows.Forms.DataGridView commentsDgView;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
    }
}