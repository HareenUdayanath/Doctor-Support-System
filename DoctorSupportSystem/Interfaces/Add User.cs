using DoctorSupportSystem.DataBase;
using DoctorSupportSystem.Help;
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
    public partial class Add_User : Form
    {

        DataBaseOperator db = DataBaseOperator.GetInstance();

        public Add_User()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User user = new User();
           

            String err = "";

            if (txtUserName.Text == "")
                err += "User Name required\n";
            if (txtPassword.Text == "")
                err += "Password required\n";            
            if (txtCPassword.Text == "")
                err += "Confirm Password required\n";
            if (txtPassword.Text != "" && txtCPassword.Text != ""
                && txtCPassword.Text != txtPassword.Text)
                err += "Confirm Password Does not match\n";
            else
                user.Password = txtPassword.Text;
            if (!Validator.nic(txtNIC.Text))
                err += "Invalid NIC\n";
            else
                user.Nic = txtNIC.Text;
            if (!Validator.contactNumber(txtCoNo.Text))
                err += "Invalid Contact Number\n";
            else
                user.ContactNo = txtCoNo.Text;

            if (err != "")
            {
                MessageBox.Show(err);
            }
            else
            {
                user.Fullname = txtFullName.Text;
                user.Position = comboboxPosition.SelectedItem.ToString();
                user.Gender = comboBoxGender.SelectedItem.ToString();
                user.Username = txtUserName.Text;
                if (db.addUser(user) == -1)
                {
                    MessageBox.Show("Duplicate NIC:\n"
                        + "This NIC already exist in the database");
                }
                else
                {
                    MessageBox.Show("The user successfully added to the database");                    
                    this.Close();
                }
            }
               
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCoNo.Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                txtCoNo.Text = txtCoNo.Text.Remove(txtCoNo.Text.Length - 1);
            }
        }
    }
}
