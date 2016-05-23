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
    public partial class ProfileLiverGraphs : Form
    {

        private List<ProfileLiverTest> testList = null;
        
        public ProfileLiverGraphs(List<ProfileLiverTest> testList)
        {
            this.testList = testList;
            InitializeComponent();
            setGraphs();
        }

        private void setGraphs()
        {
            foreach (ProfileLiverTest test in testList)
            {
               
                this.urineGraphs.Series["Total Protein"].Points.AddXY(test.Date.getDate(), test.TotalProtein);
                this.urineGraphs.Series["Albumin"].Points.AddXY(test.Date.getDate(), test.Albumin);
                this.urineGraphs.Series["Globuin"].Points.AddXY(test.Date.getDate(), test.Globumin);
                this.urineGraphs.Series["A/G Ratio"].Points.AddXY(test.Date.getDate(), test.Ag_Ratio);
                this.urineGraphs.Series["Bilirubin – Total"].Points.AddXY(test.Date.getDate(), test.BilirubinTotal);
                this.urineGraphs.Series["ALK. Phosphatase"].Points.AddXY(test.Date.getDate(), test.AlkPhosphatase);
                this.urineGraphs.Series["ALT (S.G.P.T)"].Points.AddXY(test.Date.getDate(), test.Alt);
                this.urineGraphs.Series["AST (S.G.O.T)"].Points.AddXY(test.Date.getDate(), test.Ast);
                this.urineGraphs.Series["Gamma-GT"].Points.AddXY(test.Date.getDate(), test.Gamma);
            }
        }

        private void cbTotPro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTotPro.Checked)
                this.urineGraphs.Series["Total Protein"].Enabled = true;
            else
                this.urineGraphs.Series["Total Protein"].Enabled = false;
        }

        private void cbALbumin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbALbumin.Checked)
                this.urineGraphs.Series["Albumin"].Enabled = true;
            else
                this.urineGraphs.Series["Albumin"].Enabled = false;

        }

        private void cbGlobuin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGlobuin.Checked)
                this.urineGraphs.Series["Globuin"].Enabled = true;
            else
                this.urineGraphs.Series["Globuin"].Enabled = false;

        }

        private void cbAG_R_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAG_R.Checked)
                this.urineGraphs.Series["A/G Ratio"].Enabled = true;
            else
                this.urineGraphs.Series["A/G Ratio"].Enabled = false;

        }

        private void cbBT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBT.Checked)
                this.urineGraphs.Series["Bilirubin – Total"].Enabled = true;
            else
                this.urineGraphs.Series["Bilirubin – Total"].Enabled = false;

        }

        private void cbALK_P_CheckedChanged(object sender, EventArgs e)
        {
            if (cbALK_P.Checked)
                this.urineGraphs.Series["ALK. Phosphatase"].Enabled = true;
            else
                this.urineGraphs.Series["ALK. Phosphatase"].Enabled = false;

        }

        private void cbALT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbALT.Checked)
                this.urineGraphs.Series["ALT (S.G.P.T)"].Enabled = true;
            else
                this.urineGraphs.Series["ALT (S.G.P.T)"].Enabled = false;

        }

        private void cbAST_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAST.Checked)
                this.urineGraphs.Series["AST (S.G.O.T)"].Enabled = true;
            else
                this.urineGraphs.Series["AST (S.G.O.T)"].Enabled = false;

        }

        private void cbGamma_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGamma.Checked)
                this.urineGraphs.Series["Gamma-GT"].Enabled = true;
            else
                this.urineGraphs.Series["Gamma-GT"].Enabled = false;

        }
    }
}
