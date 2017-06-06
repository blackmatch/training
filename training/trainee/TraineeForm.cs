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
using training.model;
using training.Admin;
using training.common;

namespace training.trainee
{
    public partial class TraineeForm : Form
    {
        public TraineeForm()
        {
            InitializeComponent();
        }

        private Trainee traineeInfo;
        private DataSet myCourses;
        public TraineeForm(Trainee trainee)
        {
            InitializeComponent();
            this.traineeInfo = trainee;
            this.Text = "欢迎您，" + this.traineeInfo.name;
            updateTraineeInfo();
            refreshCourseData();
        }

        private void refreshCourseData()
        {
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select c.id,c.name,i.name as istName,c.beginDate,c.endDate,c.addr,c.remark from enrollment e left join courses c on (e.course_id=c.id) left join instructors i on (c.ist_id=i.id) where trainee_id="
                + this.traineeInfo.id;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "enrollment");
            this.myCourses = ds;
            courseDgView.DataSource = ds.Tables["enrollment"];
        }

        private void updateTraineeInfo()
        {
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select * from trainees where id=" + this.traineeInfo.id;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "trainees");
            int rows = ds.Tables["trainees"].Rows.Count;

            if (rows > 0)
            {
                this.traineeInfo = new Trainee(ds);
                nameLabel.Text = this.traineeInfo.name;
                jobNumberLabel.Text = this.traineeInfo.jobNumber;
                genderLabel.Text = this.traineeInfo.gender;
                ageLabel.Text = this.traineeInfo.age.ToString();
            }
        }

        private void editInfoBtn_Click(object sender, EventArgs e)
        {
            //弹出修改学员窗口，
            EditTraineeForm editFm = new EditTraineeForm(this.traineeInfo);
            editFm.ShowDialog();
            updateTraineeInfo(); //更新学员信息
        }

        private void updatePwdBtn_Click(object sender, EventArgs e)
        {
            //弹出修改密码窗口
            UpdatePwdForm updateFm = new UpdatePwdForm("trainee", this.traineeInfo.id);
            updateFm.ShowDialog();
        }

        private void courseDetailBtn_Click(object sender, EventArgs e)
        {
            //先获取选中课程的id，弹出课程详情窗口
            int idx = courseDgView.CurrentRow.Index;
            string cId = this.myCourses.Tables["enrollment"].Rows[idx]["id"].ToString();
            string cName = this.myCourses.Tables["enrollment"].Rows[idx]["name"].ToString();
            TraineeCourseDetailForm detailFm = new TraineeCourseDetailForm(this.traineeInfo.id, cId, cName);
            detailFm.ShowDialog();
        }

        private void addCommentBtn_Click(object sender, EventArgs e)
        {
            //弹出评论窗口，更新课程信息
            int idx = courseDgView.CurrentRow.Index;
            string cId = this.myCourses.Tables["enrollment"].Rows[idx]["id"].ToString();
            AddCourseCommentForm commentFm = new AddCourseCommentForm(this.traineeInfo.id, cId);
            commentFm.ShowDialog();
            refreshCourseData();
        }

        private void refreshCourseBtn_Click(object sender, EventArgs e)
        {
            refreshCourseData(); //更新课程信息
        }
    }
}
