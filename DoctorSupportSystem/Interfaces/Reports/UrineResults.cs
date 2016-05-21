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
    public partial class UrineResults : Form
    {
        public UrineResults()
        {
            InitializeComponent();
        }

        private void btnLoadResults_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBaseOperator.GetInstance()
            .getUrineAfter(1, new Date(dateTimePicker1.Value));
        }
    }
}
