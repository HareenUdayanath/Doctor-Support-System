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
    public partial class CreatinineAnd_eGFR_Results : Form
    {
        public CreatinineAnd_eGFR_Results()
        {
            InitializeComponent();
        }

        private void btnLoadResults_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBaseOperator.GetInstance()
                .getCreatinineResultsAfter(1, new Date(dateTimePicker1.Value));
        }

        private void btnGraphs_Click(object sender, EventArgs e)
        {
            new CreatinineAnd_eGFR_Graphs(DataBaseOperator.GetInstance()
           .getCreatinineAfterForPlot(1, new Date(dateTimePicker1.Value))).ShowDialog();
        }
    }
}
