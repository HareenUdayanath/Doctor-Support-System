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
    public partial class LipidResults : Form
    {
        private int pid;
        public LipidResults(int pid)
        {
            this.pid = pid;
            InitializeComponent();
        }
        private void bulbOFF()
        {
            pCT1.Hide(); pCT2.Hide(); pCT3.Hide();
            pCHDL1.Hide();pCHDL2.Hide();
            pCLDL1.Hide();pCLDL2.Hide();
            pT1.Hide(); pT2.Hide(); pT3.Hide(); pT4.Hide();
        }
        private void btnLoadResults_Click(object sender, EventArgs e)
        {
            dgvLipid.DataSource = DataBaseOperator.GetInstance()
               .getLipidResultsAfter(pid, new Date(dateTimePicker1.Value));
        }

        private void btnGraphs_Click(object sender, EventArgs e)
        {
            new LipidGraphs(DataBaseOperator.GetInstance()
             .getLipidAfterForPlot(pid, new Date(dateTimePicker1.Value))).ShowDialog();
        }

        private void dgvLipid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                bulbOFF();
                if (Convert.ToDecimal(dgvLipid.SelectedRows[0].Cells[1].Value) < 200)
                {
                    pCT1.Show();
                }
                else if (Convert.ToDecimal(dgvLipid.SelectedRows[0].Cells[1].Value) > 240)
                {
                    pCT3.Show();
                }
                else 
                {
                    pCT2.Show();
                }

                if (Convert.ToDecimal(dgvLipid.SelectedRows[0].Cells[3].Value) < 60 && Convert.ToDecimal(dgvLipid.SelectedRows[0].Cells[3].Value) > 49)
                {
                    pCHDL1.Show();
                }
                else if (Convert.ToDecimal(dgvLipid.SelectedRows[0].Cells[3].Value) > 60)
                {
                    pCHDL2.Show();
                }

                if (Convert.ToDecimal(dgvLipid.SelectedRows[0].Cells[4].Value) < 100)
                {
                    pCLDL1.Show();
                }
                else if (Convert.ToDecimal(dgvLipid.SelectedRows[0].Cells[4].Value) > 160)
                {
                    pCLDL3.Show();
                }
                else
                {
                    pCLDL2.Show();
                }

                if (Convert.ToDecimal(dgvLipid.SelectedRows[0].Cells[1].Value) < 150)
                {
                    pT1.Show();
                }
                else if (Convert.ToDecimal(dgvLipid.SelectedRows[0].Cells[1].Value) > 500)
                {
                    pT4.Show();
                }
                else if (Convert.ToDecimal(dgvLipid.SelectedRows[0].Cells[1].Value) > 199)
                {
                    pT3.Show();
                }
                else
                {
                    pT2.Show();
                }

            }
            catch (Exception es)
            {
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
