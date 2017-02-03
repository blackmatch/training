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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddTraineeForm addForm = new AddTraineeForm();
            addForm.ShowDialog();
        }

        private void traineeContainer_Enter(object sender, EventArgs e)
        {
            //获取学员列表
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select * from trainees";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "trainees");
            int rowsCount = ds.Tables["trainees"].Rows.Count;
            if (rowsCount > 0)
            {
                //DataGridViewCheckBoxColumn cbColumn = new DataGridViewCheckBoxColumn();
                //cbColumn.HeaderText = "选择";
                //cbColumn.Name = "checkbox";
                //cbColumn.TrueValue = true;
                //cbColumn.FalseValue = false;
                //cbColumn.DataPropertyName = "isChecked";
                //traineeDgView.Columns.Add(cbColumn);
                traineeDgView.DataSource = ds.Tables["trainees"];
            }

            con.Close();
        }

        private void addIstBtn_Click(object sender, EventArgs e)
        {
            AddIstForm istForm = new AddIstForm();
            istForm.ShowDialog();
        }

        private void istContainer_Enter(object sender, EventArgs e)
        {
            //获取教员列表
            string conStr = "server=localhost;database=training;integrated security=SSPI";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string sql = "select * from instructors";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "instructors");
            int rowsCount = ds.Tables["instructors"].Rows.Count;
            if (rowsCount > 0)
            {
                //DataGridViewCheckBoxColumn cbColumn = new DataGridViewCheckBoxColumn();
                //cbColumn.HeaderText = "选择";
                //cbColumn.Name = "checkbox";
                //cbColumn.TrueValue = true;
                //cbColumn.FalseValue = false;
                //cbColumn.DataPropertyName = "isChecked";
                //istDgView.Columns.Add(cbColumn);
                istDgView.DataSource = ds.Tables["instructors"];
            }

            con.Close();
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            AddCourseForm courseForm = new AddCourseForm();
            courseForm.ShowDialog();
        }
    }
}
