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
    public partial class Haemoglobin : Form
    {

        private int pid;
        public Haemoglobin(int pid)
        {
            this.pid = pid;
            InitializeComponent();
        }


        private void btnAddResults_Click(object sender, EventArgs e)
        {
            HaemoglobinTest test = new HaemoglobinTest();
            string err = "";
            test.Pid = pid;
            test.Date = new Date(this.dateTimePicker1.Value);

            if (!Validator.numberCheck(txtResult.Text))
                err += "estimated GFR should be a number \n";
            else
                test.Results = (float)Convert.ToDecimal(txtResult.Text);


            if (err != "")
            {
                MessageBox.Show(err);
            }
            else
            {
                if (DataBaseOperator.GetInstance().addHaemoglobinTest(test) != 1)
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
