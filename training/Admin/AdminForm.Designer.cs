namespace training.Admin
{
    partial class AdminForm
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
            this.courseTab = new System.Windows.Forms.TabControl();
            this.traineeContainer = new System.Windows.Forms.TabPage();
            this.editTraineeInfoBtn = new System.Windows.Forms.Button();
            this.resetTraineePwd = new System.Windows.Forms.Button();
            this.deleteTraineeBtn = new System.Windows.Forms.Button();
            this.refreshTraineeBtn = new System.Windows.Forms.Button();
            this.addTraineeBtn = new System.Windows.Forms.Button();
            this.traineeDgView = new System.Windows.Forms.DataGridView();
            this.istContainer = new System.Windows.Forms.TabPage();
            this.refreshIstBtn = new System.Windows.Forms.Button();
            this.deleteIstBtn = new System.Windows.Forms.Button();
            this.resetIstPwdBtn = new System.Windows.Forms.Button();
            this.editIstBtn = new System.Windows.Forms.Button();
            this.addIstBtn = new System.Windows.Forms.Button();
            this.istDgView = new System.Windows.Forms.DataGridView();
            this.courseContainer = new System.Windows.Forms.TabPage();
            this.courseDetailBtn = new System.Windows.Forms.Button();
            this.refreshCourseBtn = new System.Windows.Forms.Button();
            this.deleteCourseBtn = new System.Windows.Forms.Button();
            this.editCourseBtn = new System.Windows.Forms.Button();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.courseDgView = new System.Windows.Forms.DataGridView();
            this.commentPage = new System.Windows.Forms.TabPage();
            this.refreshCommentBtn = new System.Windows.Forms.Button();
            this.deleteCommentBtn = new System.Windows.Forms.Button();
            this.commentDgView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.courseTab.SuspendLayout();
            this.traineeContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeDgView)).BeginInit();
            this.istContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.istDgView)).BeginInit();
            this.courseContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseDgView)).BeginInit();
            this.commentPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentDgView)).BeginInit();
            this.SuspendLayout();
            // 
            // courseTab
            // 
            this.courseTab.Controls.Add(this.traineeContainer);
            this.courseTab.Controls.Add(this.istContainer);
            this.courseTab.Controls.Add(this.courseContainer);
            this.courseTab.Controls.Add(this.commentPage);
            this.courseTab.Location = new System.Drawing.Point(12, 12);
            this.courseTab.Name = "courseTab";
            this.courseTab.SelectedIndex = 0;
            this.courseTab.Size = new System.Drawing.Size(736, 320);
            this.courseTab.TabIndex = 0;
            this.courseTab.Tag = "";
            // 
            // traineeContainer
            // 
            this.traineeContainer.Controls.Add(this.editTraineeInfoBtn);
            this.traineeContainer.Controls.Add(this.resetTraineePwd);
            this.traineeContainer.Controls.Add(this.deleteTraineeBtn);
            this.traineeContainer.Controls.Add(this.refreshTraineeBtn);
            this.traineeContainer.Controls.Add(this.addTraineeBtn);
            this.traineeContainer.Controls.Add(this.traineeDgView);
            this.traineeContainer.Location = new System.Drawing.Point(4, 22);
            this.traineeContainer.Name = "traineeContainer";
            this.traineeContainer.Padding = new System.Windows.Forms.Padding(3);
            this.traineeContainer.Size = new System.Drawing.Size(728, 294);
            this.traineeContainer.TabIndex = 0;
            this.traineeContainer.Text = "学员管理";
            this.traineeContainer.UseVisualStyleBackColor = true;
            this.traineeContainer.Enter += new System.EventHandler(this.traineeContainer_Enter);
            // 
            // editTraineeInfoBtn
            // 
            this.editTraineeInfoBtn.Location = new System.Drawing.Point(106, 22);
            this.editTraineeInfoBtn.Name = "editTraineeInfoBtn";
            this.editTraineeInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.editTraineeInfoBtn.TabIndex = 5;
            this.editTraineeInfoBtn.Text = "修改信息";
            this.editTraineeInfoBtn.UseVisualStyleBackColor = true;
            this.editTraineeInfoBtn.Click += new System.EventHandler(this.editTraineeInfoBtn_Click);
            // 
            // resetTraineePwd
            // 
            this.resetTraineePwd.Location = new System.Drawing.Point(204, 22);
            this.resetTraineePwd.Name = "resetTraineePwd";
            this.resetTraineePwd.Size = new System.Drawing.Size(75, 23);
            this.resetTraineePwd.TabIndex = 4;
            this.resetTraineePwd.Text = "重置密码";
            this.resetTraineePwd.UseVisualStyleBackColor = true;
            this.resetTraineePwd.Click += new System.EventHandler(this.resetTraineePwd_Click);
            // 
            // deleteTraineeBtn
            // 
            this.deleteTraineeBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteTraineeBtn.Location = new System.Drawing.Point(294, 22);
            this.deleteTraineeBtn.Name = "deleteTraineeBtn";
            this.deleteTraineeBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteTraineeBtn.TabIndex = 3;
            this.deleteTraineeBtn.Text = "删除";
            this.deleteTraineeBtn.UseVisualStyleBackColor = true;
            this.deleteTraineeBtn.Click += new System.EventHandler(this.deleteTraineeBtn_Click);
            // 
            // refreshTraineeBtn
            // 
            this.refreshTraineeBtn.Location = new System.Drawing.Point(385, 22);
            this.refreshTraineeBtn.Name = "refreshTraineeBtn";
            this.refreshTraineeBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshTraineeBtn.TabIndex = 2;
            this.refreshTraineeBtn.Text = "刷新";
            this.refreshTraineeBtn.UseVisualStyleBackColor = true;
            this.refreshTraineeBtn.Click += new System.EventHandler(this.refreshTraineeBtn_Click);
            // 
            // addTraineeBtn
            // 
            this.addTraineeBtn.Location = new System.Drawing.Point(6, 22);
            this.addTraineeBtn.Name = "addTraineeBtn";
            this.addTraineeBtn.Size = new System.Drawing.Size(75, 23);
            this.addTraineeBtn.TabIndex = 1;
            this.addTraineeBtn.Text = "新增";
            this.addTraineeBtn.UseVisualStyleBackColor = true;
            this.addTraineeBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // traineeDgView
            // 
            this.traineeDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traineeDgView.Location = new System.Drawing.Point(6, 66);
            this.traineeDgView.MultiSelect = false;
            this.traineeDgView.Name = "traineeDgView";
            this.traineeDgView.ReadOnly = true;
            this.traineeDgView.RowTemplate.Height = 23;
            this.traineeDgView.Size = new System.Drawing.Size(716, 222);
            this.traineeDgView.TabIndex = 0;
            // 
            // istContainer
            // 
            this.istContainer.Controls.Add(this.refreshIstBtn);
            this.istContainer.Controls.Add(this.deleteIstBtn);
            this.istContainer.Controls.Add(this.resetIstPwdBtn);
            this.istContainer.Controls.Add(this.editIstBtn);
            this.istContainer.Controls.Add(this.addIstBtn);
            this.istContainer.Controls.Add(this.istDgView);
            this.istContainer.Location = new System.Drawing.Point(4, 22);
            this.istContainer.Name = "istContainer";
            this.istContainer.Padding = new System.Windows.Forms.Padding(3);
            this.istContainer.Size = new System.Drawing.Size(728, 294);
            this.istContainer.TabIndex = 1;
            this.istContainer.Text = "教员管理";
            this.istContainer.UseVisualStyleBackColor = true;
            this.istContainer.Enter += new System.EventHandler(this.istContainer_Enter);
            // 
            // refreshIstBtn
            // 
            this.refreshIstBtn.Location = new System.Drawing.Point(409, 32);
            this.refreshIstBtn.Name = "refreshIstBtn";
            this.refreshIstBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshIstBtn.TabIndex = 5;
            this.refreshIstBtn.Text = "刷新";
            this.refreshIstBtn.UseVisualStyleBackColor = true;
            this.refreshIstBtn.Click += new System.EventHandler(this.refreshIstBtn_Click);
            // 
            // deleteIstBtn
            // 
            this.deleteIstBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteIstBtn.Location = new System.Drawing.Point(305, 32);
            this.deleteIstBtn.Name = "deleteIstBtn";
            this.deleteIstBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteIstBtn.TabIndex = 4;
            this.deleteIstBtn.Text = "删除";
            this.deleteIstBtn.UseVisualStyleBackColor = true;
            this.deleteIstBtn.Click += new System.EventHandler(this.deleteIstBtn_Click);
            // 
            // resetIstPwdBtn
            // 
            this.resetIstPwdBtn.Location = new System.Drawing.Point(207, 32);
            this.resetIstPwdBtn.Name = "resetIstPwdBtn";
            this.resetIstPwdBtn.Size = new System.Drawing.Size(75, 23);
            this.resetIstPwdBtn.TabIndex = 3;
            this.resetIstPwdBtn.Text = "重置密码";
            this.resetIstPwdBtn.UseVisualStyleBackColor = true;
            this.resetIstPwdBtn.Click += new System.EventHandler(this.resetIstPwdBtn_Click);
            // 
            // editIstBtn
            // 
            this.editIstBtn.Location = new System.Drawing.Point(112, 32);
            this.editIstBtn.Name = "editIstBtn";
            this.editIstBtn.Size = new System.Drawing.Size(75, 23);
            this.editIstBtn.TabIndex = 2;
            this.editIstBtn.Text = "修改信息";
            this.editIstBtn.UseVisualStyleBackColor = true;
            this.editIstBtn.Click += new System.EventHandler(this.editIstBtn_Click);
            // 
            // addIstBtn
            // 
            this.addIstBtn.Location = new System.Drawing.Point(6, 32);
            this.addIstBtn.Name = "addIstBtn";
            this.addIstBtn.Size = new System.Drawing.Size(75, 23);
            this.addIstBtn.TabIndex = 1;
            this.addIstBtn.Text = "新增";
            this.addIstBtn.UseVisualStyleBackColor = true;
            this.addIstBtn.Click += new System.EventHandler(this.addIstBtn_Click);
            // 
            // istDgView
            // 
            this.istDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.istDgView.Location = new System.Drawing.Point(6, 74);
            this.istDgView.MultiSelect = false;
            this.istDgView.Name = "istDgView";
            this.istDgView.RowTemplate.Height = 23;
            this.istDgView.Size = new System.Drawing.Size(716, 214);
            this.istDgView.TabIndex = 0;
            // 
            // courseContainer
            // 
            this.courseContainer.Controls.Add(this.courseDetailBtn);
            this.courseContainer.Controls.Add(this.refreshCourseBtn);
            this.courseContainer.Controls.Add(this.deleteCourseBtn);
            this.courseContainer.Controls.Add(this.editCourseBtn);
            this.courseContainer.Controls.Add(this.addCourseBtn);
            this.courseContainer.Controls.Add(this.courseDgView);
            this.courseContainer.Location = new System.Drawing.Point(4, 22);
            this.courseContainer.Name = "courseContainer";
            this.courseContainer.Padding = new System.Windows.Forms.Padding(3);
            this.courseContainer.Size = new System.Drawing.Size(728, 294);
            this.courseContainer.TabIndex = 2;
            this.courseContainer.Text = "课程管理";
            this.courseContainer.UseVisualStyleBackColor = true;
            this.courseContainer.Enter += new System.EventHandler(this.courseContainer_Enter);
            // 
            // courseDetailBtn
            // 
            this.courseDetailBtn.Location = new System.Drawing.Point(222, 29);
            this.courseDetailBtn.Name = "courseDetailBtn";
            this.courseDetailBtn.Size = new System.Drawing.Size(75, 23);
            this.courseDetailBtn.TabIndex = 5;
            this.courseDetailBtn.Text = "查看详情";
            this.courseDetailBtn.UseVisualStyleBackColor = true;
            this.courseDetailBtn.Click += new System.EventHandler(this.courseDetailBtn_Click);
            // 
            // refreshCourseBtn
            // 
            this.refreshCourseBtn.Location = new System.Drawing.Point(430, 29);
            this.refreshCourseBtn.Name = "refreshCourseBtn";
            this.refreshCourseBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshCourseBtn.TabIndex = 4;
            this.refreshCourseBtn.Text = "刷新";
            this.refreshCourseBtn.UseVisualStyleBackColor = true;
            this.refreshCourseBtn.Click += new System.EventHandler(this.refreshCourseBtn_Click);
            // 
            // deleteCourseBtn
            // 
            this.deleteCourseBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteCourseBtn.Location = new System.Drawing.Point(324, 29);
            this.deleteCourseBtn.Name = "deleteCourseBtn";
            this.deleteCourseBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteCourseBtn.TabIndex = 3;
            this.deleteCourseBtn.Text = "删除";
            this.deleteCourseBtn.UseVisualStyleBackColor = true;
            this.deleteCourseBtn.Click += new System.EventHandler(this.deleteCourseBtn_Click);
            // 
            // editCourseBtn
            // 
            this.editCourseBtn.Location = new System.Drawing.Point(119, 29);
            this.editCourseBtn.Name = "editCourseBtn";
            this.editCourseBtn.Size = new System.Drawing.Size(75, 23);
            this.editCourseBtn.TabIndex = 2;
            this.editCourseBtn.Text = "修改";
            this.editCourseBtn.UseVisualStyleBackColor = true;
            this.editCourseBtn.Click += new System.EventHandler(this.editCourseBtn_Click);
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.Location = new System.Drawing.Point(6, 29);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(75, 23);
            this.addCourseBtn.TabIndex = 1;
            this.addCourseBtn.Text = "新增";
            this.addCourseBtn.UseVisualStyleBackColor = true;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
            // 
            // courseDgView
            // 
            this.courseDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDgView.Location = new System.Drawing.Point(6, 73);
            this.courseDgView.MultiSelect = false;
            this.courseDgView.Name = "courseDgView";
            this.courseDgView.RowTemplate.Height = 23;
            this.courseDgView.Size = new System.Drawing.Size(716, 215);
            this.courseDgView.TabIndex = 0;
            // 
            // commentPage
            // 
            this.commentPage.Controls.Add(this.refreshCommentBtn);
            this.commentPage.Controls.Add(this.deleteCommentBtn);
            this.commentPage.Controls.Add(this.commentDgView);
            this.commentPage.Controls.Add(this.courseComboBox);
            this.commentPage.Location = new System.Drawing.Point(4, 22);
            this.commentPage.Name = "commentPage";
            this.commentPage.Padding = new System.Windows.Forms.Padding(3);
            this.commentPage.Size = new System.Drawing.Size(728, 294);
            this.commentPage.TabIndex = 3;
            this.commentPage.Text = "评论管理";
            this.commentPage.UseVisualStyleBackColor = true;
            this.commentPage.Enter += new System.EventHandler(this.commentPage_Enter);
            // 
            // refreshCommentBtn
            // 
            this.refreshCommentBtn.Location = new System.Drawing.Point(409, 28);
            this.refreshCommentBtn.Name = "refreshCommentBtn";
            this.refreshCommentBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshCommentBtn.TabIndex = 3;
            this.refreshCommentBtn.Text = "刷新";
            this.refreshCommentBtn.UseVisualStyleBackColor = true;
            this.refreshCommentBtn.Click += new System.EventHandler(this.refreshCommentBtn_Click);
            // 
            // deleteCommentBtn
            // 
            this.deleteCommentBtn.ForeColor = System.Drawing.Color.Red;
            this.deleteCommentBtn.Location = new System.Drawing.Point(296, 28);
            this.deleteCommentBtn.Name = "deleteCommentBtn";
            this.deleteCommentBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteCommentBtn.TabIndex = 2;
            this.deleteCommentBtn.Text = "删除";
            this.deleteCommentBtn.UseVisualStyleBackColor = true;
            this.deleteCommentBtn.Click += new System.EventHandler(this.deleteCommentBtn_Click);
            // 
            // commentDgView
            // 
            this.commentDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentDgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.content,
            this.createdAt});
            this.commentDgView.Location = new System.Drawing.Point(6, 73);
            this.commentDgView.MultiSelect = false;
            this.commentDgView.Name = "commentDgView";
            this.commentDgView.RowTemplate.Height = 23;
            this.commentDgView.Size = new System.Drawing.Size(716, 215);
            this.commentDgView.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // content
            // 
            this.content.DataPropertyName = "content";
            this.content.HeaderText = "内容";
            this.content.Name = "content";
            this.content.ReadOnly = true;
            // 
            // createdAt
            // 
            this.createdAt.DataPropertyName = "createdAt";
            this.createdAt.HeaderText = "时间";
            this.createdAt.Name = "createdAt";
            this.createdAt.ReadOnly = true;
            // 
            // courseComboBox
            // 
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(6, 31);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(245, 20);
            this.courseComboBox.TabIndex = 0;
            this.courseComboBox.SelectedIndexChanged += new System.EventHandler(this.courseComboBox_SelectedIndexChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 337);
            this.Controls.Add(this.courseTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminForm";
            this.Text = "管理员";
            this.courseTab.ResumeLayout(false);
            this.traineeContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.traineeDgView)).EndInit();
            this.istContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.istDgView)).EndInit();
            this.courseContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseDgView)).EndInit();
            this.commentPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commentDgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl courseTab;
        private System.Windows.Forms.TabPage traineeContainer;
        private System.Windows.Forms.DataGridView traineeDgView;
        private System.Windows.Forms.TabPage istContainer;
        private System.Windows.Forms.TabPage courseContainer;
        private System.Windows.Forms.Button addTraineeBtn;
        private System.Windows.Forms.Button addIstBtn;
        private System.Windows.Forms.DataGridView istDgView;
        private System.Windows.Forms.DataGridView courseDgView;
        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.Button editTraineeInfoBtn;
        private System.Windows.Forms.Button resetTraineePwd;
        private System.Windows.Forms.Button deleteTraineeBtn;
        private System.Windows.Forms.Button refreshTraineeBtn;
        private System.Windows.Forms.Button refreshIstBtn;
        private System.Windows.Forms.Button deleteIstBtn;
        private System.Windows.Forms.Button resetIstPwdBtn;
        private System.Windows.Forms.Button editIstBtn;
        private System.Windows.Forms.Button refreshCourseBtn;
        private System.Windows.Forms.Button deleteCourseBtn;
        private System.Windows.Forms.Button editCourseBtn;
        private System.Windows.Forms.Button courseDetailBtn;
        private System.Windows.Forms.TabPage commentPage;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.DataGridView commentDgView;
        private System.Windows.Forms.Button deleteCommentBtn;
        private System.Windows.Forms.Button refreshCommentBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
    }
}