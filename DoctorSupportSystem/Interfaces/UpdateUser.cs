using DoctorSupportSystem.DataBase;
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
    public partial class UpdateUser : Form
    {

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
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
               
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string oldNic = user.Nic;
            user.Fullname = txtFullName.Text;            
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
                MBOX.Show(err);
            }
            else
            {
                if (db.updateUser(user,oldNic) == -1)
                {
                    MBOX.Show("Duplicate NIC:\n"
                        + "This NIC already exist in the database");
                }
                else
                {
                    MBOX.Show("The user profile successfully updated");
                    if(user.Position.Equals("Doctor"))
                        ((DoctorInterface)this.Owner).changeUser(user);
                    if (user.Position.Equals("Assistance"))
                        ((AssistanceInterface)this.Owner).changeUser(user);
                    if (user.Position.Equals("Lab Assistance"))
                        ((LabAssistanceInterface)this.Owner).changeUser(user);
                    this.Close();
                }
            }
        }

        private void btnChangeUP_Click(object sender, EventArgs e)
        {
            new ChangeUP(UpdateUser.user).ShowDialog();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void UpdateUser_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
