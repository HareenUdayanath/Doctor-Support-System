﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoctorSupportSystem.DataBase;
using DoctorSupportSystem.Models;
using DoctorSupportSystem.Help;
using DoctorSupportSystem.Interfaces.Other;

namespace DoctorSupportSystem.Interfaces
{
    public partial class AddPatient : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        DataBaseOperator db = DataBaseOperator.GetInstance();
        public AddPatient()
        {
            InitializeComponent();
            txtPID.Text = Convert.ToString(db.getMaxPID() + 1);
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtYear.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                txtYear.Text = txtYear.Text.Remove(txtYear.Text.Length - 1);
            }
        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMonth.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                txtMonth.Text = txtMonth.Text.Remove(txtMonth.Text.Length - 1);
            }
        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDay.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                txtDay.Text = txtDay.Text.Remove(txtDay.Text.Length - 1);
            }
        }

        private void btnAddPatient_Click_1(object sender, EventArgs e)
        {

            Patient patient = new Patient();
            int year = Int32.Parse(txtYear.Text);
            int month = Int32.Parse(txtMonth.Text);
            int day = Int32.Parse(txtDay.Text);
            patient.DateOfBirth = new Date(year, month, day);

            String err = "";
           
            if (txtFName.Text == "")
                err += "First Name required\n";
            if (cbGender.SelectedItem == null)
                err += "Select the gender\n";
            if (cbBloodType.SelectedItem == null)
                err += "Select the blood type\n";
            if (txtLName.Text == "")
                err += "Last Name required\n";
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
                
                patient.FirstName = txtFName.Text;
                patient.LastName = txtLName.Text;
               
                patient.Address = txtAddress.Text;
                
                patient.Gender = cbGender.SelectedItem.ToString();
                patient.BloodType = cbBloodType.SelectedItem.ToString();
                int re = db.addPatient(patient) ;
                
                if (re == -1)
                {
                    MBOX.Show("Duplicate NIC:\n"
                        + "This NIC already exist in the database");
                }
                else if(re == 1)
                {
                    MBOX.Show("The patient successfully added to the database");                    
                    this.Close();
                }

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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void AddPatient_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
