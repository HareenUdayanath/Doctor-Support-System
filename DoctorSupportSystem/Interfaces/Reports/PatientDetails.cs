using DoctorSupportSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorSupportSystem.Interfaces.Reports
{
    public partial class PatientDetails : Form
    {
        private Patient patient;

        public PatientDetails(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            lbPID.Text = patient.PID.ToString();
            lbFN.Text = patient.FirstName;
            lbLN.Text = patient.LastName;
            lbNIC.Text = patient.Nic;
            lbDOB.Text = patient.DateOfBirth.getDate();
            lbG.Text = patient.Gender;
            lbCN.Text = patient.ContactNo;
        }
    }
}
