namespace DoctorSupportSystem.Interfaces.Reports
{
    partial class MedicalDayReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvMedicines = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnAddDayReport = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 512);
            this.panel1.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel17);
            this.panel5.Location = new System.Drawing.Point(64, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(579, 439);
            this.panel5.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.dgvMedicines);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(16, 267);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(544, 160);
            this.panel3.TabIndex = 21;
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.AllowUserToAddRows = false;
            this.dgvMedicines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicines.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Medicine});
            this.dgvMedicines.EnableHeadersVisualStyles = false;
            this.dgvMedicines.Location = new System.Drawing.Point(118, 9);
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMedicines.Size = new System.Drawing.Size(411, 138);
            this.dgvMedicines.TabIndex = 13;
            this.dgvMedicines.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvMedicines_EditingControlShowing);
            this.dgvMedicines.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMedicines_KeyDown);
            this.dgvMedicines.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMedicines_MouseClick);
            // 
            // No
            // 
            this.No.FillWeight = 50.76143F;
            this.No.HeaderText = "Number";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Medicine
            // 
            this.Medicine.FillWeight = 149.2386F;
            this.Medicine.HeaderText = "Medicine";
            this.Medicine.Name = "Medicine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Medicines:\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 35);
            this.panel2.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = " Date:\r\n";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel17.Controls.Add(this.txtCondition);
            this.panel17.Controls.Add(this.label21);
            this.panel17.Location = new System.Drawing.Point(16, 61);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(544, 200);
            this.panel17.TabIndex = 19;
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(118, 8);
            this.txtCondition.Multiline = true;
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(413, 172);
            this.txtCondition.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(31, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 16);
            this.label21.TabIndex = 12;
            this.label21.Text = " Condition:\r\n";
            // 
            // btnAddDayReport
            // 
            this.btnAddDayReport.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddDayReport.FlatAppearance.BorderSize = 0;
            this.btnAddDayReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddDayReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDayReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDayReport.ForeColor = System.Drawing.Color.White;
            this.btnAddDayReport.Location = new System.Drawing.Point(64, 457);
            this.btnAddDayReport.Name = "btnAddDayReport";
            this.btnAddDayReport.Size = new System.Drawing.Size(123, 36);
            this.btnAddDayReport.TabIndex = 15;
            this.btnAddDayReport.Text = "Add Day Report";
            this.btnAddDayReport.UseVisualStyleBackColor = false;
            this.btnAddDayReport.Click += new System.EventHandler(this.btnAddDayReport_Click);
            // 
            // MedicalDayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 512);
            this.Controls.Add(this.btnAddDayReport);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "MedicalDayReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MedicalDayReport";
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvMedicines;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine;
        private System.Windows.Forms.Button btnAddDayReport;
    }
}