﻿using DoctorSupportSystem.DataBase;
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
        DataTable patients;
        DataTable appoinments;


        public AssistanceInterface()
        {
            InitializeComponent();

            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            col.AddRange(DataBaseOperator.GetInstance().getPatientNameList());
            cbSearchPatients.AutoCompleteCustomSource = col;
            patients = DataBaseOperator.GetInstance().getAllPatients();
            dgvPatients.DataSource = patients;
            dgvApplintments.DataSource = DataBaseOperator.GetInstance().getAllAppointments();
            appoinments = DataBaseOperator.GetInstance().getAllAppointments();
            dgvApplintments.DataSource = appoinments;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            appoinments = DataBaseOperator.GetInstance().getAllAppointments();
            dgvApplintments.DataSource = appoinments;
        }

        private void btnLoadPatients_Click(object sender, EventArgs e)
        {
            patients = DataBaseOperator.GetInstance().getAllPatients();
            dgvPatients.DataSource = patients;
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            new AddAppointment().ShowDialog();
            dgvApplintments.DataSource = DataBaseOperator.GetInstance().getAllAppointments();
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {

            if (this.rbtnCreatinineTest.Checked)
            {
                if (patient != null)
                    new CreatinineAnd_eGFR(patient.PID).ShowDialog();
                else
                    MessageBox.Show("Select the Patient");
            }
            else if (this.rbtnHaemoglobinTest.Checked)
            {
                if (patient != null)
                    new Haemoglobin(patient.PID).ShowDialog();
                else
                    MessageBox.Show("Select the Patient");

            }
            else if (this.rbtnLipidTest.Checked)
            {
                if (patient != null)
                    new Lipid(patient.PID).ShowDialog();
                else
                    MessageBox.Show("Select the Patient");

            }
            else if (this.rbtnPrfileLiverTest.Checked)
            {
                if (patient != null)
                    new ProfileLiver(patient.PID).ShowDialog();
                else
                    MessageBox.Show("Select the Patient");

            }
            else if (this.rbtnUrineTest.Checked)
            {
                if (patient != null)
                    new URINE_FOR_MICRO_ALBUMIN(patient.PID).ShowDialog();
                else
                    MessageBox.Show("Select the Patient");

            }
            else if (lbPID.Text.Equals("-"))
            {
                MessageBox.Show("Select the Patient");
            }
            else
            {
                MessageBox.Show("Select the Test");
            }
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

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            new AddPatient().ShowDialog();
        }

        private void txtSearchPatients_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = new DataView(patients);
            dataView.RowFilter = string.Format("Name Like '%{0}%'", txtSearchPatients.Text);
            dgvPatients.DataSource = dataView;
        }

        private void dtpAppoinmentDates_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dataView = new DataView(appoinments);
                dataView.RowFilter = string.Format("[Date] = #{0}#", dtpAppoinmentDates.Value.ToString("MM/dd/yyyy"));
                dgvApplintments.DataSource = dataView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnCurrentAppointments_Click(object sender, EventArgs e)
        {
            appoinments = DataBaseOperator.GetInstance().getAllCurrentAppointments();
            dgvApplintments.DataSource = appoinments;
        }

        private void btnDeletePast_Click(object sender, EventArgs e)
        {
            DataBaseOperator.GetInstance().deletePreviousAppointment();
            appoinments = DataBaseOperator.GetInstance().getAllCurrentAppointments();
            dgvApplintments.DataSource = appoinments;
        }
    }
}
