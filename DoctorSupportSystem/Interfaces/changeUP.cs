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

namespace DoctorSupportSystem.Interfaces
{
    public partial class ChangeUP : Form
    {

        User user = null;

        public ChangeUP(User user)
        {
            InitializeComponent();
            this.user = user;
            this.txtUserName.Text = user.Username;
        }

        private void btnChangeUP_Click(object sender, EventArgs e)
        {
           
            if (txtNewCPW.Text != txtNewPW.Text)
            {
                MessageBox.Show("Confirm Password Does not match");                
            }
            else
            {
                User ckUser = DataBaseOperator.GetInstance().updateUserNamePassword(this.user,txtPassword.Text,txtNewUN.Text, txtNewPW.Text);
                if (ckUser == null)
                {
                    MessageBox.Show("Incorrect Password");
                }
                else
                {
                    this.user = ckUser;
                    UpdateUser.user = ckUser;
                    MessageBox.Show("Update is successfull");
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
