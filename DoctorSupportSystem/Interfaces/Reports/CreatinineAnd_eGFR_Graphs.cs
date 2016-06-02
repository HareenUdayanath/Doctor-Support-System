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
    public partial class CreatinineAnd_eGFR_Graphs : Form
    {

        List<CreatinineTest> testList = null;
        public CreatinineAnd_eGFR_Graphs(List<CreatinineTest> testList)
        {
            InitializeComponent();
            this.testList = testList;
            setGraphs();
            creatinineGraphs.ChartAreas[0].AxisX.IsMarginVisible = false;
        }

        private void setGraphs()
        {
            foreach (CreatinineTest test in testList)
            {
                creatinineGraphs.Series["Serum Creatinine"].Points.AddXY(test.Date.getDate(), test.SerumCreatinint);
                creatinineGraphs.Series["Estimated GFR"].Points.AddXY(test.Date.getDate(), test.Gfr);
                
            }
        }

        private void cbSC_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSC.Checked)
                this.creatinineGraphs.Series["Serum Creatinine"].Enabled = true;
            else
                this.creatinineGraphs.Series["Serum Creatinine"].Enabled = false;
        }

        private void cbEG_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEG.Checked)
                this.creatinineGraphs.Series["Estimated GFR"].Enabled = true;
            else
                this.creatinineGraphs.Series["Estimated GFR"].Enabled = false;
        }
    }
}
