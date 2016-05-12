using DoctorSupportSystem.DataBase;
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
    public partial class AssistanceInterface : Form
    {
        public AssistanceInterface()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = DataBaseOperator.GetInstance().getAllAppointments();
        }

        private void btnLoadPatients_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataBaseOperator.GetInstance().getAllPatients();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddAppointment().ShowDialog();
        }
    }
}
