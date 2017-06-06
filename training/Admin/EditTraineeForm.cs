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
    public partial class EditTraineeForm : Form
    {
        public EditTraineeForm()
        {
            InitializeComponent();
        }

        private String userId;
        // 定义一个构造函数
        public EditTraineeForm(Trainee traineeInfo)
        {
            InitializeComponent();

            this.userId = traineeInfo.id;
            nameTB.Text = traineeInfo.name;
            jobNumTB.Text = traineeInfo.jobNumber;
            if (traineeInfo.gender == "男")
            {
                genderComBo.SelectedIndex = 0;
            }
            else
            {
                genderComBo.SelectedIndex = 1;
            }
            
            ageTB.Text = traineeInfo.age.ToString();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            //将用户输入的内容更新到数据库对应的记录中
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "update trainees set name='" + nameTB.Text +
                "',gender='" + genderComBo.SelectedItem.ToString() +
                "',age=" + ageTB.Text + " where id=" + this.userId;
            SqlCommand sqlCmd = new SqlCommand(sql, con);
            try
            {
                int rows = sqlCmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("修改学员信息成功！");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("修改学员信息失败！");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改学员信息失败！");
                Console.WriteLine("{0} Exception caught.", ex);
                con.Close();
            }
        }
    }
}
