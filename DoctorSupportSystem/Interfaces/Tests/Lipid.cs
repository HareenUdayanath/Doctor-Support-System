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
    public partial class Lipid : Form
    {
        public Lipid()
        {
            InitializeComponent();
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            LipidTest test = new LipidTest();
            test.Pid = 1;
            test.Date = new Date(this.dateTimePicker1.Value);
            test.CholesterolTotal = (float)Convert.ToDecimal(this.txtCholesterolTot.Text);
            test.Triglycerides = (float)Convert.ToDecimal(this.txtTriglyceride.Text);
            test.CholesterolHDL = (float)Convert.ToDecimal(this.txtCholesterolHDL.Text);
            test.CholesterolLDL = (float)Convert.ToDecimal(this.txtCholesterolLDL.Text);
            test.CholesterolVLDL = (float)Convert.ToDecimal(this.txtCholesterolVLDL.Text);
            test.Chol_hdl = (float)Convert.ToDecimal(this.txtCHOL.Text);
            test.Ldl_hdl = (float)Convert.ToDecimal(this.txtLDL.Text);

            if (DataBaseOperator.GetInstance().addLipidTest(test) != 1)
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
