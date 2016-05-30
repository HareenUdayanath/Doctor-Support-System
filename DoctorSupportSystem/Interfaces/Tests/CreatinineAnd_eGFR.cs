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
    }
}
