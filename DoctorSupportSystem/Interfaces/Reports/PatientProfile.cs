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
using DoctorSupportSystem.Interfaces.Reports;

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
            lbBlood.Text = patient.BloodType;
            lbCN.Text = patient.ContactNo;
            lbAddress.Text = patient.Address;
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

                MenuItem mi1 = new MenuItem("Show Pervious Reports");
                mi1.Click += new EventHandler(getDayReports);
                m.MenuItems.Add(mi1);

                MenuItem mi3 = new MenuItem("Add new Day Report");
                mi3.Click += new EventHandler(addDayReport);
                m.MenuItems.Add(mi3);

                MenuItem mi2 = new MenuItem("Delete this record");
                mi2.Click += new EventHandler(deleteRecord);
                m.MenuItems.Add(mi2);

                m.Show(dgvDeseaeReports, new Point(e.X, e.Y));

            }
        }

        private void addDayReport(object sender, EventArgs e)
        {
            DeseaseReport deseaseR = new DeseaseReport();
            deseaseR.Rid = Convert.ToInt32(dgvDeseaeReports.SelectedRows[0].Cells[0].Value);
            deseaseR.Desease = dgvDeseaeReports.SelectedRows[0].Cells[1].Value.ToString();
            new MedicalDayReport(deseaseR).ShowDialog();
        }

        private void deleteRecord(object sender, EventArgs e)
        {
            if (dgvDeseaeReports.Rows.Count > 0)
            {
                DataBaseOperator.GetInstance().deleteDeseaseRecord(Convert.ToInt32(dgvDeseaeReports.SelectedRows[0].Cells[0].Value));
                dgvDeseaeReports.Rows.RemoveAt(dgvDeseaeReports.CurrentRow.Index);
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

        private void btnAddReseaseRecord_Click(object sender, EventArgs e)
        {
            new PatientDeseaseRecord(patient).ShowDialog();
            deseaseReports = DataBaseOperator.GetInstance().getAllDeseaseRecords(patient.PID);
            dgvDeseaeReports.DataSource = deseaseReports;
        }


        private void miAddCreatinintTest(object sender, EventArgs e)
        {
            new CreatinineAnd_eGFR(patient.PID).ShowDialog();
        }

        private void miAddHaemoglobinTest(object sender, EventArgs e)
        {
            new Haemoglobin(patient.PID).ShowDialog();
        }

        private void miAddLipidProfileTest(object sender, EventArgs e)
        {
            new Lipid(patient.PID).ShowDialog();
        }

        private void miAddProfileLiverTest(object sender, EventArgs e)
        {
            new ProfileLiver(patient.PID).ShowDialog();
        }

        private void miAddUrineTest(object sender, EventArgs e)
        {
            new URINE_FOR_MICRO_ALBUMIN(patient.PID).ShowDialog();
        }

        private void miShowCreatinineTest(object sender, EventArgs e)
        {
            new UrineResults(patient.PID).ShowDialog();
        }

        private void miShowHaemoglobinTests(object sender, EventArgs e)
        {
            new HeamoglobinResults(patient.PID).ShowDialog();
        }

        private void miShowLipidTests(object sender, EventArgs e)
        {
            new LipidResults(patient.PID).ShowDialog();
        }

        private void miShowProfileLiverTests(object sender, EventArgs e)
        {
            new LipidResults(patient.PID).ShowDialog();
        }

        private void miShowUrineTests(object sender, EventArgs e)
        {
            new UrineResults(patient.PID).ShowDialog();
        }

        private void miUpdateDetails_Click(object sender, EventArgs e)
        {
            new UpdatePatient(patient).ShowDialog();

            patient = DataBaseOperator.GetInstance().getPatient(patient.PID);
            lbPID.Text = patient.PID.ToString();
            lbFN.Text = patient.FirstName;
            lbLN.Text = patient.LastName;
            lbNIC.Text = patient.Nic;
            lbDOB.Text = patient.DateOfBirth.getDate();
            lbG.Text = patient.Gender;
            lbBlood.Text = patient.BloodType;
            lbCN.Text = patient.ContactNo;
            lbAddress.Text = patient.Address;
        }
    }
}
