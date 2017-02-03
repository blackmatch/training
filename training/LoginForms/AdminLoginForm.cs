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
using System.Data.SqlClient;    //使用SqlConnection与sql server交互
using training.Admin;

namespace training.LoginForms
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userName = userNameTb.Text;
            string pwd = pwdTb.Text;
            if (userName.Length > 0 && pwd.Length > 0)
            {
                string conStr = "server=localhost;database=training;integrated security=SSPI";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                string sql = "select * from admins where userName='" + userName + "' and pwd='" + pwd + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "admins");
                int rows = ds.Tables["admins"].Rows.Count;
                //userNameTb.Text = ds.Tables["admins"].Rows[0]["userName"].ToString();
                if (rows > 0)
                {
                    //MessageBox.Show("登录成功");

                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("请输入用户名和密码");
            }
        }
    }
}
