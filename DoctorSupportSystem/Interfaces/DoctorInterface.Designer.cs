namespace DoctorSupportSystem.Interfaces
{
    partial class DoctorInterface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorInterface));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Patients = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchPatients = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLoadPatients = new System.Windows.Forms.Button();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.Users = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchUsers = new System.Windows.Forms.TextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnLoadUsers = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnPrfileLiverTest = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtnHaemoglobinTest = new System.Windows.Forms.RadioButton();
            this.rbtnUrineTest = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtnCreatinineTest = new System.Windows.Forms.RadioButton();
            this.rbtnLipidTest = new System.Windows.Forms.RadioButton();
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbSearchPatients = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddMedicalReport = new System.Windows.Forms.Button();
            this.btnAddPatientProfile = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnUserProChange = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Patients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Patients);
            this.tabControl1.Controls.Add(this.Users);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 30);
            this.tabControl1.Location = new System.Drawing.Point(124, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 624);
            this.tabControl1.TabIndex = 0;
            // 
            // Patients
            // 
            this.Patients.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Patients.Controls.Add(this.label5);
            this.Patients.Controls.Add(this.txtSearchPatients);
            this.Patients.Controls.Add(this.button2);
            this.Patients.Controls.Add(this.btnLoadPatients);
            this.Patients.Controls.Add(this.dgvPatients);
            this.Patients.Location = new System.Drawing.Point(4, 34);
            this.Patients.Name = "Patients";
            this.Patients.Padding = new System.Windows.Forms.Padding(3);
            this.Patients.Size = new System.Drawing.Size(687, 586);
            this.Patients.TabIndex = 0;
            this.Patients.Text = "Patients";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Search Patients";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSearchPatients
            // 
            this.txtSearchPatients.Location = new System.Drawing.Point(117, 37);
            this.txtSearchPatients.Name = "txtSearchPatients";
            this.txtSearchPatients.Size = new System.Drawing.Size(167, 22);
            this.txtSearchPatients.TabIndex = 3;
            this.txtSearchPatients.TextChanged += new System.EventHandler(this.txtSearchPatients_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(6, 542);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show Test Results";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnLoadPatients
            // 
            this.btnLoadPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadPatients.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoadPatients.FlatAppearance.BorderSize = 0;
            this.btnLoadPatients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoadPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPatients.ForeColor = System.Drawing.Color.White;
            this.btnLoadPatients.Location = new System.Drawing.Point(550, 542);
            this.btnLoadPatients.Name = "btnLoadPatients";
            this.btnLoadPatients.Size = new System.Drawing.Size(131, 38);
            this.btnLoadPatients.TabIndex = 1;
            this.btnLoadPatients.Text = "Refresh Patients";
            this.btnLoadPatients.UseVisualStyleBackColor = false;
            this.btnLoadPatients.Click += new System.EventHandler(this.btnLoadPatients_Click);
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.EnableHeadersVisualStyles = false;
            this.dgvPatients.Location = new System.Drawing.Point(6, 72);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(675, 464);
            this.dgvPatients.TabIndex = 0;
            this.dgvPatients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseClick);
            // 
            // Users
            // 
            this.Users.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Users.Controls.Add(this.label7);
            this.Users.Controls.Add(this.txtSearchUsers);
            this.Users.Controls.Add(this.dgvUsers);
            this.Users.Controls.Add(this.btnLoadUsers);
            this.Users.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Users.Location = new System.Drawing.Point(4, 34);
            this.Users.Name = "Users";
            this.Users.Padding = new System.Windows.Forms.Padding(3);
            this.Users.Size = new System.Drawing.Size(687, 586);
            this.Users.TabIndex = 1;
            this.Users.Text = "Users";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(8, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Search Users";
            // 
            // txtSearchUsers
            // 
            this.txtSearchUsers.Location = new System.Drawing.Point(117, 37);
            this.txtSearchUsers.Name = "txtSearchUsers";
            this.txtSearchUsers.Size = new System.Drawing.Size(167, 22);
            this.txtSearchUsers.TabIndex = 5;
            this.txtSearchUsers.TextChanged += new System.EventHandler(this.txtSearchUsers_TextChanged);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Location = new System.Drawing.Point(6, 73);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(675, 463);
            this.dgvUsers.TabIndex = 0;
            // 
            // btnLoadUsers
            // 
            this.btnLoadUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadUsers.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoadUsers.FlatAppearance.BorderSize = 0;
            this.btnLoadUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoadUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadUsers.ForeColor = System.Drawing.Color.White;
            this.btnLoadUsers.Location = new System.Drawing.Point(550, 542);
            this.btnLoadUsers.Name = "btnLoadUsers";
            this.btnLoadUsers.Size = new System.Drawing.Size(131, 38);
            this.btnLoadUsers.TabIndex = 2;
            this.btnLoadUsers.Text = "Refresh Users";
            this.btnLoadUsers.UseVisualStyleBackColor = false;
            this.btnLoadUsers.Click += new System.EventHandler(this.btnLoadUsers_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddTest);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(687, 586);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddTest
            // 
            this.btnAddTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddTest.FlatAppearance.BorderSize = 0;
            this.btnAddTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTest.ForeColor = System.Drawing.Color.White;
            this.btnAddTest.Location = new System.Drawing.Point(3, 548);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(156, 35);
            this.btnAddTest.TabIndex = 15;
            this.btnAddTest.Text = "Add Selected Test";
            this.btnAddTest.UseVisualStyleBackColor = false;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.rbtnPrfileLiverTest);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.rbtnHaemoglobinTest);
            this.panel2.Controls.Add(this.rbtnUrineTest);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.rbtnCreatinineTest);
            this.panel2.Controls.Add(this.rbtnLipidTest);
            this.panel2.Location = new System.Drawing.Point(3, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 169);
            this.panel2.TabIndex = 14;
            // 
            // rbtnPrfileLiverTest
            // 
            this.rbtnPrfileLiverTest.AutoSize = true;
            this.rbtnPrfileLiverTest.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rbtnPrfileLiverTest.Location = new System.Drawing.Point(18, 108);
            this.rbtnPrfileLiverTest.Name = "rbtnPrfileLiverTest";
            this.rbtnPrfileLiverTest.Size = new System.Drawing.Size(162, 20);
            this.rbtnPrfileLiverTest.TabIndex = 6;
            this.rbtnPrfileLiverTest.TabStop = true;
            this.rbtnPrfileLiverTest.Text = "PROFILE LIVER TEST";
            this.rbtnPrfileLiverTest.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(681, 30);
            this.panel4.TabIndex = 9;
            // 
            // rbtnHaemoglobinTest
            // 
            this.rbtnHaemoglobinTest.AutoSize = true;
            this.rbtnHaemoglobinTest.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rbtnHaemoglobinTest.Location = new System.Drawing.Point(18, 43);
            this.rbtnHaemoglobinTest.Name = "rbtnHaemoglobinTest";
            this.rbtnHaemoglobinTest.Size = new System.Drawing.Size(258, 20);
            this.rbtnHaemoglobinTest.TabIndex = 4;
            this.rbtnHaemoglobinTest.TabStop = true;
            this.rbtnHaemoglobinTest.Text = "HAEMOGLOBIN A1C (%HBA1C) TEST";
            this.rbtnHaemoglobinTest.UseVisualStyleBackColor = false;
            // 
            // rbtnUrineTest
            // 
            this.rbtnUrineTest.AutoSize = true;
            this.rbtnUrineTest.Location = new System.Drawing.Point(18, 140);
            this.rbtnUrineTest.Name = "rbtnUrineTest";
            this.rbtnUrineTest.Size = new System.Drawing.Size(246, 20);
            this.rbtnUrineTest.TabIndex = 7;
            this.rbtnUrineTest.TabStop = true;
            this.rbtnUrineTest.Text = "URINE FOR MICRO ALBUMIN TEST";
            this.rbtnUrineTest.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 30);
            this.panel3.TabIndex = 8;
            // 
            // rbtnCreatinineTest
            // 
            this.rbtnCreatinineTest.AutoSize = true;
            this.rbtnCreatinineTest.Location = new System.Drawing.Point(18, 13);
            this.rbtnCreatinineTest.Name = "rbtnCreatinineTest";
            this.rbtnCreatinineTest.Size = new System.Drawing.Size(217, 20);
            this.rbtnCreatinineTest.TabIndex = 3;
            this.rbtnCreatinineTest.TabStop = true;
            this.rbtnCreatinineTest.Text = "CREATININE AND eGFR TEST";
            this.rbtnCreatinineTest.UseVisualStyleBackColor = true;
            // 
            // rbtnLipidTest
            // 
            this.rbtnLipidTest.AutoSize = true;
            this.rbtnLipidTest.Location = new System.Drawing.Point(18, 75);
            this.rbtnLipidTest.Name = "rbtnLipidTest";
            this.rbtnLipidTest.Size = new System.Drawing.Size(117, 20);
            this.rbtnLipidTest.TabIndex = 5;
            this.rbtnLipidTest.TabStop = true;
            this.rbtnLipidTest.Text = "LIPID PROFILE";
            this.rbtnLipidTest.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.Controls.Add(this.panel12);
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.cbSearchPatients);
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(684, 339);
            this.panel5.TabIndex = 13;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel12.Controls.Add(this.label3);
            this.panel12.Controls.Add(this.lbCN);
            this.panel12.Location = new System.Drawing.Point(27, 287);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(358, 31);
            this.panel12.TabIndex = 17;
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
            this.lbCN.Size = new System.Drawing.Size(12, 16);
            this.lbCN.TabIndex = 13;
            this.lbCN.Text = "-";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel11.Controls.Add(this.label12);
            this.panel11.Controls.Add(this.lbNIC);
            this.panel11.Location = new System.Drawing.Point(27, 250);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(358, 31);
            this.panel11.TabIndex = 15;
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
            this.lbNIC.Size = new System.Drawing.Size(12, 16);
            this.lbNIC.TabIndex = 13;
            this.lbNIC.Text = "-";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.lbG);
            this.panel10.Location = new System.Drawing.Point(27, 213);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(358, 31);
            this.panel10.TabIndex = 16;
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
            this.lbG.Size = new System.Drawing.Size(12, 16);
            this.lbG.TabIndex = 13;
            this.lbG.Text = "-";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.lbDOB);
            this.panel9.Location = new System.Drawing.Point(27, 176);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(358, 31);
            this.panel9.TabIndex = 15;
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
            this.lbDOB.Size = new System.Drawing.Size(12, 16);
            this.lbDOB.TabIndex = 13;
            this.lbDOB.Text = "-";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.lbLN);
            this.panel8.Location = new System.Drawing.Point(27, 139);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(358, 31);
            this.panel8.TabIndex = 15;
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
            this.lbLN.Size = new System.Drawing.Size(12, 16);
            this.lbLN.TabIndex = 13;
            this.lbLN.Text = "-";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.lbFN);
            this.panel7.Location = new System.Drawing.Point(27, 102);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(358, 31);
            this.panel7.TabIndex = 15;
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
            this.lbFN.Size = new System.Drawing.Size(12, 16);
            this.lbFN.TabIndex = 13;
            this.lbFN.Text = "-";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.lbPID);
            this.panel6.Location = new System.Drawing.Point(27, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(358, 31);
            this.panel6.TabIndex = 14;
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
            this.lbPID.Size = new System.Drawing.Size(12, 16);
            this.lbPID.TabIndex = 13;
            this.lbPID.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter the patient name";
            // 
            // cbSearchPatients
            // 
            this.cbSearchPatients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSearchPatients.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSearchPatients.FormattingEnabled = true;
            this.cbSearchPatients.Location = new System.Drawing.Point(191, 18);
            this.cbSearchPatients.Name = "cbSearchPatients";
            this.cbSearchPatients.Size = new System.Drawing.Size(194, 24);
            this.cbSearchPatients.TabIndex = 10;
            this.cbSearchPatients.TextChanged += new System.EventHandler(this.cbSearchPatients_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add User";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnAddMedicalReport);
            this.panel1.Controls.Add(this.btnAddPatientProfile);
            this.panel1.Controls.Add(this.btnAddPatient);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 718);
            this.panel1.TabIndex = 1;
            // 
            // btnAddMedicalReport
            // 
            this.btnAddMedicalReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddMedicalReport.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddMedicalReport.FlatAppearance.BorderSize = 0;
            this.btnAddMedicalReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddMedicalReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicalReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicalReport.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicalReport.Location = new System.Drawing.Point(0, 295);
            this.btnAddMedicalReport.Name = "btnAddMedicalReport";
            this.btnAddMedicalReport.Size = new System.Drawing.Size(122, 65);
            this.btnAddMedicalReport.TabIndex = 11;
            this.btnAddMedicalReport.Text = "Add Medical Report";
            this.btnAddMedicalReport.UseVisualStyleBackColor = false;
            // 
            // btnAddPatientProfile
            // 
            this.btnAddPatientProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddPatientProfile.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddPatientProfile.FlatAppearance.BorderSize = 0;
            this.btnAddPatientProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddPatientProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatientProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatientProfile.ForeColor = System.Drawing.Color.White;
            this.btnAddPatientProfile.Location = new System.Drawing.Point(0, 224);
            this.btnAddPatientProfile.Name = "btnAddPatientProfile";
            this.btnAddPatientProfile.Size = new System.Drawing.Size(122, 65);
            this.btnAddPatientProfile.TabIndex = 3;
            this.btnAddPatientProfile.Text = "Add  PatientProfile";
            this.btnAddPatientProfile.UseVisualStyleBackColor = false;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddPatient.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddPatient.FlatAppearance.BorderSize = 0;
            this.btnAddPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.Location = new System.Drawing.Point(0, 153);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(122, 65);
            this.btnAddPatient.TabIndex = 2;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnUserProChange
            // 
            this.btnUserProChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserProChange.Image = ((System.Drawing.Image)(resources.GetObject("btnUserProChange.Image")));
            this.btnUserProChange.Location = new System.Drawing.Point(763, 12);
            this.btnUserProChange.Name = "btnUserProChange";
            this.btnUserProChange.Size = new System.Drawing.Size(56, 52);
            this.btnUserProChange.TabIndex = 10;
            this.btnUserProChange.UseVisualStyleBackColor = true;
            // 
            // DoctorInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 718);
            this.Controls.Add(this.btnUserProChange);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DoctorInterface";
            this.Text = "Doctor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.Patients.ResumeLayout(false);
            this.Patients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.Users.ResumeLayout(false);
            this.Users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Patients;
        private System.Windows.Forms.TabPage Users;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Button btnLoadPatients;
        private System.Windows.Forms.Button btnLoadUsers;
        private System.Windows.Forms.Button btnUserProChange;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSearchPatients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnPrfileLiverTest;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtnHaemoglobinTest;
        private System.Windows.Forms.RadioButton rbtnUrineTest;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtnCreatinineTest;
        private System.Windows.Forms.RadioButton rbtnLipidTest;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnAddMedicalReport;
        private System.Windows.Forms.Button btnAddPatientProfile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSearchPatients;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchUsers;
    }
}