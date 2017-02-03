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
            this.addTraineeBtn = new System.Windows.Forms.Button();
            this.traineeDgView = new System.Windows.Forms.DataGridView();
            this.istContainer = new System.Windows.Forms.TabPage();
            this.courseContainer = new System.Windows.Forms.TabPage();
            this.istDgView = new System.Windows.Forms.DataGridView();
            this.addIstBtn = new System.Windows.Forms.Button();
            this.courseDgView = new System.Windows.Forms.DataGridView();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.courseTab.SuspendLayout();
            this.traineeContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traineeDgView)).BeginInit();
            this.istContainer.SuspendLayout();
            this.courseContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.istDgView)).BeginInit();
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
            this.traineeDgView.Name = "traineeDgView";
            this.traineeDgView.RowTemplate.Height = 23;
            this.traineeDgView.Size = new System.Drawing.Size(716, 181);
            this.traineeDgView.TabIndex = 0;
            // 
            // istContainer
            // 
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
            // courseContainer
            // 
            this.courseContainer.Controls.Add(this.addCourseBtn);
            this.courseContainer.Controls.Add(this.courseDgView);
            this.courseContainer.Location = new System.Drawing.Point(4, 22);
            this.courseContainer.Name = "courseContainer";
            this.courseContainer.Padding = new System.Windows.Forms.Padding(3);
            this.courseContainer.Size = new System.Drawing.Size(728, 253);
            this.courseContainer.TabIndex = 2;
            this.courseContainer.Text = "课程管理";
            this.courseContainer.UseVisualStyleBackColor = true;
            // 
            // istDgView
            // 
            this.istDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.istDgView.Location = new System.Drawing.Point(6, 74);
            this.istDgView.Name = "istDgView";
            this.istDgView.RowTemplate.Height = 23;
            this.istDgView.Size = new System.Drawing.Size(716, 173);
            this.istDgView.TabIndex = 0;
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
            // courseDgView
            // 
            this.courseDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDgView.Location = new System.Drawing.Point(6, 73);
            this.courseDgView.Name = "courseDgView";
            this.courseDgView.RowTemplate.Height = 23;
            this.courseDgView.Size = new System.Drawing.Size(716, 174);
            this.courseDgView.TabIndex = 0;
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 337);
            this.Controls.Add(this.courseTab);
            this.Name = "AdminForm";
            this.Text = "管理员";
            this.courseTab.ResumeLayout(false);
            this.traineeContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.traineeDgView)).EndInit();
            this.istContainer.ResumeLayout(false);
            this.courseContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.istDgView)).EndInit();
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
    }
}