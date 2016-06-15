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
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
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

                int re = db.addUser(user);
                if (re == -1)
                {
                    MessageBox.Show("Duplicate NIC:\n"
                        + "This NIC already exist in the database");
                }
                else if (re == -4)
                {
                    MessageBox.Show("Duplicate Username:\n"
                        + "This Username already exist in the database");
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

        private void Add_User_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
