﻿namespace training.trainee
{
    partial class TraineeCourseDetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.evaluationLabel = new System.Windows.Forms.Label();
            this.commentsDgView = new System.Windows.Forms.DataGridView();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refreshCommentsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.commentsDgView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程名称：";
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.courseNameLabel.Location = new System.Drawing.Point(113, 29);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(37, 14);
            this.courseNameLabel.TabIndex = 1;
            this.courseNameLabel.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "得分：";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(114, 64);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(41, 12);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "得分：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "评语：";
            // 
            // evaluationLabel
            // 
            this.evaluationLabel.AutoSize = true;
            this.evaluationLabel.Location = new System.Drawing.Point(114, 100);
            this.evaluationLabel.Name = "evaluationLabel";
            this.evaluationLabel.Size = new System.Drawing.Size(29, 12);
            this.evaluationLabel.TabIndex = 5;
            this.evaluationLabel.Text = "评语";
            // 
            // commentsDgView
            // 
            this.commentsDgView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.commentsDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentsDgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.content,
            this.createdAt});
            this.commentsDgView.Location = new System.Drawing.Point(33, 164);
            this.commentsDgView.Name = "commentsDgView";
            this.commentsDgView.RowTemplate.Height = 23;
            this.commentsDgView.Size = new System.Drawing.Size(532, 175);
            this.commentsDgView.TabIndex = 6;
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
            // refreshCommentsBtn
            // 
            this.refreshCommentsBtn.Location = new System.Drawing.Point(33, 135);
            this.refreshCommentsBtn.Name = "refreshCommentsBtn";
            this.refreshCommentsBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshCommentsBtn.TabIndex = 8;
            this.refreshCommentsBtn.Text = "刷新";
            this.refreshCommentsBtn.UseVisualStyleBackColor = true;
            this.refreshCommentsBtn.Click += new System.EventHandler(this.refreshCommentsBtn_Click);
            // 
            // TraineeCourseDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(577, 351);
            this.Controls.Add(this.refreshCommentsBtn);
            this.Controls.Add(this.commentsDgView);
            this.Controls.Add(this.evaluationLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "TraineeCourseDetailForm";
            this.Text = "课程详情";
            ((System.ComponentModel.ISupportInitialize)(this.commentsDgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label evaluationLabel;
        private System.Windows.Forms.DataGridView commentsDgView;
        private System.Windows.Forms.Button refreshCommentsBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
    }
}