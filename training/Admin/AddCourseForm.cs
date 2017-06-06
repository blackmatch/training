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
            DataSet ists = getAllIsts(); //获取所有的教员
            this.ists = ists;
            //设置教员选项下拉时的数据
            for (int i = 0; i < ists.Tables["instructors"].Rows.Count; i++ )
            {
                istComBo.Items.Add(ists.Tables["instructors"].Rows[i]["姓名"] + " （" + ists.Tables["instructors"].Rows[i]["教员编号"] + "）");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //关闭当前的窗口
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
            else 
            {
                return new DataSet();
            }
        }

        //点击确定按钮执行的方法
        private void okBtn_Click(object sender, EventArgs e)
        {
            //获取输入的数据
            string name = nameTB.Text;
            string beginDate = beginDatePicker.Text;
            string endDate = endDatePicker.Text;
            string address = addrTB.Text;
            string remark = remarkRichTB.Text;
            int idx = istComBo.SelectedIndex;
            if (idx == -1)
            {
                MessageBox.Show("请选择教员！");
                return;
            }
            string idStr = this.ists.Tables["instructors"].Rows[idx]["id"].ToString();
            //把课程的信息写入数据库
            if (name.Length > 0)
            {
                //插入数据
                string sql = "insert into courses(name,ist_id,beginDate,endDate,addr,remark) values('" + name
                    + "'," + idStr +",'" + beginDate + "','" + endDate + "','" + address + "','" + remark + "')";
                string conStr = "server=localhost;database=training;integrated security=SSPI";
                SqlConnection sqlCon = new SqlConnection(conStr);
                SqlCommand sqlCmd = new SqlCommand(sql, sqlCon);
                // 打开数据库添加课程
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
                    MessageBox.Show("新增课程失败！");
                    Console.WriteLine("{0} Exception caught.", ex);
                }
            }
            else
            {
                MessageBox.Show("请输入课程名称");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
