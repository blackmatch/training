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
    public partial class IstCourseDetailForm : Form
    {
        public IstCourseDetailForm()
        {
            InitializeComponent();
        }

        private string courseId;
        private DataSet traineeDataSet;
        public IstCourseDetailForm(string cId)
        {
            InitializeComponent();
            commentsDgView.AutoGenerateColumns = false;
            this.courseId = cId;
            refreshTraineeInfo();
            refreshCommentsData();
        }

        private void refreshTraineeInfo()
        {
            string sql = "select t.id,t.name,t.jobNumber,t.gender,t.age,s.score,s.evaluation from enrollment e left join trainees t on e.trainee_id=t.id left join score s on (e.course_id=s.course_id and e.trainee_id=s.trainee_id) where e.course_id="
                + this.courseId;
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "enrollment");
            int rows = ds.Tables["enrollment"].Rows.Count;
            if (rows > 0)
            {
                traineeInfoDgView.DataSource = ds.Tables["enrollment"];
                this.traineeDataSet = ds;
            }
            else
            {

            }

            con.Close();
        }

        private void evaluateBtn_Click(object sender, EventArgs e)
        {
            if (traineeInfoDgView.DataSource == null || (traineeInfoDgView.DataSource as DataTable).Rows.Count == 0)
            {
                MessageBox.Show("请选择学员");
                return;
            }
            int idx = traineeInfoDgView.CurrentRow.Index;
            string tId = this.traineeDataSet.Tables["enrollment"].Rows[idx]["id"].ToString();
            string name = this.traineeDataSet.Tables["enrollment"].Rows[idx]["name"].ToString();
            string jobNum = this.traineeDataSet.Tables["enrollment"].Rows[idx]["jobNumber"].ToString();
            ScoreTraineeForm scoreFm = new ScoreTraineeForm(tId, name, jobNum, this.courseId);
            scoreFm.ShowDialog();
            refreshTraineeInfo();
        }

        private void traineeRefreshBtn_Click(object sender, EventArgs e)
        {
            refreshTraineeInfo();
        }

        private void refreshCommentBtn_Click(object sender, EventArgs e)
        {
            refreshCommentsData();
        }

        private void refreshCommentsData()
        {
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select content,createdAt from comments where course_id=" + this.courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "comments");
            commentsDgView.DataSource = ds.Tables["comments"];
            con.Close();
        }
    }
}
