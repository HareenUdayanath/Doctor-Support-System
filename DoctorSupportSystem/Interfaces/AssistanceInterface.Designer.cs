namespace DoctorSupportSystem.Interfaces
{
    partial class AssistanceInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssistanceInterface));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Patients = new System.Windows.Forms.TabPage();
            this.btnLoadPatients = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Appointments = new System.Windows.Forms.TabPage();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnShowAppintments = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUserProChange = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Patients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Appointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Patients);
            this.tabControl1.Controls.Add(this.Appointments);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 30);
            this.tabControl1.Location = new System.Drawing.Point(53, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 701);
            this.tabControl1.TabIndex = 0;
            // 
            // Patients
            // 
            this.Patients.Controls.Add(this.btnLoadPatients);
            this.Patients.Controls.Add(this.dataGridView1);
            this.Patients.Location = new System.Drawing.Point(4, 34);
            this.Patients.Name = "Patients";
            this.Patients.Padding = new System.Windows.Forms.Padding(3);
            this.Patients.Size = new System.Drawing.Size(712, 571);
            this.Patients.TabIndex = 0;
            this.Patients.Text = "Patients";
            this.Patients.UseVisualStyleBackColor = true;
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
            this.btnLoadPatients.Location = new System.Drawing.Point(582, 260);
            this.btnLoadPatients.Name = "btnLoadPatients";
            this.btnLoadPatients.Size = new System.Drawing.Size(123, 38);
            this.btnLoadPatients.TabIndex = 3;
            this.btnLoadPatients.Text = "Load Patients";
            this.btnLoadPatients.UseVisualStyleBackColor = false;
            this.btnLoadPatients.Click += new System.EventHandler(this.btnLoadPatients_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(699, 200);
            this.dataGridView1.TabIndex = 2;
            // 
            // Appointments
            // 
            this.Appointments.Controls.Add(this.btnAddAppointment);
            this.Appointments.Controls.Add(this.dataGridView2);
            this.Appointments.Controls.Add(this.btnShowAppintments);
            this.Appointments.Location = new System.Drawing.Point(4, 34);
            this.Appointments.Name = "Appointments";
            this.Appointments.Padding = new System.Windows.Forms.Padding(3);
            this.Appointments.Size = new System.Drawing.Size(712, 571);
            this.Appointments.TabIndex = 1;
            this.Appointments.Text = "Appointments";
            this.Appointments.UseVisualStyleBackColor = true;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddAppointment.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddAppointment.FlatAppearance.BorderSize = 0;
            this.btnAddAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.Location = new System.Drawing.Point(6, 459);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(162, 38);
            this.btnAddAppointment.TabIndex = 11;
            this.btnAddAppointment.Text = "Add Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(684, 382);
            this.dataGridView2.TabIndex = 10;
            // 
            // btnShowAppintments
            // 
            this.btnShowAppintments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAppintments.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnShowAppintments.FlatAppearance.BorderSize = 0;
            this.btnShowAppintments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnShowAppintments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAppintments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAppintments.ForeColor = System.Drawing.Color.White;
            this.btnShowAppintments.Location = new System.Drawing.Point(525, 459);
            this.btnShowAppintments.Name = "btnShowAppintments";
            this.btnShowAppintments.Size = new System.Drawing.Size(162, 38);
            this.btnShowAppintments.TabIndex = 9;
            this.btnShowAppintments.Text = "Show Appointments";
            this.btnShowAppintments.UseVisualStyleBackColor = false;
            this.btnShowAppintments.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddTest);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(712, 663);
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
            this.btnAddTest.Location = new System.Drawing.Point(0, 579);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(123, 29);
            this.btnAddTest.TabIndex = 14;
            this.btnAddTest.Text = "Add Test";
            this.btnAddTest.UseVisualStyleBackColor = false;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.rbtnPrfileLiverTest);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.rbtnHaemoglobinTest);
            this.panel2.Controls.Add(this.rbtnUrineTest);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.rbtnCreatinineTest);
            this.panel2.Controls.Add(this.rbtnLipidTest);
            this.panel2.Location = new System.Drawing.Point(0, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 169);
            this.panel2.TabIndex = 13;
            // 
            // rbtnPrfileLiverTest
            // 
            this.rbtnPrfileLiverTest.AutoSize = true;
            this.rbtnPrfileLiverTest.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rbtnPrfileLiverTest.Location = new System.Drawing.Point(18, 108);
            this.rbtnPrfileLiverTest.Name = "rbtnPrfileLiverTest";
            this.rbtnPrfileLiverTest.Size = new System.Drawing.Size(167, 21);
            this.rbtnPrfileLiverTest.TabIndex = 6;
            this.rbtnPrfileLiverTest.TabStop = true;
            this.rbtnPrfileLiverTest.Text = "PROFILE LIVER TEST";
            this.rbtnPrfileLiverTest.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(474, 30);
            this.panel4.TabIndex = 9;
            // 
            // rbtnHaemoglobinTest
            // 
            this.rbtnHaemoglobinTest.AutoSize = true;
            this.rbtnHaemoglobinTest.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rbtnHaemoglobinTest.Location = new System.Drawing.Point(18, 43);
            this.rbtnHaemoglobinTest.Name = "rbtnHaemoglobinTest";
            this.rbtnHaemoglobinTest.Size = new System.Drawing.Size(269, 21);
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
            this.rbtnUrineTest.Size = new System.Drawing.Size(253, 21);
            this.rbtnUrineTest.TabIndex = 7;
            this.rbtnUrineTest.TabStop = true;
            this.rbtnUrineTest.Text = "URINE FOR MICRO ALBUMIN TEST";
            this.rbtnUrineTest.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 30);
            this.panel3.TabIndex = 8;
            // 
            // rbtnCreatinineTest
            // 
            this.rbtnCreatinineTest.AutoSize = true;
            this.rbtnCreatinineTest.Location = new System.Drawing.Point(18, 13);
            this.rbtnCreatinineTest.Name = "rbtnCreatinineTest";
            this.rbtnCreatinineTest.Size = new System.Drawing.Size(221, 21);
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
            this.rbtnLipidTest.Size = new System.Drawing.Size(121, 21);
            this.rbtnLipidTest.TabIndex = 5;
            this.rbtnLipidTest.TabStop = true;
            this.rbtnLipidTest.Text = "LIPID PROFILE";
            this.rbtnLipidTest.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
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
            this.panel5.Size = new System.Drawing.Size(709, 339);
            this.panel5.TabIndex = 12;
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
            this.lbCN.Size = new System.Drawing.Size(13, 17);
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
            this.lbNIC.Size = new System.Drawing.Size(13, 17);
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
            this.lbG.Size = new System.Drawing.Size(13, 17);
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
            this.lbDOB.Size = new System.Drawing.Size(13, 17);
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
            this.lbLN.Size = new System.Drawing.Size(13, 17);
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
            this.lbFN.Size = new System.Drawing.Size(13, 17);
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
            this.lbPID.Size = new System.Drawing.Size(13, 17);
            this.lbPID.TabIndex = 13;
            this.lbPID.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
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
            this.cbSearchPatients.TextChanged += new System.EventHandler(this.cbSearchPatients_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 733);
            this.panel1.TabIndex = 1;
            // 
            // btnUserProChange
            // 
            this.btnUserProChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserProChange.Image = ((System.Drawing.Image)(resources.GetObject("btnUserProChange.Image")));
            this.btnUserProChange.Location = new System.Drawing.Point(706, 12);
            this.btnUserProChange.Name = "btnUserProChange";
            this.btnUserProChange.Size = new System.Drawing.Size(56, 52);
            this.btnUserProChange.TabIndex = 10;
            this.btnUserProChange.UseVisualStyleBackColor = true;
            // 
            // AssistanceInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 733);
            this.Controls.Add(this.btnUserProChange);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AssistanceInterface";
            this.Text = "Assistance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.Patients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Appointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Patients;
        private System.Windows.Forms.TabPage Appointments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowAppintments;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnLoadPatients;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnUserProChange;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
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
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCN;
    }
}