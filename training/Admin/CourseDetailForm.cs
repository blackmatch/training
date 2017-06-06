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

namespace training.Admin
{
    public partial class CourseDetailForm : Form
    {
        public CourseDetailForm()
        {
            InitializeComponent();
        }

        private string courseId;
        private DataSet enrollments;
        public CourseDetailForm(string cId)
        {
            InitializeComponent();
            traineeInfoDgView.AutoGenerateColumns = false;
            this.courseId = cId;
            refreshCourseBasicInfo();
            refreshCourseTraineeInfo();
        }

        // 获取课程基本信息
        private void refreshCourseBasicInfo()
        {
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select c.id as 'id',c.name as '课程名称',c.beginDate as '开始日期',c.endDate as '结束日期',c.addr as '培训地址',c.remark as '备注',i.name as '教员' from courses c inner join instructors i  on c.ist_id=i.id where c.id=" + this.courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "courses");
            int rowsCount = ds.Tables["courses"].Rows.Count;
            if (rowsCount > 0)
            {
                courseNameLabel.Text = ds.Tables["courses"].Rows[0]["课程名称"].ToString();
                istNameLabel.Text = ds.Tables["courses"].Rows[0]["教员"].ToString();
                addrLabel.Text = ds.Tables["courses"].Rows[0]["培训地址"].ToString();
                beginDateLabel.Text = ds.Tables["courses"].Rows[0]["开始日期"].ToString();
                endDateLabel.Text = ds.Tables["courses"].Rows[0]["结束日期"].ToString();
            }

            con.Close();
        }

        // 获取课程学员信息
        private void refreshCourseTraineeInfo()
        {
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select e.id,t.name,t.gender,t.age,s.score from enrollment e left join trainees t on t.id=e.trainee_id left join score s on (e.course_id=s.course_id and e.trainee_id=s.trainee_id) where e.course_id=" 
                + this.courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "enrollment");
            int rowsCount = ds.Tables["enrollment"].Rows.Count;
            traineeCountLabel.Text = rowsCount.ToString();
            traineeInfoDgView.DataSource = ds.Tables["enrollment"];
            this.enrollments = ds;
            con.Close();
        }

        // 添加学员
        private void addTraineeBtn_Click(object sender, EventArgs e)
        {
            //弹出添加学员的界面
            CourseAddTraineeForm addTraineeFm = new CourseAddTraineeForm(this.courseId);
            addTraineeFm.ShowDialog();
            refreshCourseTraineeInfo();
        }

        // 删除学员
        private void deleteTraineeBtn_Click(object sender, EventArgs e)
        {
            int idx = traineeInfoDgView.CurrentRow.Index;
            string idStr = this.enrollments.Tables["enrollment"].Rows[idx]["id"].ToString();
            string name = this.enrollments.Tables["enrollment"].Rows[idx]["name"].ToString();
            DialogResult dr = MessageBox.Show("确认删除" + name + "吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                // 删除教员
                string conStr = "server=localhost;database=training;integrated security=SSPI";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                string sql = "delete from enrollment where id=" + idStr;
                SqlCommand sqlCmd = new SqlCommand(sql, con);
                try
                {
                    int rows = sqlCmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("删除学员成功！");
                        // 刷新学员数据
                        refreshCourseTraineeInfo();
                    }
                    else
                    {
                        MessageBox.Show("删除学员失败！");
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除学员失败！");
                    Console.WriteLine("{0} Exception caught.", ex);
                    con.Close();
                }
            }
        }
    }
}
