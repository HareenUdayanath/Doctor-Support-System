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

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
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

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
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

        private void AddAppointment_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
