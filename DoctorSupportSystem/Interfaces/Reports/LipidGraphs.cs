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
    public partial class LipidGraphs : Form
    {

        private List<LipidTest> testList = null;
        public LipidGraphs(List<LipidTest> testList)
        {
            this.testList = testList;
            InitializeComponent();
            setGraphs();
            lipidGraphs1.ChartAreas[0].AxisX.IsMarginVisible = false;
        }

        private void setGraphs()
        {
            foreach (LipidTest test in testList)
            {

                lipidGraphs1.Series["Cholesterol - Total"].Points.AddXY(test.Date.getDate(), test.CholesterolTotal);
                lipidGraphs1.Series["Triglycerides"].Points.AddXY(test.Date.getDate(), test.Triglycerides);
                lipidGraphs1.Series["Cholesterol – H.D.L"].Points.AddXY(test.Date.getDate(), test.CholesterolHDL);
                lipidGraphs1.Series["Cholesterol L.D.L"].Points.AddXY(test.Date.getDate(), test.CholesterolLDL);
                lipidGraphs1.Series["Cholesterol – VLDL"].Points.AddXY(test.Date.getDate(), test.CholesterolVLDL);
                lipidGraphs1.Series["CHOL / HDL"].Points.AddXY(test.Date.getDate(), test.Chol_hdl);
                lipidGraphs1.Series["LDL / HDL"].Points.AddXY(test.Date.getDate(), test.Ldl_hdl);

            }
        }

        private void cbCT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCT.Checked)
                lipidGraphs1.Series["Cholesterol - Total"].Enabled = true;
            else
                lipidGraphs1.Series["Cholesterol - Total"].Enabled = false;

        }

        private void cbT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbT.Checked)
                lipidGraphs1.Series["Triglycerides"].Enabled = true;
            else
                lipidGraphs1.Series["Triglycerides"].Enabled = false;

        }

        private void cbCHDL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCHDL.Checked)
                lipidGraphs1.Series["Cholesterol – H.D.L"].Enabled = true;
            else
                lipidGraphs1.Series["Cholesterol – H.D.L"].Enabled = false;

        }

        private void cbCLDL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCLDL.Checked)
                lipidGraphs1.Series["Cholesterol L.D.L"].Enabled = true;
            else
                lipidGraphs1.Series["Cholesterol L.D.L"].Enabled = false;

        }

        private void cbCVLDL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCVLDL.Checked)
                lipidGraphs1.Series["Cholesterol – VLDL"].Enabled = true;
            else
                lipidGraphs1.Series["Cholesterol – VLDL"].Enabled = false;

        }

        private void cbCHOL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCHOL.Checked)
                lipidGraphs1.Series["CHOL / HDL"].Enabled = true;
            else
                lipidGraphs1.Series["CHOL / HDL"].Enabled = false;

        }

        private void cbLDL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLDL.Checked)
                lipidGraphs1.Series["LDL / HDL"].Enabled = true;
            else
                lipidGraphs1.Series["LDL / HDL"].Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
