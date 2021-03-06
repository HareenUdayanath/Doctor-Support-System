﻿using DoctorSupportSystem.DataBase;
using DoctorSupportSystem.Help;
using DoctorSupportSystem.Interfaces.Other;
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
    public partial class UpdatePatient : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        DataBaseOperator db = DataBaseOperator.GetInstance();

        private Patient patient;
        
        public UpdatePatient(Patient patient)
        {

            this.patient = patient;
            InitializeComponent();
            setPatient();
        }

        private void setPatient()
        {
            txtPID.Text = patient.PID.ToString();
            txtFName.Text = patient.FirstName;
            txtLName.Text = patient.LastName;
            txtAddress.Text = patient.Address;
            txtYear.Text = patient.DateOfBirth.getYear().ToString();
            txtMonth.Text = patient.DateOfBirth.getMonth().ToString();
            txtDay.Text = patient.DateOfBirth.getDay().ToString();
            txtNIC.Text = patient.Nic;
            cbGender.Text = patient.Gender;
            cbBloodType.Text = patient.BloodType;
            txtCoNo.Text = patient.ContactNo;
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            int year = Int32.Parse(txtYear.Text);
            int month = Int32.Parse(txtMonth.Text);
            int day = Int32.Parse(txtDay.Text);

            patient.DateOfBirth = new Date(year, month, day);
            String err = "";

            if (txtFName.Text == "")
                err += "First Name required\n";
            if (txtLName.Text == "")
                err += "Last Name required\n";
            if (cbGender.SelectedItem == null)
                err += "Select the gender\n";
            if (cbBloodType.SelectedItem == null)
                err += "Select the blood type\n";
            if (!Validator.isValidDateOfBirth(patient.DateOfBirth))
                err += "Invalid Date of Birth\n";
            if (!Validator.nic(txtNIC.Text))
                err += "Invalid NIC\n";
            else
                patient.Nic = txtNIC.Text;

            if (!Validator.contactNumber(txtCoNo.Text))
                err += "Invalid Contact Number\n";
            else
                patient.ContactNo = txtCoNo.Text;

            Console.WriteLine(err);

            if (err != "")
            {
                MBOX.Show(err);
            }
            else
            {
                patient.PID = Convert.ToInt32(txtPID.Text);
                patient.FirstName = txtFName.Text;
                patient.LastName = txtLName.Text;
              

                patient.Address = txtAddress.Text;

                patient.Gender = cbGender.SelectedItem.ToString();
                patient.BloodType = cbBloodType.SelectedItem.ToString();
                int re = db.updatePatient(patient);
                if (re == -1)
                {
                    MBOX.Show("Duplicate NIC:\n"
                        + "This NIC already exist in the database");
                }
                else if (re == 1)
                {
                    MBOX.Show("The patient successfully updated to the database");                    
                    this.Close();
                }

            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UpdatePatient_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
