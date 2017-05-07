using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace training.instructor
{
    public partial class ScoreTraineeForm : Form
    {
        public ScoreTraineeForm()
        {
            InitializeComponent();
        }

        private string traineeId;
        private string courseId;
        public ScoreTraineeForm(string tId, string name, string jobNumber, string cId)
        {
            InitializeComponent();
            nameLabel.Text = name;
            jobNumberLabel.Text = jobNumber;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
