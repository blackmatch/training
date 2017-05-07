using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//custom
using System.Data.SqlClient;

namespace training.trainee
{
    public partial class AddCourseCommentForm : Form
    {
        public AddCourseCommentForm()
        {
            InitializeComponent();
        }

        private string traineeId;
        private string courseId;
        public AddCourseCommentForm(string tId, string cId)
        {
            InitializeComponent();
            this.traineeId = tId;
            this.courseId = cId;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection sqlCon = new SqlConnection(conStr);
            string sql = "insert into comments(course_id,trainee_id,content) values("
                + this.courseId + "," + this.traineeId + ",'" + contentRichTextBox.Text + "')";
            SqlCommand sqlCmd = new SqlCommand(sql, sqlCon);

            try
            {
                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("新增评论成功！");
                sqlCon.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                MessageBox.Show("新增评论失败" + sql);
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }
    }
}
