using DoctorSupportSystem.DataBase;
using DoctorSupportSystem.Interfaces.Reports;
using DoctorSupportSystem.Interfaces.Tests;
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

namespace DoctorSupportSystem.Interfaces
{
    public partial class DoctorInterface : Form
    {
        Patient patient;
        int selectedPID;
        public DoctorInterface()
        {
            InitializeComponent();
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            col.AddRange(DataBaseOperator.GetInstance().getPatientNameList());
            cbSearchPatients.AutoCompleteCustomSource = col;
            dataGridView1.DataSource = DataBaseOperator.GetInstance().getAllUsers();
            dataGridView2.DataSource = DataBaseOperator.GetInstance().getAllPatients();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Add_User().ShowDialog();
        }

        private void btnLoadPatients_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = DataBaseOperator.GetInstance().getAllPatients();
        }

        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBaseOperator.GetInstance().getAllUsers();
        }

      


        private void btnAddTest_Click_1(object sender, EventArgs e)
        {
            if (this.rbtnCreatinineTest.Checked)
            {
                if (patient != null)
                    new CreatinineAnd_eGFR(patient.PID).ShowDialog();
                else
                    MessageBox.Show("Select the Patient");
            }
            else if (this.rbtnHaemoglobinTest.Checked)
            {
                if (patient != null)
                    new Haemoglobin(patient.PID).ShowDialog();
                else
                    MessageBox.Show("Select the Patient");

            }
            else if (this.rbtnLipidTest.Checked)
            {
                if (patient != null)
                    new Lipid(patient.PID).ShowDialog();
                else
                    MessageBox.Show("Select the Patient");

            }
            else if (this.rbtnPrfileLiverTest.Checked)
            {
                if (patient != null)
                    new ProfileLiver(patient.PID).ShowDialog();
                else
                    MessageBox.Show("Select the Patient");

            }
            else if (this.rbtnUrineTest.Checked)
            {
                if (patient != null)
                    new URINE_FOR_MICRO_ALBUMIN(patient.PID).ShowDialog();
                else
                    MessageBox.Show("Select the Patient");

            }
        }

        private void cbSearchPatients_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string nic = cbSearchPatients.Text.Split('-')[1];
                Console.WriteLine(nic);
                patient = DataBaseOperator.GetInstance().getPatientByNIC(nic);
                if (patient != null)
                {
                    lbPID.Text = patient.PID.ToString();
                    lbFN.Text = patient.FirstName;
                    lbLN.Text = patient.LastName;
                    lbNIC.Text = patient.Nic;
                    lbDOB.Text = patient.DateOfBirth.getDate();
                    lbG.Text = patient.Gender;
                    lbCN.Text = patient.ContactNo;
                }
                else
                {
                    lbPID.Text = "-";
                    lbFN.Text = "-";
                    lbLN.Text = "-";
                    lbNIC.Text = "-";
                    lbDOB.Text = "-";
                    lbG.Text = "-";
                    lbCN.Text = "-";
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                patient = null;
                lbPID.Text = "-";
                lbFN.Text = "-";
                lbLN.Text = "-";
                lbNIC.Text = "-";
                lbDOB.Text = "-";
                lbG.Text = "-";
                lbCN.Text = "-";
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            new AddPatient().ShowDialog();
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                var hti = dataGridView2.HitTest(e.X, e.Y);
                dataGridView2.ClearSelection();
                dataGridView2.Rows[hti.RowIndex].Selected = true;                  
                
                ContextMenu m = new ContextMenu();                   

                int currentMouseOverRow = dataGridView2.HitTest(e.X, e.Y).RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[currentMouseOverRow];
                selectedPID = Convert.ToInt32(selectedRow.Cells["PID"].Value);

                MenuItem mi1 = new MenuItem(string.Format("Show Creatinine And eGFR Test Results", currentMouseOverRow.ToString()));
                mi1.Click += new EventHandler(getCreatinineAnd_eGFR_Results);
                m.MenuItems.Add(mi1);

                MenuItem mi2 = new MenuItem(string.Format("Show Heamoglobin Test Results", currentMouseOverRow.ToString()));
                mi2.Click += new EventHandler(getHeamoglobinResults);
                m.MenuItems.Add(mi2);
                
                MenuItem mi3 = new MenuItem(string.Format("Show Lipid Test Results", currentMouseOverRow.ToString()));
                mi3.Click += new EventHandler(getLipidResults);
                m.MenuItems.Add(mi3);

                MenuItem mi4 = new MenuItem(string.Format("Show ProfileLiver Test Results", currentMouseOverRow.ToString()));
                mi4.Click += new EventHandler(getProfileLiverResults);
                m.MenuItems.Add(mi4);

                MenuItem mi5 = new MenuItem(string.Format("Show Urine Test Results", currentMouseOverRow.ToString()));
                mi5.Click += new EventHandler(getUrineResults);
                m.MenuItems.Add(mi5);

                /*if (currentMouseOverRow >= 0)
                {
                    MenuItem mi = new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString()));
                    mi.Click += new EventHandler(mnuCopy_Click);
                    m.MenuItems.Add(mi);
                }*/

                m.Show(dataGridView2, new Point(e.X, e.Y));
              
            }
        }

        private void getUrineResults(object sender, EventArgs e)
        {
            new UrineResults(selectedPID).ShowDialog();
        }

        private void getProfileLiverResults(object sender, EventArgs e)
        {
            new ProfileLiverResults(selectedPID).ShowDialog();
        }

        private void getLipidResults(object sender, EventArgs e)
        {
            new LipidResults(selectedPID).ShowDialog();
        }

        private void getHeamoglobinResults(object sender, EventArgs e)
        {
            new HeamoglobinResults(selectedPID).ShowDialog();
        }

        private void getCreatinineAnd_eGFR_Results(object sender, EventArgs e)
        {
            new CreatinineAnd_eGFR_Results(selectedPID).ShowDialog();
        }

    }
}
