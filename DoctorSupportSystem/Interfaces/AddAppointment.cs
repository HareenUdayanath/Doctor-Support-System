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
        public AddAppointment()
        {
            InitializeComponent();
        }

       

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            selectedDate.Text = calendar.SelectionStart.ToString().Split(' ')[0];
        }
    }
}
