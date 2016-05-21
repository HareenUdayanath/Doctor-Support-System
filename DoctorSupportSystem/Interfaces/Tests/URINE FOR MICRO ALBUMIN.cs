using DoctorSupportSystem.DataBase;
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
        public URINE_FOR_MICRO_ALBUMIN()
        {
            InitializeComponent();
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            UrineTest test = new UrineTest();
            test.Pid = 1;
            test.Date = new Date(this.dateTimePicker1.Value);
            test.Urine_MA = (float)Convert.ToDecimal(this.txtUrineMA.Text);
            test.Urine_C = (float)Convert.ToDecimal(this.txtUrineC.Text);
            test.Urine_AC = (float)Convert.ToDecimal(this.txtUrineAC.Text);
            

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
