namespace DoctorSupportSystem.Interfaces.Reports
{
    partial class LipidGraphs
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbLDL = new System.Windows.Forms.CheckBox();
            this.cbCHOL = new System.Windows.Forms.CheckBox();
            this.cbCVLDL = new System.Windows.Forms.CheckBox();
            this.cbCLDL = new System.Windows.Forms.CheckBox();
            this.cbCHDL = new System.Windows.Forms.CheckBox();
            this.cbT = new System.Windows.Forms.CheckBox();
            this.cbCT = new System.Windows.Forms.CheckBox();
            this.urineGraphs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urineGraphs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbLDL);
            this.panel2.Controls.Add(this.cbCHOL);
            this.panel2.Controls.Add(this.cbCVLDL);
            this.panel2.Controls.Add(this.cbCLDL);
            this.panel2.Controls.Add(this.cbCHDL);
            this.panel2.Controls.Add(this.cbT);
            this.panel2.Controls.Add(this.cbCT);
            this.panel2.Location = new System.Drawing.Point(63, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 62);
            this.panel2.TabIndex = 19;
            // 
            // cbLDL
            // 
            this.cbLDL.AutoSize = true;
            this.cbLDL.Checked = true;
            this.cbLDL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLDL.Location = new System.Drawing.Point(140, 26);
            this.cbLDL.Name = "cbLDL";
            this.cbLDL.Size = new System.Drawing.Size(79, 17);
            this.cbLDL.TabIndex = 6;
            this.cbLDL.Text = "LDL / HDL";
            this.cbLDL.UseVisualStyleBackColor = true;
            this.cbLDL.CheckedChanged += new System.EventHandler(this.cbLDL_CheckedChanged);
            // 
            // cbCHOL
            // 
            this.cbCHOL.AutoSize = true;
            this.cbCHOL.Checked = true;
            this.cbCHOL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCHOL.Location = new System.Drawing.Point(3, 26);
            this.cbCHOL.Name = "cbCHOL";
            this.cbCHOL.Size = new System.Drawing.Size(88, 17);
            this.cbCHOL.TabIndex = 5;
            this.cbCHOL.Text = "CHOL / HDL";
            this.cbCHOL.UseVisualStyleBackColor = true;
            this.cbCHOL.CheckedChanged += new System.EventHandler(this.cbCHOL_CheckedChanged);
            // 
            // cbCVLDL
            // 
            this.cbCVLDL.AutoSize = true;
            this.cbCVLDL.Checked = true;
            this.cbCVLDL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCVLDL.Location = new System.Drawing.Point(540, 3);
            this.cbCVLDL.Name = "cbCVLDL";
            this.cbCVLDL.Size = new System.Drawing.Size(116, 17);
            this.cbCVLDL.TabIndex = 4;
            this.cbCVLDL.Text = "Cholesterol – VLDL";
            this.cbCVLDL.UseVisualStyleBackColor = true;
            this.cbCVLDL.CheckedChanged += new System.EventHandler(this.cbCVLDL_CheckedChanged);
            // 
            // cbCLDL
            // 
            this.cbCLDL.AutoSize = true;
            this.cbCLDL.Checked = true;
            this.cbCLDL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCLDL.Location = new System.Drawing.Point(396, 3);
            this.cbCLDL.Name = "cbCLDL";
            this.cbCLDL.Size = new System.Drawing.Size(107, 17);
            this.cbCLDL.TabIndex = 3;
            this.cbCLDL.Text = "Cholesterol L.D.L";
            this.cbCLDL.UseVisualStyleBackColor = true;
            this.cbCLDL.CheckedChanged += new System.EventHandler(this.cbCLDL_CheckedChanged);
            // 
            // cbCHDL
            // 
            this.cbCHDL.AutoSize = true;
            this.cbCHDL.Checked = true;
            this.cbCHDL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCHDL.Location = new System.Drawing.Point(255, 3);
            this.cbCHDL.Name = "cbCHDL";
            this.cbCHDL.Size = new System.Drawing.Size(117, 17);
            this.cbCHDL.TabIndex = 2;
            this.cbCHDL.Text = "Cholesterol – H.D.L";
            this.cbCHDL.UseVisualStyleBackColor = true;
            this.cbCHDL.CheckedChanged += new System.EventHandler(this.cbCHDL_CheckedChanged);
            // 
            // cbT
            // 
            this.cbT.AutoSize = true;
            this.cbT.Checked = true;
            this.cbT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbT.Location = new System.Drawing.Point(140, 3);
            this.cbT.Name = "cbT";
            this.cbT.Size = new System.Drawing.Size(85, 17);
            this.cbT.TabIndex = 1;
            this.cbT.Text = "Triglycerides";
            this.cbT.UseVisualStyleBackColor = true;
            this.cbT.CheckedChanged += new System.EventHandler(this.cbT_CheckedChanged);
            // 
            // cbCT
            // 
            this.cbCT.AutoSize = true;
            this.cbCT.Checked = true;
            this.cbCT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCT.Location = new System.Drawing.Point(3, 3);
            this.cbCT.Name = "cbCT";
            this.cbCT.Size = new System.Drawing.Size(111, 17);
            this.cbCT.TabIndex = 0;
            this.cbCT.Text = "Cholesterol - Total";
            this.cbCT.UseVisualStyleBackColor = true;
            this.cbCT.CheckedChanged += new System.EventHandler(this.cbCT_CheckedChanged);
            // 
            // urineGraphs
            // 
            this.urineGraphs.BorderlineColor = System.Drawing.Color.Black;
            this.urineGraphs.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.urineGraphs.ChartAreas.Add(chartArea1);
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.urineGraphs.Legends.Add(legend1);
            this.urineGraphs.Location = new System.Drawing.Point(63, 12);
            this.urineGraphs.Name = "urineGraphs";
            this.urineGraphs.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Cholesterol - Total";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Triglycerides";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Cholesterol – H.D.L";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Cholesterol L.D.L";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Cholesterol – VLDL";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "CHOL / HDL";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "LDL / HDL";
            this.urineGraphs.Series.Add(series1);
            this.urineGraphs.Series.Add(series2);
            this.urineGraphs.Series.Add(series3);
            this.urineGraphs.Series.Add(series4);
            this.urineGraphs.Series.Add(series5);
            this.urineGraphs.Series.Add(series6);
            this.urineGraphs.Series.Add(series7);
            this.urineGraphs.Size = new System.Drawing.Size(781, 347);
            this.urineGraphs.TabIndex = 18;
            this.urineGraphs.Text = "urineGraphs";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 464);
            this.panel1.TabIndex = 17;
            // 
            // LipidGraphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 464);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.urineGraphs);
            this.Controls.Add(this.panel1);
            this.Name = "LipidGraphs";
            this.Text = "LipidGraphs";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urineGraphs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbLDL;
        private System.Windows.Forms.CheckBox cbCHOL;
        private System.Windows.Forms.CheckBox cbCVLDL;
        private System.Windows.Forms.CheckBox cbCLDL;
        private System.Windows.Forms.CheckBox cbCHDL;
        private System.Windows.Forms.CheckBox cbT;
        private System.Windows.Forms.CheckBox cbCT;
        private System.Windows.Forms.DataVisualization.Charting.Chart urineGraphs;
        private System.Windows.Forms.Panel panel1;
    }
}