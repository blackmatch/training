namespace training
{
    partial class EntryForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.adminBtn = new System.Windows.Forms.Button();
            this.istBtn = new System.Windows.Forms.Button();
            this.traineeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(136, 183);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(75, 23);
            this.adminBtn.TabIndex = 0;
            this.adminBtn.Text = "管理员入口";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // istBtn
            // 
            this.istBtn.Location = new System.Drawing.Point(317, 183);
            this.istBtn.Name = "istBtn";
            this.istBtn.Size = new System.Drawing.Size(75, 23);
            this.istBtn.TabIndex = 1;
            this.istBtn.Text = "教员入口";
            this.istBtn.UseVisualStyleBackColor = true;
            this.istBtn.Click += new System.EventHandler(this.istBtn_Click);
            // 
            // traineeBtn
            // 
            this.traineeBtn.Location = new System.Drawing.Point(498, 183);
            this.traineeBtn.Name = "traineeBtn";
            this.traineeBtn.Size = new System.Drawing.Size(75, 23);
            this.traineeBtn.TabIndex = 2;
            this.traineeBtn.Text = "学员入口";
            this.traineeBtn.UseVisualStyleBackColor = true;
            this.traineeBtn.Click += new System.EventHandler(this.traineeBtn_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 409);
            this.Controls.Add(this.traineeBtn);
            this.Controls.Add(this.istBtn);
            this.Controls.Add(this.adminBtn);
            this.Name = "EntryForm";
            this.Text = "欢迎使用上海元达网络培训管理系统";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button istBtn;
        private System.Windows.Forms.Button traineeBtn;
    }
}

