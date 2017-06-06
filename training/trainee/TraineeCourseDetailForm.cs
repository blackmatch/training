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
    public partial class TraineeCourseDetailForm : Form
    {
        public TraineeCourseDetailForm()
        {
            InitializeComponent();
        }

        private string traineeId;
        private string courseId;
        private string courseName;
        public TraineeCourseDetailForm(string tId, string cId, string cName)
        {
            InitializeComponent();
            this.traineeId = tId;
            this.courseId = cId;
            this.courseName = cName;
            commentsDgView.AutoGenerateColumns = false;
            refreshScoreData();
            refreshCommentsData();
        }

        private void refreshScoreData()
        {
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select c.name,s.score,s.evaluation from score s inner join courses c on s.course_id=c.id where s.course_id=" 
                + this.courseId + " and s.trainee_id=" + this.traineeId;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "score");
            int rows = ds.Tables["score"].Rows.Count;
            if (rows > 0)
            {
                courseNameLabel.Text = ds.Tables["score"].Rows[0]["name"].ToString();
                scoreLabel.Text = ds.Tables["score"].Rows[0]["score"].ToString();
                evaluationLabel.Text = ds.Tables["score"].Rows[0]["evaluation"].ToString();
            }
            else
            {
                courseNameLabel.Text = this.courseName;
            }
        }

        private void refreshCommentsData()
        {
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select content,createdAt from comments where trainee_id="
                + this.traineeId + " and course_id=" + this.courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "comments");
            commentsDgView.DataSource = ds.Tables["comments"];
            con.Close();
        }

        private void refreshCommentsBtn_Click(object sender, EventArgs e)
        {
            refreshCommentsData();//刷新评论数据
        }
    }
}
