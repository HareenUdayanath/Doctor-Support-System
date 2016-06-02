namespace DoctorSupportSystem.Interfaces.Reports
{
    partial class PatientProfile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadPatients = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mIPatientDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.testResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCreatinineTest = new System.Windows.Forms.ToolStripMenuItem();
            this.miHaemoglobinTest = new System.Windows.Forms.ToolStripMenuItem();
            this.miLipidTest = new System.Windows.Forms.ToolStripMenuItem();
            this.miProfileLiverTest = new System.Windows.Forms.ToolStripMenuItem();
            this.miUrineTest = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDeseaeReports = new System.Windows.Forms.DataGridView();
            this.btnRefreshReports = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeseaeReports)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 529);
            this.panel1.TabIndex = 3;
            // 
            // btnLoadPatients
            // 
            this.btnLoadPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadPatients.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoadPatients.FlatAppearance.BorderSize = 0;
            this.btnLoadPatients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoadPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPatients.ForeColor = System.Drawing.Color.White;
            this.btnLoadPatients.Location = new System.Drawing.Point(103, 514);
            this.btnLoadPatients.Name = "btnLoadPatients";
            this.btnLoadPatients.Size = new System.Drawing.Size(123, 29);
            this.btnLoadPatients.TabIndex = 13;
            this.btnLoadPatients.Text = "Add Test";
            this.btnLoadPatients.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mIPatientDetails,
            this.testResultsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mIPatientDetails
            // 
            this.mIPatientDetails.Name = "mIPatientDetails";
            this.mIPatientDetails.Size = new System.Drawing.Size(94, 20);
            this.mIPatientDetails.Text = "Patient Details";
            this.mIPatientDetails.Click += new System.EventHandler(this.mIPatientDetails_Click);
            // 
            // testResultsToolStripMenuItem
            // 
            this.testResultsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCreatinineTest,
            this.miHaemoglobinTest,
            this.miLipidTest,
            this.miProfileLiverTest,
            this.miUrineTest});
            this.testResultsToolStripMenuItem.Name = "testResultsToolStripMenuItem";
            this.testResultsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.testResultsToolStripMenuItem.Text = "Test Results";
            // 
            // miCreatinineTest
            // 
            this.miCreatinineTest.Name = "miCreatinineTest";
            this.miCreatinineTest.Size = new System.Drawing.Size(272, 22);
            this.miCreatinineTest.Text = "CREATININE AND eGFR TEST";
            this.miCreatinineTest.Click += new System.EventHandler(this.miCreatinineTest_Click);
            // 
            // miHaemoglobinTest
            // 
            this.miHaemoglobinTest.Name = "miHaemoglobinTest";
            this.miHaemoglobinTest.Size = new System.Drawing.Size(272, 22);
            this.miHaemoglobinTest.Text = "HAEMOGLOBIN A1C (%HBA1C) TEST";
            this.miHaemoglobinTest.Click += new System.EventHandler(this.miHaemoglobinTest_Click);
            // 
            // miLipidTest
            // 
            this.miLipidTest.Name = "miLipidTest";
            this.miLipidTest.Size = new System.Drawing.Size(272, 22);
            this.miLipidTest.Text = "LIPID PROFILE";
            this.miLipidTest.Click += new System.EventHandler(this.miLipidTest_Click);
            // 
            // miProfileLiverTest
            // 
            this.miProfileLiverTest.Name = "miProfileLiverTest";
            this.miProfileLiverTest.Size = new System.Drawing.Size(272, 22);
            this.miProfileLiverTest.Text = "PROFILE LIVER TEST";
            this.miProfileLiverTest.Click += new System.EventHandler(this.miProfileLiverTest_Click);
            // 
            // miUrineTest
            // 
            this.miUrineTest.Name = "miUrineTest";
            this.miUrineTest.Size = new System.Drawing.Size(272, 22);
            this.miUrineTest.Text = "URINE FOR MICRO ALBUMIN TEST";
            this.miUrineTest.Click += new System.EventHandler(this.miUrineTest_Click);
            // 
            // dgvDeseaeReports
            // 
            this.dgvDeseaeReports.AllowUserToAddRows = false;
            this.dgvDeseaeReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeseaeReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeseaeReports.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeseaeReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeseaeReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeseaeReports.EnableHeadersVisualStyles = false;
            this.dgvDeseaeReports.Location = new System.Drawing.Point(103, 85);
            this.dgvDeseaeReports.Name = "dgvDeseaeReports";
            this.dgvDeseaeReports.ReadOnly = true;
            this.dgvDeseaeReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeseaeReports.Size = new System.Drawing.Size(566, 350);
            this.dgvDeseaeReports.TabIndex = 16;
            this.dgvDeseaeReports.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDeseaeReports_MouseClick);
            // 
            // btnRefreshReports
            // 
            this.btnRefreshReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshReports.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRefreshReports.FlatAppearance.BorderSize = 0;
            this.btnRefreshReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRefreshReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshReports.ForeColor = System.Drawing.Color.White;
            this.btnRefreshReports.Location = new System.Drawing.Point(523, 503);
            this.btnRefreshReports.Name = "btnRefreshReports";
            this.btnRefreshReports.Size = new System.Drawing.Size(146, 38);
            this.btnRefreshReports.TabIndex = 17;
            this.btnRefreshReports.Text = "Refresh Desease Reports";
            this.btnRefreshReports.UseVisualStyleBackColor = false;
            this.btnRefreshReports.Click += new System.EventHandler(this.btnRefreshReports_Click);
            // 
            // PatientProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 553);
            this.Controls.Add(this.btnRefreshReports);
            this.Controls.Add(this.dgvDeseaeReports);
            this.Controls.Add(this.btnLoadPatients);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PatientProfile";
            this.Text = "PatientProfile";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeseaeReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadPatients;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mIPatientDetails;
        private System.Windows.Forms.ToolStripMenuItem testResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCreatinineTest;
        private System.Windows.Forms.ToolStripMenuItem miHaemoglobinTest;
        private System.Windows.Forms.ToolStripMenuItem miLipidTest;
        private System.Windows.Forms.ToolStripMenuItem miProfileLiverTest;
        private System.Windows.Forms.ToolStripMenuItem miUrineTest;
        private System.Windows.Forms.DataGridView dgvDeseaeReports;
        private System.Windows.Forms.Button btnRefreshReports;
    }
}