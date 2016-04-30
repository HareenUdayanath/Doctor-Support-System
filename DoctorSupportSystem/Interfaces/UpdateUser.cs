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
    public partial class UpdateUser : Form
    {

        public static User user = null;
        DataBaseOperator db = DataBaseOperator.GetInstance();

        public UpdateUser(User user)
        {
            UpdateUser.user = user;
            InitializeComponent();
            setUser();
        }

        private void setUser()
        {
            this.txtFullName.Text = user.Fullname;
            this.txtNIC.Text = user.Nic;
            this.txtCoNo.Text = user.ContactNo;
            this.comboBoxGender.Text = user.Gender;
            this.comboboxPosition.Text = user.Position;
               
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string oldNic = user.Nic;
            user.Fullname = txtFullName.Text;
            user.Position = comboboxPosition.SelectedItem.ToString();
            user.Gender = comboBoxGender.SelectedItem.ToString();

            String err = "";           
          
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
                if (db.updateUser(user,oldNic) == -1)
                {
                    MessageBox.Show("Duplicate NIC:\n"
                        + "This NIC already exist in the database");
                }
                else
                {
                    MessageBox.Show("The user profile successfully updated");
                    //new Add_User().Show();
                    this.Close();
                }
            }
        }

        private void btnChangeUP_Click(object sender, EventArgs e)
        {
            new ChangeUP(UpdateUser.user).ShowDialog();
        }
    }
}
