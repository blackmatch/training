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
using System.Data.SqlClient;    //使用SqlConnection与sql server交互
using training.Admin;
using training.instructor;
using training.trainee;
using training.tool;
using training.model;

namespace training
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }
        //点击登陆按钮执行的操作
        private void loginBtn_Click(object sender, EventArgs e)
        {
            int idx = loginTabControl.SelectedIndex; //判断当前入口的身份，idx=0，管理员入口，1为教员，2为学员
            switch (idx)
            {
                case 0:
                    adminLogin();
                    break;
                case 1:
                    istLogin();
                    break;
                case 2:
                    traineeLogin();
                    break;
                default:
                    MessageBox.Show("操作错误");
                    break;
            } 
        }

        /// <summary>
        /// 管理员登录
        /// </summary>
        private void adminLogin()
        {
            // 判断用户名和密码是否有输入
            if (adminUserNameTextBox.Text.Trim().Length > 0 && adminPwdTextBox.Text.Trim().Length > 0)
            {
                //获取输入的用户名和密码
                string username = adminUserNameTextBox.Text.Trim();
                string pwd = Tool.getMd5Str(adminPwdTextBox.Text.Trim());
                //链接并打开数据库
                string conStr = "server=localhost;database=training;integrated security=SSPI";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                //根据输入的用户名和密码来查询数据库中是否有相应的数据
                string sql = "select * from admins where userName='" + username + "' and pwd='" + pwd + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "admins");
                //查看数据库中是否有匹配的数据
                int rows = ds.Tables["admins"].Rows.Count;
                //userNameTb.Text = ds.Tables["admins"].Rows[0]["userName"].ToString();
                if (rows > 0)
                {
                    AdminForm adminFm = new AdminForm();
                    adminFm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误");
                }
            }
            else
            {
                MessageBox.Show("请正确输入用户名和密码");
            }
        }

        /// <summary>
        /// 教员登录
        /// </summary>
        private void istLogin()
        {
            if (istNumberTextBox.Text.Trim().Length > 0 && istPwdTextBox.Text.Trim().Length > 0)
            {
                string istNumber = istNumberTextBox.Text.Trim();
                string pwd = Tool.getMd5Str(istPwdTextBox.Text.Trim());

                string conStr = "server=localhost;database=training;integrated security=SSPI";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                string sql = "select * from instructors where istNumber='" + istNumber + "' and pwd='" + pwd + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "instructors");
                int rows = ds.Tables["instructors"].Rows.Count;
                string istId = ds.Tables["instructors"].Rows[0]["id"].ToString();
                if (rows > 0)
                {
                    InstructorForm istFm = new InstructorForm(istId);
                    istFm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("教员编号或密码错误");
                }
            }
            else
            {
                MessageBox.Show("请正确输入教员编号和密码");
            }
        }

        /// <summary>
        /// 学员登录
        /// </summary>
        private void traineeLogin()
        {
            if (traineeJobNumberTextBox.Text.Trim().Length > 0 && traineePwdTextBox.Text.Trim().Length > 0)
            {
                string jobNumber = traineeJobNumberTextBox.Text.Trim();
                string pwd = Tool.getMd5Str(traineePwdTextBox.Text.Trim());

                string conStr = "server=localhost;database=training;integrated security=SSPI";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                string sql = "select * from trainees where jobNumber='" + jobNumber + "' and pwd='" + pwd + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "trainees");
                int rows = ds.Tables["trainees"].Rows.Count;
            
                if (rows > 0)
                {
                    Trainee trainee = new Trainee(ds);
                    TraineeForm traineeFm = new TraineeForm(trainee);
                    traineeFm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("员工编号或密码错误");
                }
            }
            else
            {
                MessageBox.Show("请正确输入员工编号和密码");
            }
        }
    }
}
