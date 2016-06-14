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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LipidGraphs));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbLDL = new System.Windows.Forms.CheckBox();
            this.cbCHOL = new System.Windows.Forms.CheckBox();
            this.cbCVLDL = new System.Windows.Forms.CheckBox();
            this.cbCLDL = new System.Windows.Forms.CheckBox();
            this.cbCHDL = new System.Windows.Forms.CheckBox();
            this.cbT = new System.Windows.Forms.CheckBox();
            this.cbCT = new System.Windows.Forms.CheckBox();
            this.lipidGraphs1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lipidGraphs1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.cbLDL);
            this.panel2.Controls.Add(this.cbCHOL);
            this.panel2.Controls.Add(this.cbCVLDL);
            this.panel2.Controls.Add(this.cbCLDL);
            this.panel2.Controls.Add(this.cbCHDL);
            this.panel2.Controls.Add(this.cbT);
            this.panel2.Controls.Add(this.cbCT);
            this.panel2.Location = new System.Drawing.Point(12, 573);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1328, 62);
            this.panel2.TabIndex = 19;
            // 
            // cbLDL
            // 
            this.cbLDL.AutoSize = true;
            this.cbLDL.Checked = true;
            this.cbLDL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLDL.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLDL.Location = new System.Drawing.Point(412, 16);
            this.cbLDL.Name = "cbLDL";
            this.cbLDL.Size = new System.Drawing.Size(104, 27);
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
            this.cbCHOL.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCHOL.Location = new System.Drawing.Point(18, 16);
            this.cbCHOL.Name = "cbCHOL";
            this.cbCHOL.Size = new System.Drawing.Size(119, 27);
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
            this.cbCVLDL.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCVLDL.Location = new System.Drawing.Point(1132, 16);
            this.cbCVLDL.Name = "cbCVLDL";
            this.cbCVLDL.Size = new System.Drawing.Size(172, 27);
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
            this.cbCLDL.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCLDL.Location = new System.Drawing.Point(948, 16);
            this.cbCLDL.Name = "cbCLDL";
            this.cbCLDL.Size = new System.Drawing.Size(158, 27);
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
            this.cbCHDL.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCHDL.Location = new System.Drawing.Point(753, 16);
            this.cbCHDL.Name = "cbCHDL";
            this.cbCHDL.Size = new System.Drawing.Size(175, 27);
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
            this.cbT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbT.Location = new System.Drawing.Point(581, 16);
            this.cbT.Name = "cbT";
            this.cbT.Size = new System.Drawing.Size(125, 27);
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
            this.cbCT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCT.Location = new System.Drawing.Point(189, 16);
            this.cbCT.Name = "cbCT";
            this.cbCT.Size = new System.Drawing.Size(166, 27);
            this.cbCT.TabIndex = 0;
            this.cbCT.Text = "Cholesterol - Total";
            this.cbCT.UseVisualStyleBackColor = true;
            this.cbCT.CheckedChanged += new System.EventHandler(this.cbCT_CheckedChanged);
            // 
            // lipidGraphs1
            // 
            this.lipidGraphs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lipidGraphs1.BorderlineColor = System.Drawing.Color.Black;
            this.lipidGraphs1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.lipidGraphs1.ChartAreas.Add(chartArea4);
            legend4.BorderColor = System.Drawing.Color.Transparent;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.Name = "Legend1";
            this.lipidGraphs1.Legends.Add(legend4);
            this.lipidGraphs1.Location = new System.Drawing.Point(12, 94);
            this.lipidGraphs1.Name = "lipidGraphs1";
            this.lipidGraphs1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series22.BorderWidth = 2;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series22.Legend = "Legend1";
            series22.MarkerSize = 8;
            series22.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series22.Name = "Cholesterol - Total";
            series23.BorderWidth = 2;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Color = System.Drawing.Color.Blue;
            series23.Legend = "Legend1";
            series23.MarkerSize = 8;
            series23.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series23.Name = "Triglycerides";
            series24.BorderWidth = 2;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Legend = "Legend1";
            series24.MarkerSize = 8;
            series24.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series24.Name = "Cholesterol – H.D.L";
            series25.BorderWidth = 2;
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series25.Legend = "Legend1";
            series25.MarkerSize = 8;
            series25.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series25.Name = "Cholesterol L.D.L";
            series26.BorderWidth = 2;
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series26.Legend = "Legend1";
            series26.MarkerSize = 8;
            series26.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series26.Name = "Cholesterol – VLDL";
            series27.BorderWidth = 2;
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series27.Legend = "Legend1";
            series27.MarkerSize = 8;
            series27.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series27.Name = "CHOL / HDL";
            series28.BorderWidth = 2;
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series28.Legend = "Legend1";
            series28.MarkerSize = 8;
            series28.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series28.Name = "LDL / HDL";
            this.lipidGraphs1.Series.Add(series22);
            this.lipidGraphs1.Series.Add(series23);
            this.lipidGraphs1.Series.Add(series24);
            this.lipidGraphs1.Series.Add(series25);
            this.lipidGraphs1.Series.Add(series26);
            this.lipidGraphs1.Series.Add(series27);
            this.lipidGraphs1.Series.Add(series28);
            this.lipidGraphs1.Size = new System.Drawing.Size(1328, 473);
            this.lipidGraphs1.TabIndex = 18;
            this.lipidGraphs1.Text = "urineGraphs";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Teal;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 641);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1350, 88);
            this.panel13.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 88);
            this.panel1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = " LIPID PROFILE TEST ";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Teal;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1230, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Teal;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1286, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LipidGraphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lipidGraphs1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LipidGraphs";
            this.Text = "LipidGraphs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lipidGraphs1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart lipidGraphs1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClose;
    }
}