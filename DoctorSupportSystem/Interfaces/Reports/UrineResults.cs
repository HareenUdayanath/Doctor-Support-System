﻿using DoctorSupportSystem.DataBase;
using DoctorSupportSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoctorSupportSystem.Interfaces.Reports;

namespace DoctorSupportSystem.Interfaces.Reports
{
    public partial class UrineResults : Form
    {
        private int pid;
        public UrineResults(int pid)
        {
            this.pid = pid;
            InitializeComponent();
        }

        private void btnLoadResults_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBaseOperator.GetInstance()
            .getUrineAfter(pid, new Date(dateTimePicker1.Value));
        }

        private void btnGraphs_Click(object sender, EventArgs e)
        {
            new UrineTestGraphs(DataBaseOperator.GetInstance()
                .getUrineAfterForPlot(pid, new Date(dateTimePicker1.Value))).ShowDialog();
        }
    }
}
