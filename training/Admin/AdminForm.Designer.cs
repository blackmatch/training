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
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.courseDgView = new System.Windows.Forms.DataGridView();
            this.courseTab.SuspendLayout();
            this.traineeContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeDgView)).BeginInit();
            this.istContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.istDgView)).BeginInit();
            this.courseContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseDgView)).BeginInit();
            this.SuspendLayout();
            // 
            // courseTab
            // 
            this.courseTab.Controls.Add(this.traineeContainer);
            this.courseTab.Controls.Add(this.istContainer);
            this.courseTab.Controls.Add(this.courseContainer);
            this.courseTab.Location = new System.Drawing.Point(12, 12);
            this.courseTab.Name = "courseTab";
            this.courseTab.SelectedIndex = 0;
            this.courseTab.Size = new System.Drawing.Size(736, 279);
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
            this.traineeContainer.Size = new System.Drawing.Size(728, 253);
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
            this.traineeDgView.Size = new System.Drawing.Size(716, 181);
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
            this.istContainer.Size = new System.Drawing.Size(728, 253);
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
            this.istDgView.Size = new System.Drawing.Size(716, 173);
            this.istDgView.TabIndex = 0;
            // 
            // courseContainer
            // 
            this.courseContainer.Controls.Add(this.button7);
            this.courseContainer.Controls.Add(this.button6);
            this.courseContainer.Controls.Add(this.button5);
            this.courseContainer.Controls.Add(this.addCourseBtn);
            this.courseContainer.Controls.Add(this.courseDgView);
            this.courseContainer.Location = new System.Drawing.Point(4, 22);
            this.courseContainer.Name = "courseContainer";
            this.courseContainer.Padding = new System.Windows.Forms.Padding(3);
            this.courseContainer.Size = new System.Drawing.Size(728, 253);
            this.courseContainer.TabIndex = 2;
            this.courseContainer.Text = "课程管理";
            this.courseContainer.UseVisualStyleBackColor = true;
            this.courseContainer.Enter += new System.EventHandler(this.courseContainer_Enter);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(333, 29);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "刷新";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(226, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "删除";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(119, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "修改";
            this.button5.UseVisualStyleBackColor = true;
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
            this.courseDgView.Size = new System.Drawing.Size(716, 174);
            this.courseDgView.TabIndex = 0;
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
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}