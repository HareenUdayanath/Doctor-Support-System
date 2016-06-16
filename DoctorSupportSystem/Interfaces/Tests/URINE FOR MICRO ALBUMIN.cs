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
    public partial class URINE_FOR_MICRO_ALBUMIN : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        private int pid;

        public URINE_FOR_MICRO_ALBUMIN(int pid)
        {
            this.pid = pid;
            InitializeComponent();
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            UrineTest test = new UrineTest();
            string err = "";
            test.Pid = pid;
            test.Date = new Date(this.dateTimePicker1.Value);


            if (!Validator.numberCheck(txtUrineMA.Text))
                err += "Urine for Micro Albumin should be a number \n";
            else
                test.Urine_MA = (float)Convert.ToDecimal(txtUrineMA.Text);

            if (!Validator.numberCheck(txtUrineC.Text))
                err += "Urine Creatinine should be a number \n";
            else
                test.Urine_C = (float)Convert.ToDecimal(txtUrineC.Text);

            if (!Validator.numberCheck(txtUrineAC.Text))
                err += "Urine Albumin/Creatinine should be a number \n";
            else
                test.Urine_AC = (float)Convert.ToDecimal(txtUrineAC.Text);

            if (err != "")
            {
                MBOX.Show(err);
            }
            else
            {
                if (DataBaseOperator.GetInstance().addUrineTest(test) != 1)
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

        private void URINE_FOR_MICRO_ALBUMIN_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
    }
}
