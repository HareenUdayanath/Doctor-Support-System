﻿using DoctorSupportSystem.DataBase;
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
    public partial class ProfileLiver : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        private int pid;
        
        public ProfileLiver(int pid)
        {
            this.pid = pid;
            InitializeComponent();
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            ProfileLiverTest test = new ProfileLiverTest();
            string err = "";
            test.Pid = pid;
            test.Date = new Date(dateTimePicker1.Value);

            if (!Validator.numberRangeCheck(txtTotalProtein.Text, 60, 83))
                err += "Total Protein should be a number between 60.0-83.0\n";
            else
                test.TotalProtein = (float)Convert.ToDecimal(txtTotalProtein.Text);

            if (!Validator.numberRangeCheck(txtAlbumin.Text, 35, 50))
                err += "Albumin should be a number between 35.0-50.0\n";
            else
                test.Albumin = (float)Convert.ToDecimal(txtAlbumin.Text);

            if (!Validator.numberRangeCheck(txtGlobumin.Text, 25, 33))
                err += "Globumin should be a number between 25.0-33.0\n";
            else
                test.Globumin = (float)Convert.ToDecimal(txtGlobumin.Text);

            if (!Validator.numberRangeCheck(txtAG_Ratio.Text, 3, 2.3))
                err += "A/G Ratio should be a number between 3.0-2.3\n";
            else
                test.Ag_Ratio = (float)Convert.ToDecimal(txtAG_Ratio.Text);

            if (!Validator.numberRangeCheck(txtBilirubin.Text, 0.1, 1.2))
                err += "Bilirubin total should be a number between 0.1-1.2\n";
            else
                test.BilirubinTotal = (float)Convert.ToDecimal(txtBilirubin.Text);

            if (!Validator.numberRangeCheck(txtALK_Phosphatase.Text, 98, 258))
                err += "ALK. Phosphatase should be a number between 98.0-258.0\n";
            else
                test.AlkPhosphatase = (float)Convert.ToDecimal(txtALK_Phosphatase.Text);

            if (!Validator.numberRangeCheck(txtALT.Text, 0.1, 40))
                err += "ALT (S.G.P.T.) should be a number between 0.1-40.0\n";
            else
                test.Alt = (float)Convert.ToDecimal(txtALT.Text);

            if (!Validator.numberRangeCheck(txtAST.Text, 0.1, 40))
                err += "AST (S.G.O.T.) should be a number between 0.1-40.0\n";
            else
                test.Ast = (float)Convert.ToDecimal(txtAST.Text);

            if (!Validator.numberRangeCheck(txtGamma.Text, 0.1, 49))
                err += "Gamma-GT should be a number between 0.1-49.0\n";
            else
                test.Gamma = (float)Convert.ToDecimal(txtGamma.Text);


            if (err != "")
            {
                MBOX.Show(err);
            }
            else
            {
                if (DataBaseOperator.GetInstance().addProfileLiverTest(test) != 1)
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

        private void ProfileLiver_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void panel12_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel12_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel12_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
    }
}
