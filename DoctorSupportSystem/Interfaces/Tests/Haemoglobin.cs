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
    public partial class Haemoglobin : Form
    {
        public Haemoglobin()
        {
            InitializeComponent();
        }


        private void btnAddResults_Click(object sender, EventArgs e)
        {
            HaemoglobinTest test = new HaemoglobinTest();
            test.Pid = 1;
            test.Date = new Date(this.dateTimePicker1.Value);
            test.Results = (float)Convert.ToDecimal(this.txtResult.Text);


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
