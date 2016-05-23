namespace DoctorSupportSystem.Interfaces.Reports
{
    partial class UrineTestGraphs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.urineGraphs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbUrineMA = new System.Windows.Forms.CheckBox();
            this.cbUrineC = new System.Windows.Forms.CheckBox();
            this.cbUrineAC = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.urineGraphs)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 444);
            this.panel1.TabIndex = 11;
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
            this.urineGraphs.Location = new System.Drawing.Point(53, 12);
            this.urineGraphs.Name = "urineGraphs";
            this.urineGraphs.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Urine for Micro Albumin";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Urine Creatinine";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Urine Albumin/Creatinine";
            this.urineGraphs.Series.Add(series1);
            this.urineGraphs.Series.Add(series2);
            this.urineGraphs.Series.Add(series3);
            this.urineGraphs.Size = new System.Drawing.Size(724, 347);
            this.urineGraphs.TabIndex = 12;
            this.urineGraphs.Text = "urineGraphs";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbUrineAC);
            this.panel2.Controls.Add(this.cbUrineC);
            this.panel2.Controls.Add(this.cbUrineMA);
            this.panel2.Location = new System.Drawing.Point(53, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 28);
            this.panel2.TabIndex = 13;
            // 
            // cbUrineMA
            // 
            this.cbUrineMA.AutoSize = true;
            this.cbUrineMA.Checked = true;
            this.cbUrineMA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUrineMA.Location = new System.Drawing.Point(3, 3);
            this.cbUrineMA.Name = "cbUrineMA";
            this.cbUrineMA.Size = new System.Drawing.Size(135, 17);
            this.cbUrineMA.TabIndex = 0;
            this.cbUrineMA.Text = "Urine for Micro Albumin";
            this.cbUrineMA.UseVisualStyleBackColor = true;
            this.cbUrineMA.CheckedChanged += new System.EventHandler(this.cbUrineMA_CheckedChanged);
            // 
            // cbUrineC
            // 
            this.cbUrineC.AutoSize = true;
            this.cbUrineC.Checked = true;
            this.cbUrineC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUrineC.Location = new System.Drawing.Point(158, 3);
            this.cbUrineC.Name = "cbUrineC";
            this.cbUrineC.Size = new System.Drawing.Size(101, 17);
            this.cbUrineC.TabIndex = 1;
            this.cbUrineC.Text = "Urine Creatinine";
            this.cbUrineC.UseVisualStyleBackColor = true;
            this.cbUrineC.CheckedChanged += new System.EventHandler(this.cbUrineC_CheckedChanged);
            // 
            // cbUrineAC
            // 
            this.cbUrineAC.AutoSize = true;
            this.cbUrineAC.Checked = true;
            this.cbUrineAC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUrineAC.Location = new System.Drawing.Point(298, 3);
            this.cbUrineAC.Name = "cbUrineAC";
            this.cbUrineAC.Size = new System.Drawing.Size(143, 17);
            this.cbUrineAC.TabIndex = 2;
            this.cbUrineAC.Text = "Urine Albumin/Creatinine";
            this.cbUrineAC.UseVisualStyleBackColor = true;
            this.cbUrineAC.CheckedChanged += new System.EventHandler(this.cbUrineAC_CheckedChanged);
            // 
            // UrineTestGraphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 444);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.urineGraphs);
            this.Controls.Add(this.panel1);
            this.Name = "UrineTestGraphs";
            this.Text = "UrineTestGraphs";
            ((System.ComponentModel.ISupportInitialize)(this.urineGraphs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart urineGraphs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbUrineAC;
        private System.Windows.Forms.CheckBox cbUrineC;
        private System.Windows.Forms.CheckBox cbUrineMA;
    }
}