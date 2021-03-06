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
using training.model;

namespace training.Admin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            commentDgView.AutoGenerateColumns = false;
        }


        //学员管理-新增
        private void addBtn_Click(object sender, EventArgs e) //点击新增按钮调用的方法
        {
            //弹出新增学员界面，
            AddTraineeForm addForm = new AddTraineeForm();
            addForm.ShowDialog();
            refreshTraineeData(); //新增完成后刷新学员数据
        }


        // 刷新学员列表数据
        private void refreshTraineeData()
        {
            //从数据库中获取学员列表数据
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select id,name as 姓名,gender as 性别,age as 年龄,jobNumber as 工号 from trainees";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "trainees");
            int rowsCount = ds.Tables["trainees"].Rows.Count;
            if (rowsCount > 0)
            {
                traineeDgView.DataSource = ds.Tables["trainees"];
            }

            con.Close();
        }

        // 刷新教员列表数据
        private void refreshIstData()
        {
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select id,name as '姓名',gender as '性别',age as '年龄',istNumber as '教员编号' from instructors";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "instructors");
            int rowsCount = ds.Tables["instructors"].Rows.Count;
            if (rowsCount > 0)
            {
                istDgView.DataSource = ds.Tables["instructors"];
            }

            con.Close();
        }

        // 刷新课程数据
        private void refreshCourseData()
        {
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select c.id as 'id',c.name as '课程名称',c.beginDate as '开始日期',c.endDate as '结束日期',c.addr as '培训地址',c.remark as '备注',i.name as '教员' from courses c inner join instructors i  on c.ist_id=i.id";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "courses");
            int rowsCount = ds.Tables["courses"].Rows.Count;
            if (rowsCount > 0)
            {
                courseDgView.DataSource = ds.Tables["courses"];
            }

            con.Close();
        }

        private void traineeContainer_Enter(object sender, EventArgs e)
        {
            //获取学员列表
            refreshTraineeData();
        }

        // 教员管理-新增
        private void addIstBtn_Click(object sender, EventArgs e)
        {
            AddIstForm istForm = new AddIstForm();
            istForm.ShowDialog();

            // 刷新教员列表
            refreshIstData();
        }

        // 选择教员管理模块
        private void istContainer_Enter(object sender, EventArgs e)
        {
            // 获取教员列表
            refreshIstData();
        }

        // 课程管理-新增
        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            AddCourseForm courseForm = new AddCourseForm();
            courseForm.ShowDialog();
            refreshCourseData();
        }


        // 学员管理-修改信息
        private void editTraineeInfoBtn_Click(object sender, EventArgs e) 
        {
            //拿到当前选中的学员信息，弹出修改的学员界面
            int idx = traineeDgView.CurrentRow.Index;
            string idStr = traineeDgView.Rows[idx].Cells["id"].Value.ToString();
            Trainee traineeInfo = new Trainee();
            traineeInfo.id = idStr;
            traineeInfo.name = traineeDgView.Rows[idx].Cells["姓名"].Value.ToString();
            traineeInfo.gender = traineeDgView.Rows[idx].Cells["性别"].Value.ToString();
            traineeInfo.jobNumber = traineeDgView.Rows[idx].Cells["工号"].Value.ToString();
            traineeInfo.age = int.Parse(traineeDgView.Rows[idx].Cells["年龄"].Value.ToString());
            EditTraineeForm editFm = new EditTraineeForm(traineeInfo);
            editFm.ShowDialog();

            // 刷新数据
            refreshTraineeData();
        }


        // 学员管理 - 重置密码
        private void resetTraineePwd_Click(object sender, EventArgs e)
        {
            //弹出对话框提示是否重置密码
            int idx = traineeDgView.CurrentRow.Index;
            string idStr = traineeDgView.Rows[idx].Cells["id"].Value.ToString();
            string name = traineeDgView.Rows[idx].Cells["姓名"].Value.ToString();
            DialogResult dr = MessageBox.Show("确认重置" + name + "的密码吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                //重置密码
                string pwd = Tool.getMd5Str("123456");
                string conStr = "server=localhost;database=training;integrated security=SSPI";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                string sql = "update trainees set pwd='" + pwd + "' where id=" + idStr;
                SqlCommand sqlCmd = new SqlCommand(sql, con);
                try
                {
                    int rows = sqlCmd.ExecuteNonQuery(); //把新密码更新到数据库·
                    if (rows > 0)
                    {
                        MessageBox.Show("重置密码成功！");
                    }
                    else
                    {
                        MessageBox.Show("重置密码失败！");
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("重置密码失败！");
                    Console.WriteLine("{0} Exception caught.", ex);
                    con.Close();
                }
            }
        }


        // 学员管理 - 删除
        private void deleteTraineeBtn_Click(object sender, EventArgs e)
        {
            //弹出对话框提示是否删除学员
            int idx = traineeDgView.CurrentRow.Index;
            string idStr = traineeDgView.Rows[idx].Cells["id"].Value.ToString();
            string name = traineeDgView.Rows[idx].Cells["姓名"].Value.ToString();
            DialogResult dr = MessageBox.Show("确认删除" + name + "的信息吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                //从数据库中删除学员
                string conStr = "server=localhost;database=training;integrated security=SSPI";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                string sql = "delete from trainees where id=" + idStr;
                SqlCommand sqlCmd = new SqlCommand(sql, con);
                try
                {
                    int rows = sqlCmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("删除学员成功！");
                        // 刷新学员数据
                        refreshTraineeData();
                    }
                    else
                    {
                        MessageBox.Show("删除学员失败！");
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除学员失败！");
                    Console.WriteLine("{0} Exception caught.", ex);
                    con.Close();
                }
            }
        }

        // 学员管理-刷新
        private void refreshTraineeBtn_Click(object sender, EventArgs e)
        {
            // 刷新学员数据的方法
            refreshTraineeData();
        }

        // 教员管理-修改信息
        private void editIstBtn_Click(object sender, EventArgs e)
        {
            int idx = istDgView.CurrentRow.Index;
            string idStr = istDgView.Rows[idx].Cells["id"].Value.ToString();
            Instructor istInfo = new Instructor();
            istInfo.id = idStr;
            istInfo.name = istDgView.Rows[idx].Cells["姓名"].Value.ToString();
            istInfo.gender = istDgView.Rows[idx].Cells["性别"].Value.ToString();
            istInfo.age = int.Parse(istDgView.Rows[idx].Cells["年龄"].Value.ToString());
            istInfo.istNumber = istDgView.Rows[idx].Cells["教员编号"].Value.ToString();

            EditIstForm istFm = new EditIstForm(istInfo);
            istFm.ShowDialog();
            // 刷新教员信息
            refreshIstData();
        }

        // 教员管理-重置密码
        private void resetIstPwdBtn_Click(object sender, EventArgs e)
        {
            int idx = istDgView.CurrentRow.Index;
            string idStr = istDgView.Rows[idx].Cells["id"].Value.ToString();
            string name = istDgView.Rows[idx].Cells["姓名"].Value.ToString();
            DialogResult dr = MessageBox.Show("确认重置" + name + "的密码吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                // 重置密码
                string pwd = Tool.getMd5Str("123456");
                string conStr = "server=localhost;database=training;integrated security=SSPI";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                string sql = "update instructors set pwd='" + pwd + "' where id=" + idStr;
                SqlCommand sqlCmd = new SqlCommand(sql, con);
                try
                {
                    int rows = sqlCmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("重置密码成功！");
                    }
                    else
                    {
                        MessageBox.Show("重置密码成功！");
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("重置密码失败！");
                    Console.WriteLine("{0} Exception caught.", ex);
                    con.Close();
                }
            }
        }

        // 教员管理-删除
        private void deleteIstBtn_Click(object sender, EventArgs e)
        {
            //删除学员
            int idx = istDgView.CurrentRow.Index;
            string idStr = istDgView.Rows[idx].Cells["id"].Value.ToString();
            string name = istDgView.Rows[idx].Cells["姓名"].Value.ToString();
            DialogResult dr = MessageBox.Show("确认删除" + name + "的信息吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                // 删除教员
                string conStr = "server=localhost;database=training;integrated security=SSPI";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                string sql = "delete from instructors where id=" + idStr;
                SqlCommand sqlCmd = new SqlCommand(sql, con);
                try
                {
                    int rows = sqlCmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("删除教员成功！");
                        // 刷新教员数据
                        refreshIstData();
                    }
                    else
                    {
                        MessageBox.Show("删除教员失败！");
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除教员失败！");
                    Console.WriteLine("{0} Exception caught.", ex);
                    con.Close();
                }
            }
        }

        // 教员管理-刷新
        private void refreshIstBtn_Click(object sender, EventArgs e)
        {
            refreshIstData();
        }

        // 选择课程模块
        private void courseContainer_Enter(object sender, EventArgs e)
        {
            refreshCourseData();
        }

        // 课程管理-修改
        private void editCourseBtn_Click(object sender, EventArgs e)
        {
            int idx = courseDgView.CurrentRow.Index;
            string idStr = courseDgView.Rows[idx].Cells["id"].Value.ToString();
            Course courseInfo = new Course();
            courseInfo.id = idStr;
            courseInfo.name = courseDgView.Rows[idx].Cells["课程名称"].Value.ToString();
            courseInfo.beginDate = courseDgView.Rows[idx].Cells["开始日期"].Value.ToString();
            courseInfo.endDate = courseDgView.Rows[idx].Cells["结束日期"].Value.ToString();
            courseInfo.addr = courseDgView.Rows[idx].Cells["培训地址"].Value.ToString();
            courseInfo.remark = courseDgView.Rows[idx].Cells["备注"].Value.ToString();
            EditCourseForm editFm = new EditCourseForm(courseInfo);
            editFm.ShowDialog();
            refreshCourseData();
        }

        // 课程管理 - 删除
        private void deleteCourseBtn_Click(object sender, EventArgs e)
        {
            int idx = courseDgView.CurrentRow.Index;
            string idStr = courseDgView.Rows[idx].Cells["id"].Value.ToString();
            DialogResult dr = MessageBox.Show("确认删除该课程吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                // 删除课程
                string conStr = "server=localhost;database=training;integrated security=SSPI";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                string sql = "delete from courses where id=" + idStr;
                SqlCommand sqlCmd = new SqlCommand(sql, con);
                try
                {
                    int rows = sqlCmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("删除课程成功！");
                        // 刷新课程数据
                        refreshCourseData();
                    }
                    else
                    {
                        MessageBox.Show("删除课程失败！");
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除课程失败！");
                    Console.WriteLine("{0} Exception caught.", ex);
                    con.Close();
                }
            }
        }

        // 课程管理 - 刷新
        private void refreshCourseBtn_Click(object sender, EventArgs e)
        {
            refreshCourseData();
        }

        // 课程管理 - 查看详情
        private void courseDetailBtn_Click(object sender, EventArgs e)
        {
            int idx = courseDgView.CurrentRow.Index;
            string idStr = courseDgView.Rows[idx].Cells["id"].Value.ToString();
            CourseDetailForm cDetailFm = new CourseDetailForm(idStr);
            cDetailFm.ShowDialog();
        }

        // 切换到评论管理
        private void commentPage_Enter(object sender, EventArgs e)
        {
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select id,name from courses";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "courses");
            courseComboBox.DisplayMember = "name";
            courseComboBox.ValueMember = "id";
            courseComboBox.DataSource = ds.Tables["courses"];
            con.Close();

            // 获取评论信息
            string cId = courseComboBox.SelectedValue.ToString();
            getCourseCommentsById(cId);
        }

        // 根据id获取课程评论
        private void getCourseCommentsById(string cId)
        {
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select id,content,createdAt from comments where course_id=" + cId;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "comments");
            commentDgView.DataSource = ds.Tables["comments"];
            con.Close();
        }

        // 评论管理 - 删除
        private void deleteCommentBtn_Click(object sender, EventArgs e)
        {
            int idx = commentDgView.CurrentRow.Index;
            string idStr = commentDgView.Rows[idx].Cells["id"].Value.ToString();
            DialogResult dr = MessageBox.Show("确认删除该评论吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                // 删除评论
                string conStr = "server=localhost;database=training;integrated security=SSPI";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                string sql = "delete from comments where id=" + idStr;
                SqlCommand sqlCmd = new SqlCommand(sql, con);
                try
                {
                    int rows = sqlCmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("删除评论成功！");
                        // 获取评论信息
                        string cId = courseComboBox.SelectedValue.ToString();
                        getCourseCommentsById(cId);
                    }
                    else
                    {
                        MessageBox.Show("删除评论失败！");
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除评论失败！");
                    Console.WriteLine("{0} Exception caught.", ex);
                    con.Close();
                }
            }
        }

        // 评论管理 - 刷新
        private void refreshCommentBtn_Click(object sender, EventArgs e)
        {
            // 获取评论信息
            string cId = courseComboBox.SelectedValue.ToString();
            getCourseCommentsById(cId);
        }

        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cId = courseComboBox.SelectedValue.ToString();
            getCourseCommentsById(cId);
        }
    }
}
