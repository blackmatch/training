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
using training.Admin;
using training.model;
using training.common;

namespace training.instructor
{
    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
        }

        private Instructor istInfo;
        public InstructorForm(string id)
        {
            InitializeComponent();
            this.istId = id;
            refreshIstInfoWithId(id);
            refreshCourseData();
        }

        private string istId;
        private DataSet courseDataSet;

        // 刷新课程数据
        private void refreshCourseData()
        {
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select id,name,beginDate,endDate,addr,remark from courses where ist_id=" + this.istId;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "courses");
            int rowsCount = ds.Tables["courses"].Rows.Count;
            if (rowsCount > 0)
            {
                courseDgView.DataSource = ds.Tables["courses"];
                this.courseDataSet = ds;
                courseDetailBtn.Enabled = true;
            }
            else
            {
                courseDetailBtn.Enabled = false;
            }

            con.Close();
        }

        private void refreshIstInfoWithId(string id)
        {
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select * from instructors where id=" + id;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "instructors");
            Console.WriteLine(ds);
            int rows = ds.Tables["instructors"].Rows.Count;
            if (rows > 0)
            {
                this.Text = "欢迎您，" + ds.Tables["instructors"].Rows[0]["name"].ToString();
                nameLabel.Text = ds.Tables["instructors"].Rows[0]["name"].ToString();
                istNumLabel.Text = ds.Tables["instructors"].Rows[0]["istNumber"].ToString();
                genderLabel.Text = ds.Tables["instructors"].Rows[0]["gender"].ToString();
                ageLabel.Text = ds.Tables["instructors"].Rows[0]["age"].ToString();

                // 保存教员信息
                this.istInfo = new Instructor();
                this.istInfo.id = ds.Tables["instructors"].Rows[0]["id"].ToString();
                this.istInfo.gender = ds.Tables["instructors"].Rows[0]["gender"].ToString();
                this.istInfo.name = ds.Tables["instructors"].Rows[0]["name"].ToString();
                this.istInfo.istNumber = ds.Tables["instructors"].Rows[0]["istNumber"].ToString();
                this.istInfo.age = Int16.Parse(ds.Tables["instructors"].Rows[0]["age"].ToString());
            }

            con.Close();
        }

        private void courseDetailBtn_Click(object sender, EventArgs e)
        {
            //根据选中的课程信息打开课程详情界面
            int idx = courseDgView.CurrentRow.Index;
            string idStr = this.courseDataSet.Tables["courses"].Rows[idx]["id"].ToString();
            IstCourseDetailForm detailFm = new IstCourseDetailForm(idStr);
            detailFm.ShowDialog();
        }

        private void editInfoBtn_Click(object sender, EventArgs e)
        {
            //弹出修改信息窗口
            EditIstForm editFm = new EditIstForm(this.istInfo);
            editFm.ShowDialog();
            refreshIstInfoWithId(this.istInfo.id);
            
        }

        private void updatePwdBtn_Click(object sender, EventArgs e)
        {
            //弹出修改密码窗口
            UpdatePwdForm updateFm = new UpdatePwdForm("instructor", this.istInfo.id);
            updateFm.ShowDialog();
        }

        private void refreshCourseBtn_Click(object sender, EventArgs e)
        {
            refreshCourseData();//更新数据
        }
    }
}
