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
using DoctorSupportSystem.Interfaces.Other;

namespace DoctorSupportSystem.Interfaces
{
    public partial class Login : Form
    {
        DataBaseOperator db = DataBaseOperator.GetInstance();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = db.getUser(txtUserName.Text,txtPassWord.Text);
            if (user != null)
            {
                Form userForm = UserFactory.getUserInterface(user);
                userForm.Show();               
                this.Close();
            }
            else
            {
                if(DataBaseOperator.isconnectionError)
                    CustomMessageBox.Show("Could not connect to the database\nCheck your database connection");
                else
                    CustomMessageBox.Show("Invalid Username or Password");
                this.txtPassWord.Text = "";
                this.txtUserName.Text = "";
                this.txtUserName.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
