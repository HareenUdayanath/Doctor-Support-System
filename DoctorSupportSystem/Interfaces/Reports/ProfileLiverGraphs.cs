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
            profileGraphs.ChartAreas[0].AxisX.IsMarginVisible = false;
        }

        private void setGraphs()
        {
            foreach (ProfileLiverTest test in testList)
            {

                profileGraphs.Series["Total Protein"].Points.AddXY(test.Date.getDate(), test.TotalProtein);
                profileGraphs.Series["Albumin"].Points.AddXY(test.Date.getDate(), test.Albumin);
                profileGraphs.Series["Globuin"].Points.AddXY(test.Date.getDate(), test.Globumin);
                profileGraphs.Series["A/G Ratio"].Points.AddXY(test.Date.getDate(), test.Ag_Ratio);
                profileGraphs.Series["Bilirubin – Total"].Points.AddXY(test.Date.getDate(), test.BilirubinTotal);
                profileGraphs.Series["ALK. Phosphatase"].Points.AddXY(test.Date.getDate(), test.AlkPhosphatase);
                profileGraphs.Series["ALT (S.G.P.T)"].Points.AddXY(test.Date.getDate(), test.Alt);
                profileGraphs.Series["AST (S.G.O.T)"].Points.AddXY(test.Date.getDate(), test.Ast);
                profileGraphs.Series["Gamma-GT"].Points.AddXY(test.Date.getDate(), test.Gamma);
            }
        }

        private void cbTotPro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTotPro.Checked)
                profileGraphs.Series["Total Protein"].Enabled = true;
            else
                profileGraphs.Series["Total Protein"].Enabled = false;
        }

        private void cbALbumin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbALbumin.Checked)
                profileGraphs.Series["Albumin"].Enabled = true;
            else
                profileGraphs.Series["Albumin"].Enabled = false;

        }

        private void cbGlobuin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGlobuin.Checked)
                profileGraphs.Series["Globuin"].Enabled = true;
            else
                profileGraphs.Series["Globuin"].Enabled = false;

        }

        private void cbAG_R_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAG_R.Checked)
                profileGraphs.Series["A/G Ratio"].Enabled = true;
            else
                profileGraphs.Series["A/G Ratio"].Enabled = false;

        }

        private void cbBT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBT.Checked)
                profileGraphs.Series["Bilirubin – Total"].Enabled = true;
            else
                profileGraphs.Series["Bilirubin – Total"].Enabled = false;

        }

        private void cbALK_P_CheckedChanged(object sender, EventArgs e)
        {
            if (cbALK_P.Checked)
                profileGraphs.Series["ALK. Phosphatase"].Enabled = true;
            else
                profileGraphs.Series["ALK. Phosphatase"].Enabled = false;

        }

        private void cbALT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbALT.Checked)
                profileGraphs.Series["ALT (S.G.P.T)"].Enabled = true;
            else
                profileGraphs.Series["ALT (S.G.P.T)"].Enabled = false;

        }

        private void cbAST_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAST.Checked)
                profileGraphs.Series["AST (S.G.O.T)"].Enabled = true;
            else
                profileGraphs.Series["AST (S.G.O.T)"].Enabled = false;

        }

        private void cbGamma_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGamma.Checked)
                profileGraphs.Series["Gamma-GT"].Enabled = true;
            else
                profileGraphs.Series["Gamma-GT"].Enabled = false;

        }
    }
}
