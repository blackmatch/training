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
    public partial class EditIstForm : Form
    {
        public EditIstForm()
        {
            InitializeComponent();
        }

        private string userId;
        public EditIstForm(Instructor istInfo)
        {
            InitializeComponent();

            this.userId = istInfo.id;
            nameTB.Text = istInfo.name;
            if (istInfo.gender == "男")
            {
                genderComBo.SelectedIndex = 0;
            }
            else
            {
                genderComBo.SelectedIndex = 1;
            }
            ageTB.Text = istInfo.age.ToString();
            istNumTB.Text = istInfo.istNumber;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            //将用户输入的内容更新到数据库对应记录中
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "update instructors set name='" + nameTB.Text +
                "',gender='" + genderComBo.SelectedItem.ToString() +
                "',age=" + ageTB.Text + " where id=" + this.userId;
            Console.WriteLine(sql);
            SqlCommand sqlCmd = new SqlCommand(sql, con);
            try
            {
                int rows = sqlCmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("修改教员信息成功！");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("修改教员信息失败！");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改教员信息失败！");
                Console.WriteLine("{0} Exception caught.", ex);
                con.Close();
            }
        }
    }
}
