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
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DayReports_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvDays_SelectionChanged(object sender, EventArgs e)
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
