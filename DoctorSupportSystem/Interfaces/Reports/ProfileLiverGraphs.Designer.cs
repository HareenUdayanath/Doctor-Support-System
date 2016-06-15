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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileLiverGraphs));
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
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileGraphs)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(17, 573);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1319, 62);
            this.panel2.TabIndex = 16;
            // 
            // cbGamma
            // 
            this.cbGamma.AutoSize = true;
            this.cbGamma.Checked = true;
            this.cbGamma.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGamma.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGamma.Location = new System.Drawing.Point(1013, 16);
            this.cbGamma.Name = "cbGamma";
            this.cbGamma.Size = new System.Drawing.Size(116, 27);
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
            this.cbAST.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAST.Location = new System.Drawing.Point(1172, 16);
            this.cbAST.Name = "cbAST";
            this.cbAST.Size = new System.Drawing.Size(131, 27);
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
            this.cbALT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbALT.Location = new System.Drawing.Point(376, 16);
            this.cbALT.Name = "cbALT";
            this.cbALT.Size = new System.Drawing.Size(124, 27);
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
            this.cbALK_P.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbALK_P.Location = new System.Drawing.Point(825, 16);
            this.cbALK_P.Name = "cbALK_P";
            this.cbALK_P.Size = new System.Drawing.Size(166, 27);
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
            this.cbBT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBT.Location = new System.Drawing.Point(656, 16);
            this.cbBT.Name = "cbBT";
            this.cbBT.Size = new System.Drawing.Size(145, 27);
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
            this.cbAG_R.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAG_R.Location = new System.Drawing.Point(526, 16);
            this.cbAG_R.Name = "cbAG_R";
            this.cbAG_R.Size = new System.Drawing.Size(103, 27);
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
            this.cbGlobuin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGlobuin.Location = new System.Drawing.Point(257, 16);
            this.cbGlobuin.Name = "cbGlobuin";
            this.cbGlobuin.Size = new System.Drawing.Size(89, 27);
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
            this.cbALbumin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbALbumin.Location = new System.Drawing.Point(146, 16);
            this.cbALbumin.Name = "cbALbumin";
            this.cbALbumin.Size = new System.Drawing.Size(93, 27);
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
            this.cbTotPro.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTotPro.Location = new System.Drawing.Point(3, 16);
            this.cbTotPro.Name = "cbTotPro";
            this.cbTotPro.Size = new System.Drawing.Size(125, 27);
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
            this.profileGraphs.Location = new System.Drawing.Point(17, 94);
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
            this.profileGraphs.Size = new System.Drawing.Size(1321, 473);
            this.profileGraphs.TabIndex = 15;
            this.profileGraphs.Text = "urineGraphs";
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
            this.panel1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "PROFILE LIVER TEST ";
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
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Teal;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 641);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1350, 88);
            this.panel13.TabIndex = 23;
            // 
            // ProfileLiverGraphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.profileGraphs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileLiverGraphs";
            this.Text = "ProfileLiverGraphs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProfileLiverGraphs_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileGraphs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbGlobuin;
        private System.Windows.Forms.CheckBox cbALbumin;
        private System.Windows.Forms.CheckBox cbTotPro;
        private System.Windows.Forms.DataVisualization.Charting.Chart profileGraphs;
        private System.Windows.Forms.CheckBox cbALT;
        private System.Windows.Forms.CheckBox cbALK_P;
        private System.Windows.Forms.CheckBox cbBT;
        private System.Windows.Forms.CheckBox cbAG_R;
        private System.Windows.Forms.CheckBox cbGamma;
        private System.Windows.Forms.CheckBox cbAST;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel13;
    }
}