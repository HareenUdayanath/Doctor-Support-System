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
    public partial class UrineTestGraphs : Form
    {
        List<UrineTest> testList = null;
        public UrineTestGraphs(List<UrineTest> testList)
        {
            InitializeComponent();
            this.testList = testList;
            setGraphs();
            urineGraphs.ChartAreas[0].AxisX.IsMarginVisible = false;
        }

        private void setGraphs() {
            foreach(UrineTest test in testList)
            {
                urineGraphs.Series["Urine for Micro Albumin"].Points.AddXY(test.Date.getDate(),test.Urine_MA);
                urineGraphs.Series["Urine Creatinine"].Points.AddXY(test.Date.getDate(), test.Urine_C);
                urineGraphs.Series["Urine Albumin/Creatinine"].Points.AddXY(test.Date.getDate(), test.Urine_AC);
            }
        }

        private void cbUrineMA_CheckedChanged(object sender, EventArgs e)
        {
            if(cbUrineMA.Checked)
                urineGraphs.Series["Urine for Micro Albumin"].Enabled = true;
            else
                urineGraphs.Series["Urine for Micro Albumin"].Enabled = false;

        }

        private void cbUrineC_CheckedChanged(object sender, EventArgs e)
        {

            if (cbUrineC.Checked)
                urineGraphs.Series["Urine Creatinine"].Enabled = true;
            else
                urineGraphs.Series["Urine Creatinine"].Enabled = false;

        }

        private void cbUrineAC_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUrineAC.Checked)
                urineGraphs.Series["Urine Albumin/Creatinine"].Enabled = true;
            else
                urineGraphs.Series["Urine Albumin/Creatinine"].Enabled = false;
        }
    }
}
