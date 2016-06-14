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
    public partial class PatientDeseaseRecord : Form
    {
        private Patient patient;
        public PatientDeseaseRecord()
        {
            InitializeComponent();
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            col.AddRange(DataBaseOperator.GetInstance().getPatientNameList());
            cbSearchPatients.AutoCompleteCustomSource = col;
        }

        public PatientDeseaseRecord(Patient patient)
        {
            InitializeComponent();

            this.patient = patient;
            this.cbSearchPatients.Hide();
            this.lbSelectPatient.Text = "Patient Details";

            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            col.AddRange(DataBaseOperator.GetInstance().getPatientNameList());
            cbSearchPatients.AutoCompleteCustomSource = col;

            lbPID.Text = patient.PID.ToString();
            lbFN.Text = patient.FirstName;
            lbLN.Text = patient.LastName;
            lbNIC.Text = patient.Nic;
            lbDOB.Text = patient.DateOfBirth.getDate();
            lbG.Text = patient.Gender;
            lbBlood.Text = patient.BloodType;
            lbCN.Text = patient.ContactNo;

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
                    lbBlood.Text = patient.BloodType;
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
            catch (IndexOutOfRangeException)
            {
                patient = null;
                lbPID.Text = "-";
                lbFN.Text = "-";
                lbLN.Text = "-";
                lbNIC.Text = "-";
                lbDOB.Text = "-";
                lbG.Text = "-";
                lbCN.Text = "-";
            }
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            DeseaseReport dr = new DeseaseReport();

            string err = "";


            if (lbPID.Text == "-")
                err += "Select a patient\n";

            if (txtDesease.Text == "")
                err += "Desease required\n";


            if (err != "")
            {
                MessageBox.Show(err);
            }
            else
            {
                dr.Desease = txtDesease.Text;
                dr.Pid = Convert.ToInt32(lbPID.Text);
                if (DataBaseOperator.GetInstance().addDeseaseReport(dr) == 1)
                {
                    MessageBox.Show("The desease report successfully added to the database");  
                                      
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong....");
                   
                }
            }

        }

        private void txtDesease_TextChanged(object sender, EventArgs e)
        {

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
