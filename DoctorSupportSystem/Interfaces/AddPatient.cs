using System;
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


namespace DoctorSupportSystem.Interfaces
{
    public partial class AddPatient : Form
    {
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
            if (comboBoxGender.SelectedItem == null)
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
                MessageBox.Show(err);
            }
            else
            {
                
                patient.FirstName = txtFName.Text;
                patient.LastName = txtLName.Text;
               
                patient.Address = txtAddress.Text;
                
                patient.Gender = comboBoxGender.SelectedItem.ToString();
                patient.BloodType = cbBloodType.SelectedItem.ToString();
                int re = db.addPatient(patient) ;
                
                if (re == -1)
                {
                    MessageBox.Show("Duplicate NIC:\n"
                        + "This NIC already exist in the database");
                }
                else if(re == 1)
                {
                    MessageBox.Show("The patient successfully added to the database");                    
                    this.Close();
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
