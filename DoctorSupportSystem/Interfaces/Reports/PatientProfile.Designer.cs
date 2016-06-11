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
            this.testResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCreatinineTest = new System.Windows.Forms.ToolStripMenuItem();
            this.miHaemoglobinTest = new System.Windows.Forms.ToolStripMenuItem();
            this.miLipidTest = new System.Windows.Forms.ToolStripMenuItem();
            this.miProfileLiverTest = new System.Windows.Forms.ToolStripMenuItem();
            this.miUrineTest = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDeseaeReports = new System.Windows.Forms.DataGridView();
            this.btnRefreshReports = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCN = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lbNIC = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbG = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbLN = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFN = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPID = new System.Windows.Forms.Label();
            this.btnAddReseaseRecord = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeseaeReports)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.testResultsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
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
            this.dgvDeseaeReports.Location = new System.Drawing.Point(505, 99);
            this.dgvDeseaeReports.Name = "dgvDeseaeReports";
            this.dgvDeseaeReports.ReadOnly = true;
            this.dgvDeseaeReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeseaeReports.Size = new System.Drawing.Size(288, 398);
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
            this.btnRefreshReports.Location = new System.Drawing.Point(647, 503);
            this.btnRefreshReports.Name = "btnRefreshReports";
            this.btnRefreshReports.Size = new System.Drawing.Size(146, 38);
            this.btnRefreshReports.TabIndex = 17;
            this.btnRefreshReports.Text = "Refresh Desease Record";
            this.btnRefreshReports.UseVisualStyleBackColor = false;
            this.btnRefreshReports.Click += new System.EventHandler(this.btnRefreshReports_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.Controls.Add(this.panel12);
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(103, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(396, 470);
            this.panel5.TabIndex = 18;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel12.Controls.Add(this.label3);
            this.panel12.Controls.Add(this.lbCN);
            this.panel12.Location = new System.Drawing.Point(18, 238);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(358, 31);
            this.panel12.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contact Number :\r\n";
            // 
            // lbCN
            // 
            this.lbCN.AutoSize = true;
            this.lbCN.Location = new System.Drawing.Point(156, 9);
            this.lbCN.Name = "lbCN";
            this.lbCN.Size = new System.Drawing.Size(10, 13);
            this.lbCN.TabIndex = 13;
            this.lbCN.Text = "-";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel11.Controls.Add(this.label12);
            this.panel11.Controls.Add(this.lbNIC);
            this.panel11.Location = new System.Drawing.Point(18, 201);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(358, 31);
            this.panel11.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "NIC :\r\n";
            // 
            // lbNIC
            // 
            this.lbNIC.AutoSize = true;
            this.lbNIC.Location = new System.Drawing.Point(154, 9);
            this.lbNIC.Name = "lbNIC";
            this.lbNIC.Size = new System.Drawing.Size(10, 13);
            this.lbNIC.TabIndex = 13;
            this.lbNIC.Text = "-";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.lbG);
            this.panel10.Location = new System.Drawing.Point(18, 164);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(358, 31);
            this.panel10.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Gender :\r\n";
            // 
            // lbG
            // 
            this.lbG.AutoSize = true;
            this.lbG.Location = new System.Drawing.Point(155, 9);
            this.lbG.Name = "lbG";
            this.lbG.Size = new System.Drawing.Size(10, 13);
            this.lbG.TabIndex = 13;
            this.lbG.Text = "-";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.lbDOB);
            this.panel9.Location = new System.Drawing.Point(18, 127);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(358, 31);
            this.panel9.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Date of Birth :\r\n";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Location = new System.Drawing.Point(154, 9);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(10, 13);
            this.lbDOB.TabIndex = 13;
            this.lbDOB.Text = "-";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.lbLN);
            this.panel8.Location = new System.Drawing.Point(18, 90);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(358, 31);
            this.panel8.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Last Name :\r\n";
            // 
            // lbLN
            // 
            this.lbLN.AutoSize = true;
            this.lbLN.Location = new System.Drawing.Point(155, 9);
            this.lbLN.Name = "lbLN";
            this.lbLN.Size = new System.Drawing.Size(10, 13);
            this.lbLN.TabIndex = 13;
            this.lbLN.Text = "-";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.lbFN);
            this.panel7.Location = new System.Drawing.Point(18, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(358, 31);
            this.panel7.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "First Name :\r\n";
            // 
            // lbFN
            // 
            this.lbFN.AutoSize = true;
            this.lbFN.Location = new System.Drawing.Point(155, 9);
            this.lbFN.Name = "lbFN";
            this.lbFN.Size = new System.Drawing.Size(10, 13);
            this.lbFN.TabIndex = 13;
            this.lbFN.Text = "-";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.lbPID);
            this.panel6.Location = new System.Drawing.Point(18, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(358, 31);
            this.panel6.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "PID :\r\n";
            // 
            // lbPID
            // 
            this.lbPID.AutoSize = true;
            this.lbPID.Location = new System.Drawing.Point(155, 9);
            this.lbPID.Name = "lbPID";
            this.lbPID.Size = new System.Drawing.Size(10, 13);
            this.lbPID.TabIndex = 13;
            this.lbPID.Text = "-";
            // 
            // btnAddReseaseRecord
            // 
            this.btnAddReseaseRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddReseaseRecord.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddReseaseRecord.FlatAppearance.BorderSize = 0;
            this.btnAddReseaseRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddReseaseRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReseaseRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReseaseRecord.ForeColor = System.Drawing.Color.White;
            this.btnAddReseaseRecord.Location = new System.Drawing.Point(241, 514);
            this.btnAddReseaseRecord.Name = "btnAddReseaseRecord";
            this.btnAddReseaseRecord.Size = new System.Drawing.Size(136, 29);
            this.btnAddReseaseRecord.TabIndex = 19;
            this.btnAddReseaseRecord.Text = "Add Desease Record";
            this.btnAddReseaseRecord.UseVisualStyleBackColor = false;
            this.btnAddReseaseRecord.Click += new System.EventHandler(this.btnAddReseaseRecord_Click);
            // 
            // PatientProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 553);
            this.Controls.Add(this.btnAddReseaseRecord);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnRefreshReports);
            this.Controls.Add(this.dgvDeseaeReports);
            this.Controls.Add(this.btnLoadPatients);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PatientProfile";
            this.Text = "PatientProfile";
            this.Load += new System.EventHandler(this.PatientProfile_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeseaeReports)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadPatients;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCreatinineTest;
        private System.Windows.Forms.ToolStripMenuItem miHaemoglobinTest;
        private System.Windows.Forms.ToolStripMenuItem miLipidTest;
        private System.Windows.Forms.ToolStripMenuItem miProfileLiverTest;
        private System.Windows.Forms.ToolStripMenuItem miUrineTest;
        private System.Windows.Forms.DataGridView dgvDeseaeReports;
        private System.Windows.Forms.Button btnRefreshReports;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCN;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbNIC;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbG;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbLN;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbFN;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPID;
        private System.Windows.Forms.Button btnAddReseaseRecord;
    }
}