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

        DataTable users;
        DataTable patients;
        DataTable appoinments;

        public DoctorInterface()
        {
            InitializeComponent();
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            col.AddRange(DataBaseOperator.GetInstance().getPatientNameList());           
            txtSearchPatient.AutoCompleteCustomSource = col;

            users = DataBaseOperator.GetInstance().getAllUsers();
            dgvUsers.DataSource = users;
            patients = DataBaseOperator.GetInstance().getAllPatients();
            dgvPatients.DataSource = patients;
            appoinments = DataBaseOperator.GetInstance().getAllAppointments();
            dgvApplintments.DataSource = appoinments;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Add_User().ShowDialog();
            users = DataBaseOperator.GetInstance().getAllUsers();
            dgvUsers.DataSource = users;
        }

        private void btnLoadPatients_Click(object sender, EventArgs e)
        {
            patients = DataBaseOperator.GetInstance().getAllPatients();
            dgvPatients.DataSource = patients;
        }

        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            users = DataBaseOperator.GetInstance().getAllUsers();
            dgvUsers.DataSource = users;
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
            else if (lbPID.Text.Equals("-"))
            {
                MessageBox.Show("Select the Patient");
            }
            else
            {
                MessageBox.Show("Select the Test");
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            new AddPatient().ShowDialog();
            patients = DataBaseOperator.GetInstance().getAllPatients();
            dgvPatients.DataSource = patients;

        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                try {
                    var hti = dgvPatients.HitTest(e.X, e.Y);
                    dgvPatients.ClearSelection();
                    dgvPatients.Rows[hti.RowIndex].Selected = true;

                    ContextMenu m = new ContextMenu();

                    int currentMouseOverRow = dgvPatients.HitTest(e.X, e.Y).RowIndex;
                    DataGridViewRow selectedRow = dgvPatients.Rows[currentMouseOverRow];
                    selectedPID = Convert.ToInt32(selectedRow.Cells["PID"].Value);

                    MenuItem mi1 = new MenuItem("Show Creatinine And eGFR Test Results");
                    mi1.Click += new EventHandler(getCreatinineAnd_eGFR_Results);
                    m.MenuItems.Add(mi1);

                    MenuItem mi2 = new MenuItem("Show Heamoglobin Test Results");
                    mi2.Click += new EventHandler(getHeamoglobinResults);
                    m.MenuItems.Add(mi2);

                    MenuItem mi3 = new MenuItem("Show Lipid Test Results");
                    mi3.Click += new EventHandler(getLipidResults);
                    m.MenuItems.Add(mi3);

                    MenuItem mi4 = new MenuItem("Show ProfileLiver Test Results");
                    mi4.Click += new EventHandler(getProfileLiverResults);
                    m.MenuItems.Add(mi4);

                    MenuItem mi5 = new MenuItem("Show Urine Test Results");
                    mi5.Click += new EventHandler(getUrineResults);
                    m.MenuItems.Add(mi5);

                    MenuItem mi6 = new MenuItem("Show Profile");
                    mi6.Click += new EventHandler(getProfile);
                    m.MenuItems.Add(mi6);


                    MenuItem mi7 = new MenuItem("Update details");
                    mi7.Click += new EventHandler(updateDetails);
                    m.MenuItems.Add(mi7);

                    m.Show(dgvPatients, new Point(e.X, e.Y));
                }
                catch (Exception) { }
            }
        }

        private void updateDetails(object sender, EventArgs e)
        {
            int currentMouseOverRow = dgvPatients.CurrentRow.Index;
            string selectedNIC = dgvPatients.Rows[currentMouseOverRow].Cells[6].Value.ToString();
            new UpdatePatient(DataBaseOperator.GetInstance().getPatientByNIC(selectedNIC)).ShowDialog();
            patients = DataBaseOperator.GetInstance().getAllPatients();
            dgvPatients.DataSource = patients;
        }

        private void getProfile(object sender, EventArgs e)
        {
            
            int currentMouseOverRow = dgvPatients.CurrentRow.Index;
            string selectedNIC = dgvPatients.Rows[currentMouseOverRow].Cells[6].Value.ToString();            
            new PatientProfile(DataBaseOperator.GetInstance().getPatientByNIC(selectedNIC)).ShowDialog();
            patients = DataBaseOperator.GetInstance().getAllPatients();
            dgvPatients.DataSource = patients;
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

        private void txtSearchPatients_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = new DataView(patients);
            dataView.RowFilter = string.Format("Name Like '%{0}%'", txtSearchPatients.Text);
            dgvPatients.DataSource = dataView;
        }

        private void txtSearchUsers_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dataView = new DataView(users);
                dataView.RowFilter = string.Format("[Full Name] Like '%{0}%'", txtSearchUsers.Text);
                dgvUsers.DataSource = dataView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }        

        private void btnAddPatientProfile_Click(object sender, EventArgs e)
        {
            new PatientDeseaseRecord().Show(); 
        }

        private void btnUserProChange_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = "Doctor";
            user.Password = "DOC";
            user.Position = "Assistance";
            user.Fullname = "A";
            user.Gender = "Male";
            user.Nic = "123456789V";
            user.ContactNo = "123456";
            new UpdateUser(user).ShowDialog();
        }

        private void dgvUsers_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvUsers.HitTest(e.X, e.Y);
                dgvUsers.ClearSelection();
                dgvUsers.Rows[hti.RowIndex].Selected = true;

                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = dgvUsers.HitTest(e.X, e.Y).RowIndex;
                DataGridViewRow selectedRow = dgvUsers.Rows[currentMouseOverRow];


                MenuItem mi1 = new MenuItem("Delete Selected User");
                mi1.Click += new EventHandler(deleteUser);
                m.MenuItems.Add(mi1);

                m.Show(dgvUsers, new Point(e.X, e.Y));

            }
        }

        private void deleteUser(object sender, EventArgs e)
        {
            if (dgvUsers.Rows.Count > 0)
            {
                DataBaseOperator.GetInstance().deleteUser(dgvUsers.SelectedRows[0].Cells[3].Value.ToString());
                dgvUsers.Rows.RemoveAt(dgvUsers.CurrentRow.Index);
                
            }
        }
        
      
        private void btnShowAppintments_Click(object sender, EventArgs e)
        {
            appoinments = DataBaseOperator.GetInstance().getAllAppointments();
            dgvApplintments.DataSource = appoinments;
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            new AddAppointment().ShowDialog();
            appoinments = DataBaseOperator.GetInstance().getAllAppointments();
            dgvApplintments.DataSource = appoinments;
        }

        private void dgvApplintments_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvApplintments.HitTest(e.X, e.Y);
                dgvApplintments.ClearSelection();
                dgvApplintments.Rows[hti.RowIndex].Selected = true;

                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = dgvApplintments.HitTest(e.X, e.Y).RowIndex;
                DataGridViewRow selectedRow = dgvApplintments.Rows[currentMouseOverRow];


                MenuItem mi1 = new MenuItem("Delete Selected User");
                mi1.Click += new EventHandler(deleteAppointment);
                m.MenuItems.Add(mi1);

                m.Show(dgvApplintments, new Point(e.X, e.Y));

            }
        }

        private void deleteAppointment(object sender, EventArgs e)
        {
            if (dgvApplintments.Rows.Count > 0)
            {
                DataBaseOperator.GetInstance()
                    .deleteAppointment(Convert.ToInt32(dgvApplintments.SelectedRows[0].Cells[0].Value)
                    ,new Date(dgvApplintments.SelectedRows[0].Cells[1].Value.ToString()));
                dgvApplintments.Rows.RemoveAt(dgvApplintments.CurrentRow.Index);

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dataView = new DataView(appoinments);
                dataView.RowFilter = string.Format("[Date] = #{0}#", dtpAppoinmentDates.Value.ToString("MM/dd/yyyy"));
                dgvApplintments.DataSource = dataView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnCurrentAppointments_Click(object sender, EventArgs e)
        {
            appoinments = DataBaseOperator.GetInstance().getAllCurrentAppointments();
            dgvApplintments.DataSource = appoinments;
        }

        private void btnDeletePast_Click(object sender, EventArgs e)
        {
            DataBaseOperator.GetInstance().deletePreviousAppointment();
            appoinments = DataBaseOperator.GetInstance().getAllCurrentAppointments();
            dgvApplintments.DataSource = appoinments;
        }

        private void txtSearchPatient_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string nic = txtSearchPatient.Text.Split('-')[1];
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
                    lbBlood.Text = patient.BloodType;
                }
                else
                {
                    lbPID.Text = "-";
                    lbFN.Text = "-";
                    lbLN.Text = "-";
                    lbNIC.Text = "-";
                    lbDOB.Text = "-";
                    lbG.Text = "-";
                    lbBlood.Text = "-";
                }
            }
            catch (IndexOutOfRangeException)
            {
                patient = null;
                lbPID.Text = "-";
                lbFN.Text = "-";
                lbLN.Text = "-";
                lbNIC.Text = "-";
                lbDOB.Text = "-";
                lbG.Text = "-";
                lbBlood.Text = "-";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
