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
    public partial class AddIstForm : Form
    {
        public AddIstForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void okBtn_Click(object sender, EventArgs e) //点击按钮所调用的方法
        {
            //获取输入的内容
            string name = nameTB.Text;
            string ageStr = ageTB.Text;
            string istNum = istNumTB.Text;
             //判断添加教员的基本信息是否为空
            if (name.Length > 0 && ageStr.Length > 0 && istNum.Length > 0 && genderComBo.SelectedItem != null) 
            {
                //链接数据库插入一个新教员
                string gender = genderComBo.SelectedItem.ToString();
                string sql = "insert into instructors(name,istNumber,gender,age) values('" + name
                    + "','" + istNum + "','" + gender + "'," + ageStr + ")";
                string conStr = "server=localhost;database=training;integrated security=SSPI";
                SqlConnection sqlCon = new SqlConnection(conStr);
                SqlCommand sqlCmd = new SqlCommand(sql, sqlCon);

                try
                {
                    sqlCon.Open();
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("新增教员成功");
                    sqlCon.Close();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    sqlCon.Close();
                    MessageBox.Show("新增教员失败，请确保教员编号是准确并且唯一的");
                    Console.WriteLine("{0} Exception caught.", ex);
                }
            }
        }
    }
}
