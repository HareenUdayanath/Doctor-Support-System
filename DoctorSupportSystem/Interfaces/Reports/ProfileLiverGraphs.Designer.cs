namespace DoctorSupportSystem.Interfaces.Reports
{
    partial class ProfileLiverGraphs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbGamma = new System.Windows.Forms.CheckBox();
            this.cbAST = new System.Windows.Forms.CheckBox();
            this.cbALT = new System.Windows.Forms.CheckBox();
            this.cbALK_P = new System.Windows.Forms.CheckBox();
            this.cbBT = new System.Windows.Forms.CheckBox();
            this.cbAG_R = new System.Windows.Forms.CheckBox();
            this.cbGlobuin = new System.Windows.Forms.CheckBox();
            this.cbALbumin = new System.Windows.Forms.CheckBox();
            this.cbTotPro = new System.Windows.Forms.CheckBox();
            this.profileGraphs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileGraphs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.cbGamma);
            this.panel2.Controls.Add(this.cbAST);
            this.panel2.Controls.Add(this.cbALT);
            this.panel2.Controls.Add(this.cbALK_P);
            this.panel2.Controls.Add(this.cbBT);
            this.panel2.Controls.Add(this.cbAG_R);
            this.panel2.Controls.Add(this.cbGlobuin);
            this.panel2.Controls.Add(this.cbALbumin);
            this.panel2.Controls.Add(this.cbTotPro);
            this.panel2.Location = new System.Drawing.Point(53, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 62);
            this.panel2.TabIndex = 16;
            // 
            // cbGamma
            // 
            this.cbGamma.AutoSize = true;
            this.cbGamma.Checked = true;
            this.cbGamma.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGamma.Location = new System.Drawing.Point(234, 26);
            this.cbGamma.Name = "cbGamma";
            this.cbGamma.Size = new System.Drawing.Size(80, 17);
            this.cbGamma.TabIndex = 8;
            this.cbGamma.Text = "Gamma-GT";
            this.cbGamma.UseVisualStyleBackColor = true;
            this.cbGamma.CheckedChanged += new System.EventHandler(this.cbGamma_CheckedChanged);
            // 
            // cbAST
            // 
            this.cbAST.AutoSize = true;
            this.cbAST.Checked = true;
            this.cbAST.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAST.Location = new System.Drawing.Point(126, 26);
            this.cbAST.Name = "cbAST";
            this.cbAST.Size = new System.Drawing.Size(95, 17);
            this.cbAST.TabIndex = 7;
            this.cbAST.Text = "AST (S.G.O.T)";
            this.cbAST.UseVisualStyleBackColor = true;
            this.cbAST.CheckedChanged += new System.EventHandler(this.cbAST_CheckedChanged);
            // 
            // cbALT
            // 
            this.cbALT.AutoSize = true;
            this.cbALT.Checked = true;
            this.cbALT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbALT.Location = new System.Drawing.Point(3, 26);
            this.cbALT.Name = "cbALT";
            this.cbALT.Size = new System.Drawing.Size(93, 17);
            this.cbALT.TabIndex = 6;
            this.cbALT.Text = "ALT (S.G.P.T)";
            this.cbALT.UseVisualStyleBackColor = true;
            this.cbALT.CheckedChanged += new System.EventHandler(this.cbALT_CheckedChanged);
            // 
            // cbALK_P
            // 
            this.cbALK_P.AutoSize = true;
            this.cbALK_P.Checked = true;
            this.cbALK_P.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbALK_P.Location = new System.Drawing.Point(607, 3);
            this.cbALK_P.Name = "cbALK_P";
            this.cbALK_P.Size = new System.Drawing.Size(114, 17);
            this.cbALK_P.TabIndex = 5;
            this.cbALK_P.Text = "ALK. Phosphatase";
            this.cbALK_P.UseVisualStyleBackColor = true;
            this.cbALK_P.CheckedChanged += new System.EventHandler(this.cbALK_P_CheckedChanged);
            // 
            // cbBT
            // 
            this.cbBT.AutoSize = true;
            this.cbBT.Checked = true;
            this.cbBT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBT.Location = new System.Drawing.Point(454, 3);
            this.cbBT.Name = "cbBT";
            this.cbBT.Size = new System.Drawing.Size(97, 17);
            this.cbBT.TabIndex = 4;
            this.cbBT.Text = "Bilirubin – Total";
            this.cbBT.UseVisualStyleBackColor = true;
            this.cbBT.CheckedChanged += new System.EventHandler(this.cbBT_CheckedChanged);
            // 
            // cbAG_R
            // 
            this.cbAG_R.AutoSize = true;
            this.cbAG_R.Checked = true;
            this.cbAG_R.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAG_R.Location = new System.Drawing.Point(341, 3);
            this.cbAG_R.Name = "cbAG_R";
            this.cbAG_R.Size = new System.Drawing.Size(74, 17);
            this.cbAG_R.TabIndex = 3;
            this.cbAG_R.Text = "A/G Ratio";
            this.cbAG_R.UseVisualStyleBackColor = true;
            this.cbAG_R.CheckedChanged += new System.EventHandler(this.cbAG_R_CheckedChanged);
            // 
            // cbGlobuin
            // 
            this.cbGlobuin.AutoSize = true;
            this.cbGlobuin.Checked = true;
            this.cbGlobuin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGlobuin.Location = new System.Drawing.Point(234, 3);
            this.cbGlobuin.Name = "cbGlobuin";
            this.cbGlobuin.Size = new System.Drawing.Size(62, 17);
            this.cbGlobuin.TabIndex = 2;
            this.cbGlobuin.Text = "Globuin";
            this.cbGlobuin.UseVisualStyleBackColor = true;
            this.cbGlobuin.CheckedChanged += new System.EventHandler(this.cbGlobuin_CheckedChanged);
            // 
            // cbALbumin
            // 
            this.cbALbumin.AutoSize = true;
            this.cbALbumin.Checked = true;
            this.cbALbumin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbALbumin.Location = new System.Drawing.Point(126, 3);
            this.cbALbumin.Name = "cbALbumin";
            this.cbALbumin.Size = new System.Drawing.Size(63, 17);
            this.cbALbumin.TabIndex = 1;
            this.cbALbumin.Text = "Albumin";
            this.cbALbumin.UseVisualStyleBackColor = true;
            this.cbALbumin.CheckedChanged += new System.EventHandler(this.cbALbumin_CheckedChanged);
            // 
            // cbTotPro
            // 
            this.cbTotPro.AutoSize = true;
            this.cbTotPro.Checked = true;
            this.cbTotPro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTotPro.Location = new System.Drawing.Point(3, 3);
            this.cbTotPro.Name = "cbTotPro";
            this.cbTotPro.Size = new System.Drawing.Size(86, 17);
            this.cbTotPro.TabIndex = 0;
            this.cbTotPro.Text = "Total Protein";
            this.cbTotPro.UseVisualStyleBackColor = true;
            this.cbTotPro.CheckedChanged += new System.EventHandler(this.cbTotPro_CheckedChanged);
            // 
            // profileGraphs
            // 
            this.profileGraphs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileGraphs.BorderlineColor = System.Drawing.Color.Black;
            this.profileGraphs.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.profileGraphs.ChartAreas.Add(chartArea1);
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.profileGraphs.Legends.Add(legend1);
            this.profileGraphs.Location = new System.Drawing.Point(53, 12);
            this.profileGraphs.Name = "profileGraphs";
            this.profileGraphs.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.MarkerSize = 8;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Total Protein";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.MarkerSize = 8;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Albumin";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerSize = 8;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Globuin";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.MarkerSize = 8;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "A/G Ratio";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.MarkerSize = 8;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "Bilirubin – Total";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.MarkerSize = 8;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "ALK. Phosphatase";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.MarkerSize = 8;
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series7.Name = "ALT (S.G.P.T)";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.MarkerSize = 8;
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series8.Name = "AST (S.G.O.T)";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.MarkerSize = 8;
            series9.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series9.Name = "Gamma-GT";
            this.profileGraphs.Series.Add(series1);
            this.profileGraphs.Series.Add(series2);
            this.profileGraphs.Series.Add(series3);
            this.profileGraphs.Series.Add(series4);
            this.profileGraphs.Series.Add(series5);
            this.profileGraphs.Series.Add(series6);
            this.profileGraphs.Series.Add(series7);
            this.profileGraphs.Series.Add(series8);
            this.profileGraphs.Series.Add(series9);
            this.profileGraphs.Size = new System.Drawing.Size(781, 359);
            this.profileGraphs.TabIndex = 15;
            this.profileGraphs.Text = "urineGraphs";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 451);
            this.panel1.TabIndex = 14;
            // 
            // ProfileLiverGraphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.profileGraphs);
            this.Controls.Add(this.panel1);
            this.Name = "ProfileLiverGraphs";
            this.Text = "ProfileLiverGraphs";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileGraphs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbGlobuin;
        private System.Windows.Forms.CheckBox cbALbumin;
        private System.Windows.Forms.CheckBox cbTotPro;
        private System.Windows.Forms.DataVisualization.Charting.Chart profileGraphs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbALT;
        private System.Windows.Forms.CheckBox cbALK_P;
        private System.Windows.Forms.CheckBox cbBT;
        private System.Windows.Forms.CheckBox cbAG_R;
        private System.Windows.Forms.CheckBox cbGamma;
        private System.Windows.Forms.CheckBox cbAST;
    }
}