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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssistanceInterface));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Patients = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchPatients = new System.Windows.Forms.TextBox();
            this.btnLoadPatients = new System.Windows.Forms.Button();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.Appointments = new System.Windows.Forms.TabPage();
            this.btnDeletePast = new System.Windows.Forms.Button();
            this.btnCurrentAppointments = new System.Windows.Forms.Button();
            this.dtpAppoinmentDates = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvApplintments = new System.Windows.Forms.DataGridView();
            this.btnShowAppintments = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSearchPatients = new System.Windows.Forms.ComboBox();
            this.btnUserProChange = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPID = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBlood = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnPrfileLiverTest = new System.Windows.Forms.RadioButton();
            this.rbtnHaemoglobinTest = new System.Windows.Forms.RadioButton();
            this.rbtnUrineTest = new System.Windows.Forms.RadioButton();
            this.rbtnCreatinineTest = new System.Windows.Forms.RadioButton();
            this.rbtnLipidTest = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.Patients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.Appointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplintments)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 30);
            this.tabControl1.Location = new System.Drawing.Point(10, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1328, 578);
            this.tabControl1.TabIndex = 0;
            // 
            // Patients
            // 
            this.Patients.BackColor = System.Drawing.Color.White;
            this.Patients.Controls.Add(this.label5);
            this.Patients.Controls.Add(this.txtSearchPatients);
            this.Patients.Controls.Add(this.btnLoadPatients);
            this.Patients.Controls.Add(this.dgvPatients);
            this.Patients.Location = new System.Drawing.Point(4, 34);
            this.Patients.Name = "Patients";
            this.Patients.Padding = new System.Windows.Forms.Padding(3);
            this.Patients.Size = new System.Drawing.Size(1320, 540);
            this.Patients.TabIndex = 0;
            this.Patients.Text = "Patients";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Search Patients";
            // 
            // txtSearchPatients
            // 
            this.txtSearchPatients.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPatients.Location = new System.Drawing.Point(146, 26);
            this.txtSearchPatients.Name = "txtSearchPatients";
            this.txtSearchPatients.Size = new System.Drawing.Size(167, 27);
            this.txtSearchPatients.TabIndex = 5;
            this.txtSearchPatients.TextChanged += new System.EventHandler(this.txtSearchPatients_TextChanged);
            // 
            // btnLoadPatients
            // 
            this.btnLoadPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadPatients.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLoadPatients.FlatAppearance.BorderSize = 0;
            this.btnLoadPatients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoadPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPatients.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPatients.ForeColor = System.Drawing.Color.White;
            this.btnLoadPatients.Location = new System.Drawing.Point(993, 482);
            this.btnLoadPatients.Name = "btnLoadPatients";
            this.btnLoadPatients.Size = new System.Drawing.Size(320, 52);
            this.btnLoadPatients.TabIndex = 3;
            this.btnLoadPatients.Text = "Load Patients";
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
            this.dgvPatients.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatients.EnableHeadersVisualStyles = false;
            this.dgvPatients.GridColor = System.Drawing.Color.White;
            this.dgvPatients.Location = new System.Drawing.Point(3, 68);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersVisible = false;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(1310, 373);
            this.dgvPatients.TabIndex = 2;
            this.dgvPatients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPatients_MouseClick);
            // 
            // Appointments
            // 
            this.Appointments.BackColor = System.Drawing.Color.White;
            this.Appointments.Controls.Add(this.btnDeletePast);
            this.Appointments.Controls.Add(this.btnCurrentAppointments);
            this.Appointments.Controls.Add(this.dtpAppoinmentDates);
            this.Appointments.Controls.Add(this.label9);
            this.Appointments.Controls.Add(this.dgvApplintments);
            this.Appointments.Controls.Add(this.btnShowAppintments);
            this.Appointments.Location = new System.Drawing.Point(4, 34);
            this.Appointments.Name = "Appointments";
            this.Appointments.Padding = new System.Windows.Forms.Padding(3);
            this.Appointments.Size = new System.Drawing.Size(1320, 540);
            this.Appointments.TabIndex = 1;
            this.Appointments.Text = "Appointments";
            // 
            // btnDeletePast
            // 
            this.btnDeletePast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePast.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDeletePast.FlatAppearance.BorderSize = 0;
            this.btnDeletePast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeletePast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePast.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePast.ForeColor = System.Drawing.Color.White;
            this.btnDeletePast.Location = new System.Drawing.Point(341, 482);
            this.btnDeletePast.Name = "btnDeletePast";
            this.btnDeletePast.Size = new System.Drawing.Size(320, 52);
            this.btnDeletePast.TabIndex = 19;
            this.btnDeletePast.Text = "Delete Previous Appointment";
            this.btnDeletePast.UseVisualStyleBackColor = false;
            this.btnDeletePast.Click += new System.EventHandler(this.btnDeletePast_Click);
            // 
            // btnCurrentAppointments
            // 
            this.btnCurrentAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrentAppointments.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCurrentAppointments.FlatAppearance.BorderSize = 0;
            this.btnCurrentAppointments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCurrentAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentAppointments.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentAppointments.ForeColor = System.Drawing.Color.White;
            this.btnCurrentAppointments.Location = new System.Drawing.Point(667, 482);
            this.btnCurrentAppointments.Name = "btnCurrentAppointments";
            this.btnCurrentAppointments.Size = new System.Drawing.Size(320, 52);
            this.btnCurrentAppointments.TabIndex = 18;
            this.btnCurrentAppointments.Text = "Current Appointments";
            this.btnCurrentAppointments.UseVisualStyleBackColor = false;
            this.btnCurrentAppointments.Click += new System.EventHandler(this.btnCurrentAppointments_Click);
            // 
            // dtpAppoinmentDates
            // 
            this.dtpAppoinmentDates.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppoinmentDates.Location = new System.Drawing.Point(193, 34);
            this.dtpAppoinmentDates.Name = "dtpAppoinmentDates";
            this.dtpAppoinmentDates.Size = new System.Drawing.Size(305, 27);
            this.dtpAppoinmentDates.TabIndex = 17;
            this.dtpAppoinmentDates.ValueChanged += new System.EventHandler(this.dtpAppoinmentDates_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Search Appoinments";
            // 
            // dgvApplintments
            // 
            this.dgvApplintments.AllowUserToAddRows = false;
            this.dgvApplintments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvApplintments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplintments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplintments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvApplintments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplintments.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvApplintments.EnableHeadersVisualStyles = false;
            this.dgvApplintments.GridColor = System.Drawing.Color.White;
            this.dgvApplintments.Location = new System.Drawing.Point(3, 68);
            this.dgvApplintments.Name = "dgvApplintments";
            this.dgvApplintments.ReadOnly = true;
            this.dgvApplintments.RowHeadersVisible = false;
            this.dgvApplintments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplintments.Size = new System.Drawing.Size(1310, 373);
            this.dgvApplintments.TabIndex = 10;
            // 
            // btnShowAppintments
            // 
            this.btnShowAppintments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAppintments.BackColor = System.Drawing.Color.DarkCyan;
            this.btnShowAppintments.FlatAppearance.BorderSize = 0;
            this.btnShowAppintments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnShowAppintments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAppintments.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAppintments.ForeColor = System.Drawing.Color.White;
            this.btnShowAppintments.Location = new System.Drawing.Point(993, 482);
            this.btnShowAppintments.Name = "btnShowAppintments";
            this.btnShowAppintments.Size = new System.Drawing.Size(320, 52);
            this.btnShowAppintments.TabIndex = 9;
            this.btnShowAppintments.Text = "Refresh Appointments";
            this.btnShowAppintments.UseVisualStyleBackColor = false;
            this.btnShowAppintments.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.btnAddTest);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1320, 540);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddTest
            // 
            this.btnAddTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTest.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAddTest.FlatAppearance.BorderSize = 0;
            this.btnAddTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTest.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTest.ForeColor = System.Drawing.Color.White;
            this.btnAddTest.Location = new System.Drawing.Point(993, 477);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(320, 52);
            this.btnAddTest.TabIndex = 14;
            this.btnAddTest.Text = "Add Selected Test";
            this.btnAddTest.UseVisualStyleBackColor = false;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
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
            this.panel5.Size = new System.Drawing.Size(1313, 339);
            this.panel5.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter the patient name";
            // 
            // cbSearchPatients
            // 
            this.cbSearchPatients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSearchPatients.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSearchPatients.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchPatients.FormattingEnabled = true;
            this.cbSearchPatients.Location = new System.Drawing.Point(216, 18);
            this.cbSearchPatients.Name = "cbSearchPatients";
            this.cbSearchPatients.Size = new System.Drawing.Size(194, 27);
            this.cbSearchPatients.TabIndex = 10;
            this.cbSearchPatients.TextChanged += new System.EventHandler(this.cbSearchPatients_TextChanged);
            // 
            // btnUserProChange
            // 
            this.btnUserProChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserProChange.Image = ((System.Drawing.Image)(resources.GetObject("btnUserProChange.Image")));
            this.btnUserProChange.Location = new System.Drawing.Point(1282, 12);
            this.btnUserProChange.Name = "btnUserProChange";
            this.btnUserProChange.Size = new System.Drawing.Size(56, 52);
            this.btnUserProChange.TabIndex = 10;
            this.btnUserProChange.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 88);
            this.panel1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Teal;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1184, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = false;
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
            this.button2.Location = new System.Drawing.Point(1240, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
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
            this.btnClose.Location = new System.Drawing.Point(1296, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(181, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 52);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Appointment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(948, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 52);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkCyan;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(15, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 52);
            this.button5.TabIndex = 2;
            this.button5.Text = "Add Patient";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.BackColor = System.Drawing.Color.Teal;
            this.panel13.Location = new System.Drawing.Point(-3, 686);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1366, 88);
            this.panel13.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.lbPID);
            this.panel6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Location = new System.Drawing.Point(28, 72);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(480, 52);
            this.panel6.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "PID :\r\n";
            // 
            // lbPID
            // 
            this.lbPID.AutoSize = true;
            this.lbPID.BackColor = System.Drawing.Color.White;
            this.lbPID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPID.Location = new System.Drawing.Point(155, 9);
            this.lbPID.Name = "lbPID";
            this.lbPID.Size = new System.Drawing.Size(16, 23);
            this.lbPID.TabIndex = 13;
            this.lbPID.Text = "-";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.label3);
            this.panel12.Controls.Add(this.lbBlood);
            this.panel12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel12.Location = new System.Drawing.Point(572, 185);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(480, 52);
            this.panel12.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Blood Type :\r\n";
            // 
            // lbBlood
            // 
            this.lbBlood.AutoSize = true;
            this.lbBlood.BackColor = System.Drawing.Color.White;
            this.lbBlood.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlood.Location = new System.Drawing.Point(156, 9);
            this.lbBlood.Name = "lbBlood";
            this.lbBlood.Size = new System.Drawing.Size(16, 23);
            this.lbBlood.TabIndex = 13;
            this.lbBlood.Text = "-";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.label12);
            this.panel11.Controls.Add(this.lbNIC);
            this.panel11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel11.Location = new System.Drawing.Point(572, 130);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(480, 52);
            this.panel11.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(31, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 23);
            this.label12.TabIndex = 12;
            this.label12.Text = "NIC :\r\n";
            // 
            // lbNIC
            // 
            this.lbNIC.AutoSize = true;
            this.lbNIC.BackColor = System.Drawing.Color.White;
            this.lbNIC.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNIC.Location = new System.Drawing.Point(154, 9);
            this.lbNIC.Name = "lbNIC";
            this.lbNIC.Size = new System.Drawing.Size(16, 23);
            this.lbNIC.TabIndex = 13;
            this.lbNIC.Text = "-";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.lbG);
            this.panel10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel10.Location = new System.Drawing.Point(572, 72);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(480, 52);
            this.panel10.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(31, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Gender :\r\n";
            // 
            // lbG
            // 
            this.lbG.AutoSize = true;
            this.lbG.BackColor = System.Drawing.Color.White;
            this.lbG.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbG.Location = new System.Drawing.Point(155, 9);
            this.lbG.Name = "lbG";
            this.lbG.Size = new System.Drawing.Size(16, 23);
            this.lbG.TabIndex = 13;
            this.lbG.Text = "-";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.lbDOB);
            this.panel9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel9.Location = new System.Drawing.Point(28, 240);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(480, 52);
            this.panel9.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(31, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Date of Birth :\r\n";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.BackColor = System.Drawing.Color.White;
            this.lbDOB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDOB.Location = new System.Drawing.Point(154, 9);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(16, 23);
            this.lbDOB.TabIndex = 13;
            this.lbDOB.Text = "-";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.lbLN);
            this.panel8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel8.Location = new System.Drawing.Point(28, 185);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(480, 52);
            this.panel8.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(31, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Last Name :\r\n";
            // 
            // lbLN
            // 
            this.lbLN.AutoSize = true;
            this.lbLN.BackColor = System.Drawing.Color.White;
            this.lbLN.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLN.Location = new System.Drawing.Point(155, 9);
            this.lbLN.Name = "lbLN";
            this.lbLN.Size = new System.Drawing.Size(16, 23);
            this.lbLN.TabIndex = 13;
            this.lbLN.Text = "-";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.lbFN);
            this.panel7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Location = new System.Drawing.Point(28, 130);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(480, 52);
            this.panel7.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "First Name :\r\n";
            // 
            // lbFN
            // 
            this.lbFN.AutoSize = true;
            this.lbFN.BackColor = System.Drawing.Color.White;
            this.lbFN.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFN.Location = new System.Drawing.Point(155, 9);
            this.lbFN.Name = "lbFN";
            this.lbFN.Size = new System.Drawing.Size(16, 23);
            this.lbFN.TabIndex = 13;
            this.lbFN.Text = "-";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rbtnPrfileLiverTest);
            this.panel2.Controls.Add(this.rbtnHaemoglobinTest);
            this.panel2.Controls.Add(this.rbtnUrineTest);
            this.panel2.Controls.Add(this.rbtnCreatinineTest);
            this.panel2.Controls.Add(this.rbtnLipidTest);
            this.panel2.Location = new System.Drawing.Point(28, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 169);
            this.panel2.TabIndex = 15;
            // 
            // rbtnPrfileLiverTest
            // 
            this.rbtnPrfileLiverTest.AutoSize = true;
            this.rbtnPrfileLiverTest.BackColor = System.Drawing.Color.White;
            this.rbtnPrfileLiverTest.Location = new System.Drawing.Point(18, 107);
            this.rbtnPrfileLiverTest.Name = "rbtnPrfileLiverTest";
            this.rbtnPrfileLiverTest.Size = new System.Drawing.Size(181, 27);
            this.rbtnPrfileLiverTest.TabIndex = 6;
            this.rbtnPrfileLiverTest.TabStop = true;
            this.rbtnPrfileLiverTest.Text = "PROFILE LIVER TEST";
            this.rbtnPrfileLiverTest.UseVisualStyleBackColor = false;
            // 
            // rbtnHaemoglobinTest
            // 
            this.rbtnHaemoglobinTest.AutoSize = true;
            this.rbtnHaemoglobinTest.BackColor = System.Drawing.Color.White;
            this.rbtnHaemoglobinTest.Location = new System.Drawing.Point(18, 44);
            this.rbtnHaemoglobinTest.Name = "rbtnHaemoglobinTest";
            this.rbtnHaemoglobinTest.Size = new System.Drawing.Size(308, 27);
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
            this.rbtnUrineTest.Size = new System.Drawing.Size(291, 27);
            this.rbtnUrineTest.TabIndex = 7;
            this.rbtnUrineTest.TabStop = true;
            this.rbtnUrineTest.Text = "URINE FOR MICRO ALBUMIN TEST";
            this.rbtnUrineTest.UseVisualStyleBackColor = true;
            // 
            // rbtnCreatinineTest
            // 
            this.rbtnCreatinineTest.AutoSize = true;
            this.rbtnCreatinineTest.Location = new System.Drawing.Point(18, 13);
            this.rbtnCreatinineTest.Name = "rbtnCreatinineTest";
            this.rbtnCreatinineTest.Size = new System.Drawing.Size(244, 27);
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
            this.rbtnLipidTest.Size = new System.Drawing.Size(139, 27);
            this.rbtnLipidTest.TabIndex = 5;
            this.rbtnLipidTest.TabStop = true;
            this.rbtnLipidTest.Text = "LIPID PROFILE";
            this.rbtnLipidTest.UseVisualStyleBackColor = true;
            // 
            // AssistanceInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 772);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUserProChange);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssistanceInterface";
            this.Text = "Assistance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.Patients.ResumeLayout(false);
            this.Patients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.Appointments.ResumeLayout(false);
            this.Appointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplintments)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Patients;
        private System.Windows.Forms.TabPage Appointments;
        private System.Windows.Forms.Button btnShowAppintments;
        private System.Windows.Forms.DataGridView dgvApplintments;
        private System.Windows.Forms.Button btnLoadPatients;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Button btnUserProChange;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSearchPatients;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchPatients;
        private System.Windows.Forms.DateTimePicker dtpAppoinmentDates;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCurrentAppointments;
        private System.Windows.Forms.Button btnDeletePast;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPID;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBlood;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnPrfileLiverTest;
        private System.Windows.Forms.RadioButton rbtnHaemoglobinTest;
        private System.Windows.Forms.RadioButton rbtnUrineTest;
        private System.Windows.Forms.RadioButton rbtnCreatinineTest;
        private System.Windows.Forms.RadioButton rbtnLipidTest;
    }
}