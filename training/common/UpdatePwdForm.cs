﻿using System;
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
using training.tool;

namespace training.common
{
    public partial class UpdatePwdForm : Form
    {
        public UpdatePwdForm()
        {
            InitializeComponent();
        }

        public UpdatePwdForm(string uType, string id)
        {
            InitializeComponent();
            this.userType = uType;
            this.id = id;
        }

        private string userType;
        private string id;
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (newPwdTextBox.Text != newPwdTextBox2.Text)
            {
                MessageBox.Show("两次输入的密码不一致！");
                return;
            }

            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string pwd = Tool.getMd5Str(oldPwdTextBox.Text);
            if (this.userType == "trainee")
            {
                string sql = "select * from trainees where id=" + this.id + " and pwd='" + pwd + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "trainees");
                int rows = ds.Tables["trainees"].Rows.Count;
                if (rows > 0)
                {
                    string newPwd = Tool.getMd5Str(newPwdTextBox.Text);
                    sql = "update trainees set pwd='" + newPwd + "' where id=" + this.id;
                    SqlCommand sqlCmd = new SqlCommand(sql, con);
                    try
                    {
                        int r = sqlCmd.ExecuteNonQuery();
                        if (r > 0)
                        {
                            MessageBox.Show("修改密码成功！");
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("修改密码失败！");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("修改密码失败！");
                        Console.WriteLine("{0} Exception caught.", ex);
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("旧密码错误！");
                }
            }
            else if (this.userType == "instructor")
            {

            }
            else
            {
                MessageBox.Show("系统错误！");
            }

            con.Close();
        }
    }
}
