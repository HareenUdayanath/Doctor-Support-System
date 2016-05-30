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
                //Form userForm = UserFactory.getUserInterface(user);
                //userForm.Show();
                new UpdateUser(user).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                this.txtPassWord.Text = "";
                this.txtUserName.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
