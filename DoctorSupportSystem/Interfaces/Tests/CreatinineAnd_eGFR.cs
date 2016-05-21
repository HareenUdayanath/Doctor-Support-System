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

namespace DoctorSupportSystem.Interfaces.Tests
{
    public partial class CreatinineAnd_eGFR : Form
    {
        public CreatinineAnd_eGFR()
        {
            InitializeComponent();
        }

        private void btnAddResults_Click(object sender, EventArgs e)
        {

            CreatinineTest test = new CreatinineTest();
            test.Pid = 1;
            test.Date = new Date(this.dateTimePicker1.Value);
            test.SerumCreatinint = (float)Convert.ToDecimal(this.txtSerum.Text);
            Console.WriteLine(test.SerumCreatinint);
            test.Gfr = (float)Convert.ToDecimal(this.txtGFR.Text);

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
