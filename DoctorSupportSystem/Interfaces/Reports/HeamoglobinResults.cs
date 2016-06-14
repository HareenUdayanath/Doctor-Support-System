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
    public partial class HeamoglobinResults : Form
    {
        private int pid;
        public HeamoglobinResults(int pid)
        {
            this.pid = pid;
            InitializeComponent();
        }

        private void bulbOFF() {
            p1.Hide();
            p2.Hide();
            p3.Hide();
            p4.Hide();
            p5.Hide();
        }

        private void btnLoadResults_Click(object sender, EventArgs e)
        {
            dgvHaemoglobin.DataSource = DataBaseOperator.GetInstance()
                .getHaemoglobinResultsAfter(pid, new Date(dateTimePicker1.Value));
        }

        private void btnGraphs_Click(object sender, EventArgs e)
        {
            new HaemoglobinGraph(DataBaseOperator.GetInstance()
            .getHaemoglobinAfterForPlot(pid, new Date(dateTimePicker1.Value))).ShowDialog();
        }

        private void dgvHaemoglobin_SelectionChanged(object sender, EventArgs e)
        {
            try {
                bulbOFF();
                if (Convert.ToDecimal(dgvHaemoglobin.SelectedRows[0].Cells[1].Value) > 8)
                {
                    p1.Show();
                }
                else if (Convert.ToDecimal(dgvHaemoglobin.SelectedRows[0].Cells[1].Value) > 7)
                {
                    p2.Show();
                }
                else if (Convert.ToDecimal(dgvHaemoglobin.SelectedRows[0].Cells[1].Value) > 6)
                {
                    p3.Show();
                    p4.Show();
                }
                else
                {
                    p5.Show();
                }
            }
            catch (Exception es) {
                Console.WriteLine(es.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
