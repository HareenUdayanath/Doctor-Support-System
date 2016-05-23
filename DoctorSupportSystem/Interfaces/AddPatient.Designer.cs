﻿namespace DoctorSupportSystem.Interfaces
{
    partial class AddPatient
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label label10;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.txtNIC);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBoxGender);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtLName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(65, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 400);
            this.panel1.TabIndex = 0;
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(152, 318);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(142, 20);
            this.txtNIC.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "NIC :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(152, 14);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(274, 92);
            this.txtAddress.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Address :";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(152, 156);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(79, 21);
            this.comboBoxGender.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Gender :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "DD";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(344, 9);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(61, 20);
            this.txtDay.TabIndex = 11;
            this.txtDay.TextChanged += new System.EventHandler(this.txtDay_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "MM";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(249, 9);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(61, 20);
            this.txtMonth.TabIndex = 9;
            this.txtMonth.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "YYYY";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(152, 9);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(61, 20);
            this.txtYear.TabIndex = 7;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date of Birth: ";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(152, 79);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(142, 20);
            this.txtLName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name :";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(152, 8);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(142, 20);
            this.txtFName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name : ";
            // 
            // txtPID
            // 
            this.txtPID.Enabled = false;
            this.txtPID.Location = new System.Drawing.Point(152, 11);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(142, 20);
            this.txtPID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID : ";
            // 
            // txtCoNo
            // 
            this.txtCoNo.Location = new System.Drawing.Point(152, 7);
            this.txtCoNo.Name = "txtCoNo";
            this.txtCoNo.Size = new System.Drawing.Size(208, 20);
            this.txtCoNo.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label11.Location = new System.Drawing.Point(22, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Contact Number:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.txtFName);
            this.panel7.Location = new System.Drawing.Point(0, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(442, 38);
            this.panel7.TabIndex = 22;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddPatient.FlatAppearance.BorderSize = 0;
            this.btnAddPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.Location = new System.Drawing.Point(65, 455);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(135, 44);
            this.btnAddPatient.TabIndex = 9;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(39, 511);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.txtYear);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMonth);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtDay);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(65, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 38);
            this.panel2.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.txtAddress);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(0, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(442, 116);
            this.panel4.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.txtCoNo);
            this.panel5.Location = new System.Drawing.Point(65, 366);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(442, 38);
            this.panel5.TabIndex = 23;
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 511);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.panel1);
            this.Name = "AddPatient";
            this.Text = "Add New Patient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCoNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
    }
}