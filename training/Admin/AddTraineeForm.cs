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
    public partial class AddTraineeForm : Form
    {
        public AddTraineeForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //关闭当前窗口
            this.Dispose();
        }
        
        private void okBtn_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text;
            string jobNum = jobNumTB.Text;
            string ageStr = ageTB.Text;

            if (name.Length > 0 && jobNum.Length > 0 && genderComBo.SelectedItem != null && ageStr.Length > 0)
            {
                //插入数据
                string gender = genderComBo.SelectedItem.ToString();
                string sql = "insert into trainees(name,jobNumber,gender,age) values('" + name
                    + "','" + jobNum + "','" + gender + "'," + ageStr + ")";
                string conStr = "server=localhost;database=training;integrated security=SSPI";
                SqlConnection sqlCon = new SqlConnection(conStr);
                SqlCommand sqlCmd = new SqlCommand(sql, sqlCon);

                try
                {
                    sqlCon.Open();
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("新增学员成功");
                    sqlCon.Close();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    sqlCon.Close();
                    MessageBox.Show("新增学员失败，请确保工号是准确并且唯一的");
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
