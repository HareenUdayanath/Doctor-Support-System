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
        }

        private void setGraphs()
        {
            foreach (LipidTest test in testList)
            {
               
                this.urineGraphs.Series["Cholesterol - Total"].Points.AddXY(test.Date.getDate(), test.CholesterolTotal);
                this.urineGraphs.Series["Triglycerides"].Points.AddXY(test.Date.getDate(), test.Triglycerides);
                this.urineGraphs.Series["Cholesterol – H.D.L"].Points.AddXY(test.Date.getDate(), test.CholesterolHDL);
                this.urineGraphs.Series["Cholesterol L.D.L"].Points.AddXY(test.Date.getDate(), test.CholesterolLDL);
                this.urineGraphs.Series["Cholesterol – VLDL"].Points.AddXY(test.Date.getDate(), test.CholesterolVLDL);
                this.urineGraphs.Series["CHOL / HDL"].Points.AddXY(test.Date.getDate(), test.Chol_hdl);
                this.urineGraphs.Series["LDL / HDL"].Points.AddXY(test.Date.getDate(), test.Ldl_hdl);

            }
        }

        private void cbCT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCT.Checked)
                this.urineGraphs.Series["Cholesterol - Total"].Enabled = true;
            else
                this.urineGraphs.Series["Cholesterol - Total"].Enabled = false;

        }

        private void cbT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbT.Checked)
                this.urineGraphs.Series["Triglycerides"].Enabled = true;
            else
                this.urineGraphs.Series["Triglycerides"].Enabled = false;

        }

        private void cbCHDL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCHDL.Checked)
                this.urineGraphs.Series["Cholesterol – H.D.L"].Enabled = true;
            else
                this.urineGraphs.Series["Cholesterol – H.D.L"].Enabled = false;

        }

        private void cbCLDL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCLDL.Checked)
                this.urineGraphs.Series["Cholesterol L.D.L"].Enabled = true;
            else
                this.urineGraphs.Series["Cholesterol L.D.L"].Enabled = false;

        }

        private void cbCVLDL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCVLDL.Checked)
                this.urineGraphs.Series["Cholesterol – VLDL"].Enabled = true;
            else
                this.urineGraphs.Series["Cholesterol – VLDL"].Enabled = false;

        }

        private void cbCHOL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCHOL.Checked)
                this.urineGraphs.Series["CHOL / HDL"].Enabled = true;
            else
                this.urineGraphs.Series["CHOL / HDL"].Enabled = false;

        }

        private void cbLDL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLDL.Checked)
                this.urineGraphs.Series["LDL / HDL"].Enabled = true;
            else
                this.urineGraphs.Series["LDL / HDL"].Enabled = false;

        }
    }
}
