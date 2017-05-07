﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using training.model;

namespace training.trainee
{
    public partial class TraineeForm : Form
    {
        public TraineeForm()
        {
            InitializeComponent();
        }

        private Trainee traineeInfo;
        public TraineeForm(Trainee trainee)
        {
            InitializeComponent();
            this.traineeInfo = trainee;
        }
    }
}
