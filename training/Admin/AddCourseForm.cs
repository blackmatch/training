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
    public partial class AddCourseForm : Form
    {
        private DataSet ists;
        public AddCourseForm()
        {
            InitializeComponent();
            DataSet ists = getAllIsts();
            this.ists = ists;
            for (int i = 0; i < ists.Tables["instructors"].Rows.Count; i++ )
            {
                istComBo.Items.Add(ists.Tables["instructors"].Rows[i]["姓名"] + " （" + ists.Tables["instructors"].Rows[i]["教员编号"] + "）");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            else {
                return new DataSet();
            }

           
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
            if (name.Length > 0)
            {
                //插入数据
                string sql = "insert into courses(name,ist_id,beginDate,endDate,addr,remark) values('" + name
                    + "'," + idStr +",'" + beginDate + "','" + endDate + "','" + address + "','" + remark + "')";
                string conStr = "server=localhost;database=training;integrated security=SSPI";
                SqlConnection sqlCon = new SqlConnection(conStr);
                SqlCommand sqlCmd = new SqlCommand(sql, sqlCon);

                try
                {
                    sqlCon.Open();
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("新增课程成功！");
                    sqlCon.Close();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    sqlCon.Close();
                    MessageBox.Show("新增课程失败！" + sql);
                    Console.WriteLine("{0} Exception caught.", ex);
                }
            }
            else
            {
                MessageBox.Show("请填写完整的学员信息");
            }
        }
    }
}
