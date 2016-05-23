﻿namespace DoctorSupportSystem.Interfaces.Reports
{
    partial class CreatinineAnd_eGFR_Graphs
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbEG = new System.Windows.Forms.CheckBox();
            this.cbSC = new System.Windows.Forms.CheckBox();
            this.urineGraphs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urineGraphs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbEG);
            this.panel2.Controls.Add(this.cbSC);
            this.panel2.Location = new System.Drawing.Point(53, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 28);
            this.panel2.TabIndex = 16;
            // 
            // cbEG
            // 
            this.cbEG.AutoSize = true;
            this.cbEG.Checked = true;
            this.cbEG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEG.Location = new System.Drawing.Point(158, 3);
            this.cbEG.Name = "cbEG";
            this.cbEG.Size = new System.Drawing.Size(97, 17);
            this.cbEG.TabIndex = 1;
            this.cbEG.Text = "Estimated GFR";
            this.cbEG.UseVisualStyleBackColor = true;
            this.cbEG.CheckedChanged += new System.EventHandler(this.cbEG_CheckedChanged);
            // 
            // cbSC
            // 
            this.cbSC.AutoSize = true;
            this.cbSC.Checked = true;
            this.cbSC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSC.Location = new System.Drawing.Point(3, 3);
            this.cbSC.Name = "cbSC";
            this.cbSC.Size = new System.Drawing.Size(106, 17);
            this.cbSC.TabIndex = 0;
            this.cbSC.Text = "Serum Creatinine";
            this.cbSC.UseVisualStyleBackColor = true;
            this.cbSC.CheckedChanged += new System.EventHandler(this.cbSC_CheckedChanged);
            // 
            // urineGraphs
            // 
            this.urineGraphs.BorderlineColor = System.Drawing.Color.Black;
            this.urineGraphs.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.urineGraphs.ChartAreas.Add(chartArea2);
            legend2.BorderColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.urineGraphs.Legends.Add(legend2);
            this.urineGraphs.Location = new System.Drawing.Point(53, 12);
            this.urineGraphs.Name = "urineGraphs";
            this.urineGraphs.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series3.Legend = "Legend1";
            series3.Name = "Serum Creatinine";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Blue;
            series4.Legend = "Legend1";
            series4.Name = "Estimated GFR";
            this.urineGraphs.Series.Add(series3);
            this.urineGraphs.Series.Add(series4);
            this.urineGraphs.Size = new System.Drawing.Size(724, 347);
            this.urineGraphs.TabIndex = 15;
            this.urineGraphs.Text = "urineGraphs";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 441);
            this.panel1.TabIndex = 14;
            // 
            // CreatinineAnd_eGFR_Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.urineGraphs);
            this.Controls.Add(this.panel1);
            this.Name = "CreatinineAnd_eGFR_Graphs";
            this.Text = "CreatinineAnd_eGFR_Graphs";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urineGraphs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbEG;
        private System.Windows.Forms.CheckBox cbSC;
        private System.Windows.Forms.DataVisualization.Charting.Chart urineGraphs;
        private System.Windows.Forms.Panel panel1;
    }
}