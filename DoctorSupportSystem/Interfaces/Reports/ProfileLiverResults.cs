using DoctorSupportSystem.DataBase;
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

namespace DoctorSupportSystem.Interfaces.Reports
{
    public partial class ProfileLiverResults : Form
    {
        private int pid;
        public ProfileLiverResults(int pid)
        {
            this.pid = pid;
            InitializeComponent();
        }

        private void btnLoadResults_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBaseOperator.GetInstance()
             .getProfileLiverAfter(pid, new Date(dateTimePicker1.Value));
        }

        private void btnGraphs_Click(object sender, EventArgs e)
        {
            new ProfileLiverGraphs(DataBaseOperator.GetInstance()
              .getProfileliverAfterForPlot(pid, new Date(dateTimePicker1.Value))).ShowDialog();
        }
    }
}
