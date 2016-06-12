using DoctorSupportSystem.DataBase;
using DoctorSupportSystem.Help;
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
    public partial class AddAppointment : Form
    {

        DataBaseOperator db = DataBaseOperator.GetInstance();


        public AddAppointment()
        {
            InitializeComponent();
            //this.lbNumber.Text = (db.getNoOfAppointments(new Date(calendar.SelectionStart))+1).ToString();
        }

       

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            selectedDate.Text = calendar.SelectionStart.ToString().Split(' ')[0];
            lbNumber.Text = (db.getNoOfAppointments(new Date(calendar.SelectionStart)) + 1).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            Date selectedDate = new Date(calendar.SelectionStart);

            String err = "";

            if (txtPNIC.Text == "")
                err += "Patient Name required\n";         
            if (!Validator.nic(txtPNIC.Text))
                err += "Invalid NIC\n";
            else
                appointment.Nic = txtPNIC.Text;
            if (!Validator.isNotPast(selectedDate))
                err += "Date should not be a past one\n";
            Console.WriteLine(err);

            if (err != "")
            {
                MessageBox.Show(err);
            }
            else
            {
                /*if (db.addAppointment(appointment) == -1)
                {
                    MessageBox.Show("Duplicate NIC:\n"
                        + "This NIC already exist in the database");
                }
                else
                {*/
                appointment.Date = selectedDate;
                appointment.Number = Convert.ToInt32(lbNumber.Text);
                appointment.PatientName = txtPName.Text;
                db.addAppointment(appointment);
                MessageBox.Show("The patient successfully added to the database");
                new AddAppointment().Show();
                this.Close();
                //}

            }
        }
    }
}
