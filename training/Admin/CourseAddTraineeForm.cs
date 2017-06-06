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
    public partial class CourseAddTraineeForm : Form
    {
        public CourseAddTraineeForm()
        {
            InitializeComponent();
        }

        private string courseId;
        private DataSet traineeDataSet;
        public CourseAddTraineeForm(string cId)
        {
            InitializeComponent();
            traineeDgView.AutoGenerateColumns = false;
            this.courseId = cId;
            refreshTraineeData();
        }

        private void refreshTraineeData()
        {
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select id,name,jobNumber from trainees";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "trainees");
            traineeDgView.DataSource = ds.Tables["trainees"];
            this.traineeDataSet = ds;
            con.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            //获取要添加学员的id
            int idx = traineeDgView.CurrentRow.Index; 
            string idStr = this.traineeDataSet.Tables["trainees"].Rows[idx]["id"].ToString();
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            //根据学员和课程id拼接sql语句，来插入到数据库中
            string sql = "insert into enrollment(course_id,trainee_id) values(" + this.courseId 
                + "," + idStr + ")";
            SqlCommand sqlCmd = new SqlCommand(sql, con);
            try
            {
                int rows = sqlCmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("添加学员成功！");
                    // this.Dispose();
                }
                else
                {
                    MessageBox.Show("添加学员失败！");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加学员失败！");
                Console.WriteLine("{0} Exception caught.", ex);
                con.Close();
            }
        }
    }
}
