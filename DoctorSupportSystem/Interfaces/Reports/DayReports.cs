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

namespace DoctorSupportSystem.Interfaces.Reports
{
    public partial class DayReports : Form
    {
        private int rid;
        private DataTable dayReports;
        public DayReports(int rid)
        {
            InitializeComponent();
            this.rid = rid;
            dayReports = DataBaseOperator.GetInstance().getAllDayReports(rid);
            DataTable dates = dayReports.Copy();
            dates.Columns.Remove("PCondition");
            dgvDays.DataSource = dates;
           
        }

        private void loadDayReports() {
            dayReports = DataBaseOperator.GetInstance().getAllDayReports(rid);
            //dgvDays.DataSource = dayReports.Copy().Columns.Remove("");
        }

        private void txtCondition_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDays_MouseClick(object sender, MouseEventArgs e)
        {
            try {
                txtCondition.Text = dayReports
                    .Select(String.Format("[Day Report ID] = '{0}' AND [Date] = '{1}'",
                    dgvDays.SelectedRows[0].Cells[0].Value.ToString(),
                    dgvDays.SelectedRows[0].Cells[1].Value.ToString()) )[0][2].ToString();
                dgvMedicines.DataSource = DataBaseOperator.GetInstance()
                    .getAllMedicines(Convert.ToInt32(dgvDays.SelectedRows[0].Cells[0].Value));
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }

        private void DayReports_Load(object sender, EventArgs e)
        {
            try
            {
                txtCondition.Text = dayReports
                    .Select(String.Format("[Day Report ID] = '{0}' AND [Date] = '{1}'", 
                    dgvDays.SelectedRows[0].Cells[0].Value.ToString(), 
                    dgvDays.SelectedRows[0].Cells[1].Value.ToString()))[0][2].ToString();
                dgvMedicines.DataSource = DataBaseOperator.GetInstance()
                    .getAllMedicines(Convert.ToInt32(dgvDays.SelectedRows[0].Cells[0].Value));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
