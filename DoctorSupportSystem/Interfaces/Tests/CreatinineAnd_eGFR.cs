using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoctorSupportSystem.Models.Test;
using DoctorSupportSystem.Models;
using DoctorSupportSystem.DataBase;
using DoctorSupportSystem.Help;

namespace DoctorSupportSystem.Interfaces.Tests
{
    public partial class CreatinineAnd_eGFR : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        private int pid;
        public CreatinineAnd_eGFR(int pid)
        {
            this.pid = pid;
            InitializeComponent();
        }

        private void btnAddResults_Click(object sender, EventArgs e)
        {

            CreatinineTest test = new CreatinineTest();
            string err = "";
            test.Pid = pid;
            test.Date = new Date(this.dateTimePicker1.Value);

            if (!Validator.numberRangeCheck(txtSerum.Text, 0.8, 1.3))
                err += "Serum Creatinint should be a number between 0.8-1.3\n";
            else
                test.SerumCreatinint = (float)Convert.ToDecimal(txtSerum.Text);

            if (!Validator.numberCheck(txtGFR.Text))
                err += "estimated GFR should be a number \n";
            else
                test.Gfr = (float)Convert.ToDecimal(txtGFR.Text);



            if (err != "")
            {
                MessageBox.Show(err);
            }
            else
            {
                if (DataBaseOperator.GetInstance().addCreatinineTest(test) != 1)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    MessageBox.Show("Test is added successfully");
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

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void CreatinineAnd_eGFR_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
