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
    public partial class ProfileLiver : Form
    {
        public ProfileLiver()
        {
            InitializeComponent();
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            ProfileLiverTest test = new ProfileLiverTest();
            test.Pid = 1;
            test.Date = new Date(this.dateTimePicker1.Value);
            test.TotalProtein = (float)Convert.ToDecimal(this.txtTotalProtein.Text);
            test.Albumin = (float)Convert.ToDecimal(this.txtAlbumin.Text);
            test.Globumin = (float)Convert.ToDecimal(this.txtGlobumin.Text);
            test.Ag_Ratio = (float)Convert.ToDecimal(this.txtAG_Ratio.Text);
            test.BilirubinTotal = (float)Convert.ToDecimal(this.txtBilirubin.Text);
            test.AlkPhosphatase = (float)Convert.ToDecimal(this.txtALK_Phosphatase.Text);
            test.Alt = (float)Convert.ToDecimal(this.txtALT.Text);
            test.Ast = (float)Convert.ToDecimal(this.txtAST.Text);
            test.Gamma = (float)Convert.ToDecimal(this.txtGamma.Text);
          

            if (DataBaseOperator.GetInstance().addProfileLiverTest(test) != 1)
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
