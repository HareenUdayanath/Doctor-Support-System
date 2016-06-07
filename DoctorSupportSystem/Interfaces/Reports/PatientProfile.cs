using DoctorSupportSystem.DataBase;
using DoctorSupportSystem.Interfaces.Tests;
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
    public partial class PatientProfile : Form
    {
        Patient patient;
        DataTable deseaseReports;

        public PatientProfile(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            deseaseReports = DataBaseOperator.GetInstance().getAllDeseaseRecords(patient.PID);
            dgvDeseaeReports.DataSource = deseaseReports;

            lbPID.Text = patient.PID.ToString();
            lbFN.Text = patient.FirstName;
            lbLN.Text = patient.LastName;
            lbNIC.Text = patient.Nic;
            lbDOB.Text = patient.DateOfBirth.getDate();
            lbG.Text = patient.Gender;
            lbCN.Text = patient.ContactNo;

        }


        private void miCreatinineTest_Click(object sender, EventArgs e)
        {
            new HeamoglobinResults(patient.PID).ShowDialog();
        }

        private void miHaemoglobinTest_Click(object sender, EventArgs e)
        {
            new HeamoglobinResults(patient.PID).ShowDialog();
        }

        private void miLipidTest_Click(object sender, EventArgs e)
        {
            new LipidResults(patient.PID).ShowDialog();
        }

        private void miProfileLiverTest_Click(object sender, EventArgs e)
        {
            new ProfileLiverResults(patient.PID).ShowDialog();
        }

        private void miUrineTest_Click(object sender, EventArgs e)
        {
            new UrineResults(patient.PID).ShowDialog();
        }

        private void btnRefreshReports_Click(object sender, EventArgs e)
        {
            deseaseReports = DataBaseOperator.GetInstance().getAllDeseaseRecords(patient.PID);
            dgvDeseaeReports.DataSource = deseaseReports;
        }

        private void dgvDeseaeReports_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvDeseaeReports.HitTest(e.X, e.Y);
                dgvDeseaeReports.ClearSelection();
                dgvDeseaeReports.Rows[hti.RowIndex].Selected = true;

                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = dgvDeseaeReports.HitTest(e.X, e.Y).RowIndex;
                /*DataGridViewRow selectedRow = dgvDeseaeReports.Rows[currentMouseOverRow];
                selectedPID = Convert.ToInt32(selectedRow.Cells["PID"].Value);*/

                MenuItem mi1 = new MenuItem(string.Format("Show Pervious Reports", currentMouseOverRow.ToString()));
                mi1.Click += new EventHandler(getDayReports);
                m.MenuItems.Add(mi1);                           


                m.Show(dgvDeseaeReports, new Point(e.X, e.Y));

            }
        }

        private void getDayReports(object sender, EventArgs e)
        {
            new DayReports(Convert.ToInt32(dgvDeseaeReports.SelectedRows[0].Cells[0].Value)).Show();
        }

        private void PatientProfile_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDeseaeReports.Columns[0].Width = 50;
                //dgvDeseaeReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            catch (Exception ee) { Console.WriteLine("SS" + ee.Message); }
        }
    }
}
