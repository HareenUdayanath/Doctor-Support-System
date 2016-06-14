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
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ChangeUP_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
