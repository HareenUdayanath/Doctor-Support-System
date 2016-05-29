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

namespace DoctorSupportSystem.Interfaces
{
    public partial class AssistanceInterface : Form
    {
        Patient patient;

        public AssistanceInterface()
        {
            InitializeComponent();

            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            col.AddRange(DataBaseOperator.GetInstance().getPatientNameList());
            cbSearchPatients.AutoCompleteCustomSource = col;
            dataGridView1.DataSource = DataBaseOperator.GetInstance().getAllPatients();
            dataGridView2.DataSource = DataBaseOperator.GetInstance().getAllAppointments();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = DataBaseOperator.GetInstance().getAllAppointments();
        }

        private void btnLoadPatients_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBaseOperator.GetInstance().getAllPatients();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            new AddAppointment().ShowDialog();
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            if (this.rbtnCreatinineTest.Checked)
                new CreatinineAnd_eGFR().ShowDialog();
            else if (this.rbtnHaemoglobinTest.Checked)
                new Haemoglobin().ShowDialog();
            else if (this.rbtnLipidTest.Checked)
                new Lipid().ShowDialog();
            else if (this.rbtnPrfileLiverTest.Checked)
                new ProfileLiver().ShowDialog();
            else if (this.rbtnUrineTest.Checked)
                new URINE_FOR_MICRO_ALBUMIN().ShowDialog();
        }

        private void cbSearchPatients_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string nic = cbSearchPatients.Text.Split('-')[1];
                Console.WriteLine(nic);
                patient = DataBaseOperator.GetInstance().getPatientByNIC(nic);
                if (patient != null)
                {
                    lbPID.Text = patient.PID.ToString();
                    lbFN.Text = patient.FirstName;
                    lbLN.Text = patient.LastName;
                    lbNIC.Text = patient.Nic;
                    lbDOB.Text = patient.DateOfBirth.getDate();
                    lbG.Text = patient.Gender;
                    lbCN.Text = patient.ContactNo;
                }
                else
                {
                    lbPID.Text = "-";
                    lbFN.Text = "-";
                    lbLN.Text = "-";
                    lbNIC.Text = "-";
                    lbDOB.Text = "-";
                    lbG.Text = "-";
                    lbCN.Text = "-";
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                lbPID.Text = "-";
                lbFN.Text = "-";
                lbLN.Text = "-";
                lbNIC.Text = "-";
                lbDOB.Text = "-";
                lbG.Text = "-";
                lbCN.Text = "-";
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            new AddPatient().ShowDialog();
        }
    }
}
