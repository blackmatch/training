using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;    //使用SqlConnection与sql server交互

namespace training.instructor
{
    public partial class ScoreTraineeForm : Form
    {
        public ScoreTraineeForm()
        {
            InitializeComponent();
        }

        private string traineeId;
        private string courseId;
        public ScoreTraineeForm(string tId, string name, string jobNumber, string cId)
        {
            InitializeComponent();
            nameLabel.Text = name;
            jobNumberLabel.Text = jobNumber;
            this.traineeId = tId;
            this.courseId = cId;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            //先查清楚有没有打分记录
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            string sql = "select * from score where course_id=" + this.courseId
                + " and trainee_id=" + this.traineeId;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "score");
            int rows = ds.Tables["score"].Rows.Count;
            if (rows > 0)
            {
                // 已存在打分记录，更新
                sql = "update score set score=" + scoreTextBox.Text + ",evaluation='"
                    + evaluationRichTextBox.Text + "' where course_id=" + this.courseId
                    + " and trainee_id=" + this.traineeId;
                SqlCommand sqlCmd = new SqlCommand(sql, con);
                try
                {
                    int r = sqlCmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("打分成功！");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("打分失败！");
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打分失败！");
                    Console.WriteLine("{0} Exception caught.", ex);
                    con.Close();
                }
            }
            else
            {
                // 还未存在打分记录，插入
                sql = "insert into score(course_id,trainee_id,score,evaluation) values(" + this.courseId
                   + "," + this.traineeId + "," + scoreTextBox.Text + ",'" + evaluationRichTextBox.Text + "')";
                SqlCommand sqlCmd = new SqlCommand(sql, con);

                try
                {
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("打分成功！");
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打分失败！");
                    Console.WriteLine("{0} Exception caught.", ex);
                }
            }

            con.Close();
        }
    }
}
