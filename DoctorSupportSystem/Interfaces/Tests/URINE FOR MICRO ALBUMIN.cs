using DoctorSupportSystem.DataBase;
using DoctorSupportSystem.Help;
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

        private int pid;

        public URINE_FOR_MICRO_ALBUMIN(int pid)
        {
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
                MessageBox.Show(err);
            }
            else
            {
                if (DataBaseOperator.GetInstance().addUrineTest(test) != 1)
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
    }
}
