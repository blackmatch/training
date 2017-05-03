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

namespace training.Admin
{
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }

        private string courseId;
        private DataSet ists;

        public EditCourseForm(Course courseInfo)
        {
            InitializeComponent();

            nameTB.Text = courseInfo.name;
            beginDatePicker.Text = courseInfo.beginDate;
            endDatePicker.Text = courseInfo.endDate;
            addrTB.Text = courseInfo.addr;
            remarkRichTB.Text = courseInfo.remark;

            this.courseId = courseInfo.id;

            DataSet ists = getAllIsts();
            this.ists = ists;
            int selectedIdx = 0;
            for (int i = 0; i < ists.Tables["instructors"].Rows.Count; i++)
            {
                istComBo.Items.Add(ists.Tables["instructors"].Rows[i]["姓名"] + " （" + ists.Tables["instructors"].Rows[i]["教员编号"] + "）");
            }
        }

        private DataSet getAllIsts()
        {
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select id,name as '姓名',gender as '性别',age as '年龄',istNumber as '教员编号' from instructors";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "instructors");
            int rowsCount = ds.Tables["instructors"].Rows.Count;
            con.Close();
            if (rowsCount > 0)
            {
                return ds;
            }
            else
            {
                return new DataSet();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text;
            string beginDate = beginDatePicker.Text;
            string endDate = endDatePicker.Text;
            string address = addrTB.Text;
            string remark = remarkRichTB.Text;
            int idx = istComBo.SelectedIndex;
            string idStr = this.ists.Tables["instructors"].Rows[idx]["id"].ToString();

            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "update courses set name='" + name + "',beginDate='" + beginDate + "',endDate='"
                + endDate + "',addr='" + address + "',remark='" + remark + "' where id=" + courseId;
            SqlCommand sqlCmd = new SqlCommand(sql, con);
            try
            {
                int rows = sqlCmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("修改课程信息成功！");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("修改课程信息失败！");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改课程信息失败！");
                Console.WriteLine("{0} Exception caught.", ex);
                con.Close();
            }
        }
    }
}
