using DoctorSupportSystem.DataBase;
using DoctorSupportSystem.Models;
using DoctorSupportSystem.Models.Test;
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
    public partial class MedicalDayReport : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        private DeseaseReport deseaseReport;
        public MedicalDayReport(DeseaseReport deseaseReport)
        {
            InitializeComponent();
            this.deseaseReport = deseaseReport;
            dgvMedicines.Rows.Add();
            dgvMedicines.Rows[0].Cells[0].Value = dgvMedicines.Rows.Count;
            dgvMedicines.CurrentCell = dgvMedicines.Rows[0].Cells[1];
        }

        private void dgvMedicines_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Point cellPoint = dgvMedicines.CurrentCellAddress;
                if (cellPoint.Y == dgvMedicines.Rows.Count - 1)
                {
                    dgvMedicines.Rows.Add();
                    dgvMedicines.Rows[dgvMedicines.Rows.Count - 1].Cells[0].Value = dgvMedicines.Rows.Count;
                }
            }

            
            
        }

        private void dgvMedicines_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvMedicines.HitTest(e.X, e.Y);
                dgvMedicines.ClearSelection();
                dgvMedicines.Rows[hti.RowIndex].Selected = true;

                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = dgvMedicines.HitTest(e.X, e.Y).RowIndex;
                DataGridViewRow selectedRow = dgvMedicines.Rows[currentMouseOverRow];
               

                MenuItem mi1 = new MenuItem("Delete Selected Row");
                mi1.Click += new EventHandler(deleteRow);
                m.MenuItems.Add(mi1);

                m.Show(dgvMedicines, new Point(e.X, e.Y));

            }
        }

        private void deleteRow(object sender, EventArgs e)
        {

            if (dgvMedicines.Rows.Count > 1)
            {               

                dgvMedicines.Rows.RemoveAt(dgvMedicines.CurrentRow.Index);
                for(int i = dgvMedicines.CurrentRow.Index ; i < dgvMedicines.Rows.Count ; i++)
                {
                    dgvMedicines.Rows[i].Cells[0].Value = i+1;
                }                
            }
        }

        private void btnAddDayReport_Click(object sender, EventArgs e)
        {
            DayReport dayReport = new DayReport();
            dayReport.Rid = deseaseReport.Rid; 

            dayReport.Date = new Date(this.dateTimePicker1.Value);

            String err = "";

            if (txtCondition.Text == "")
                err += "Condition required\n";
            if (dgvMedicines.RowCount == 1 && ("".Equals(dgvMedicines.Rows[0].Cells[1])|| dgvMedicines.Rows[0].Cells[1]==null))
                err += "Medicines required\n";
          

            if (err != "")
            {
                MessageBox.Show(err);
            }
            else
            {
                dayReport.Condition = txtCondition.Text;
                for(int i = 0 ; i < dgvMedicines.Rows.Count ; i++)
                {
                    dayReport.addMedicine(dgvMedicines.Rows[i].Cells[1].Value.ToString());
                }

                if (DataBaseOperator.GetInstance().addDayReport(dayReport) == -1)
                {
                    MessageBox.Show("Duplicate NIC:\n"
                        + "This NIC already exist in the database");
                }
                else
                {
                    MessageBox.Show("The Day Report successfully added to the database");                   
                    this.Close();
                }
            }
        }

        private void dgvMedicines_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
           /* DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
            tb.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);

            e.Control.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MedicalDayReport_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        /* private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.KeyChar == (char)Keys.Back)
             {
                 Point cellPoint = dgvMedicines.CurrentCellAddress;

                 if (cellPoint.Y == dgvMedicines.Rows.Count - 1 && cellPoint.Y != 0 && cellPoint.X == 1)
                 {

                     if (dgvMedicines.CurrentCell.Value == null || "".Equals(dgvMedicines.CurrentCell.Value))
                     {

                         dgvMedicines.Rows.RemoveAt(dgvMedicines.Rows.Count - 1);
                     }
                 }
             }
         }*/
    }
}
