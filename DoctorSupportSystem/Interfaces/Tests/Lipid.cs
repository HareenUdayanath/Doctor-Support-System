using DoctorSupportSystem.DataBase;
using DoctorSupportSystem.Help;
using DoctorSupportSystem.Interfaces.Other;
using DoctorSupportSystem.Models;
using DoctorSupportSystem.Models.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorSupportSystem.Interfaces.Tests
{
    public partial class Lipid : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        private int pid;
        public Lipid(int pid)
        {
            this.pid = pid;
            InitializeComponent();
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            LipidTest test = new LipidTest();
            string err = "";
            test.Pid = pid;
            test.Date = new Date(this.dateTimePicker1.Value);
            
            if (!Validator.numberRangeCheck(txtCholesterolTot.Text,140,239))
                err += "Cholesterol Total should be a number between 140.0-239.0\n";
            else
                test.CholesterolTotal = (float)Convert.ToDecimal(txtCholesterolTot.Text);

            if (!Validator.numberRangeCheck(txtTriglyceride.Text, 10, 200))
                err += "Triglyceride should be a number between 10.0-200.0\n";
            else
                test.Triglycerides = (float)Convert.ToDecimal(txtTriglyceride.Text);

            if (!Validator.numberRangeCheck(txtCholesterolHDL.Text, 35, 85))
                err += "Cholesterol H.D.L. should be a number between 35.0-85.0\n";
            else
                test.CholesterolHDL = (float)Convert.ToDecimal(txtCholesterolHDL.Text);

            if (!Validator.numberRangeCheck(txtCholesterolLDL.Text, 75, 159))
                err += "txtCholesterol L.D.L. should be a number between 75.0-159.0\n";
            else
                test.CholesterolLDL = (float)Convert.ToDecimal(txtCholesterolLDL.Text);

            if (!Validator.numberRangeCheck(txtCholesterolVLDL.Text, 10, 41))
                err += "Cholesterol VLDL should be a number between 10.0-41.0\n";
            else
                test.CholesterolVLDL = (float)Convert.ToDecimal(txtCholesterolVLDL.Text);

            if (!Validator.numberRangeCheck(txtCHOL.Text, 2, 5))
                err += "CHOL/HDL should be a number between 2.0-5.0\n";
            else
                test.Chol_hdl = (float)Convert.ToDecimal(txtCHOL.Text);

            if (!Validator.numberRangeCheck(txtLDL.Text, 0, 3.3))
                err += "LDL/HDL should be a number between 0.0-3.3\n";
            else
                test.Ldl_hdl = (float)Convert.ToDecimal(txtLDL.Text);

            if (err != "")
            {
                MBOX.Show(err);
            }
            else
            {
                if (DataBaseOperator.GetInstance().addLipidTest(test) != 1)
                {
                    MBOX.Show("Error");
                }
                else
                {
                    MBOX.Show("Test is added successfully");
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

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Lipid_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
