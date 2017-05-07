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
    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
        }

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
            int rows = ds.Tables["instructors"].Rows.Count;
            if (rows > 0)
            {
                nameLabel.Text = ds.Tables["instructors"].Rows[0]["name"].ToString();
                istNumLabel.Text = ds.Tables["instructors"].Rows[0]["istNumber"].ToString();
                genderLabel.Text = ds.Tables["instructors"].Rows[0]["gender"].ToString();
                ageLabel.Text = ds.Tables["instructors"].Rows[0]["age"].ToString();
            }

            con.Close();
        }

        private void courseDetailBtn_Click(object sender, EventArgs e)
        {
            int idx = courseDgView.CurrentRow.Index;
            string idStr = this.courseDataSet.Tables["courses"].Rows[idx]["id"].ToString();
            IstCourseDetailForm detailFm = new IstCourseDetailForm(idStr);
            detailFm.ShowDialog();
        }
    }
}
