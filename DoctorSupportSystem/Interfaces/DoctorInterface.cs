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
    public partial class DoctorInterface : Form
    {
        public DoctorInterface()
        {
            InitializeComponent();
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
            dataGridView1.DataSource = DataBaseOperator.GetInstance().getAllUser();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
