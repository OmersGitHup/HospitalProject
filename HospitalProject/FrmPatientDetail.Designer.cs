namespace HospitalProject
{
    partial class FrmPatientDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblNamSur = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAppointmentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LnkEditInfo = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.RictTextComplain = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbDoctor = new System.Windows.Forms.ComboBox();
            this.getAppointment = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSpeciality = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblNamSur);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Info";
            // 
            // LblNamSur
            // 
            this.LblNamSur.AutoSize = true;
            this.LblNamSur.Location = new System.Drawing.Point(112, 59);
            this.LblNamSur.Name = "LblNamSur";
            this.LblNamSur.Size = new System.Drawing.Size(54, 15);
            this.LblNamSur.TabIndex = 17;
            this.LblNamSur.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "NM/SU :";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(112, 28);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(84, 15);
            this.LblTC.TabIndex = 15;
            this.LblTC.Text = "00000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID NUMBER:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAppointmentId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LnkEditInfo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.RictTextComplain);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CmbDoctor);
            this.groupBox2.Controls.Add(this.getAppointment);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbSpeciality);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 360);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Panel";
            // 
            // txtAppointmentId
            // 
            this.txtAppointmentId.Enabled = false;
            this.txtAppointmentId.Location = new System.Drawing.Point(119, 28);
            this.txtAppointmentId.Name = "txtAppointmentId";
            this.txtAppointmentId.Size = new System.Drawing.Size(77, 23);
            this.txtAppointmentId.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id :";
            // 
            // LnkEditInfo
            // 
            this.LnkEditInfo.AutoSize = true;
            this.LnkEditInfo.Location = new System.Drawing.Point(6, 308);
            this.LnkEditInfo.Name = "LnkEditInfo";
            this.LnkEditInfo.Size = new System.Drawing.Size(96, 15);
            this.LnkEditInfo.TabIndex = 7;
            this.LnkEditInfo.TabStop = true;
            this.LnkEditInfo.Text = "Edit Information";
            this.LnkEditInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkEditInfo_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Patient Complaint:";
            // 
            // RictTextComplain
            // 
            this.RictTextComplain.Location = new System.Drawing.Point(119, 120);
            this.RictTextComplain.Name = "RictTextComplain";
            this.RictTextComplain.Size = new System.Drawing.Size(168, 121);
            this.RictTextComplain.TabIndex = 5;
            this.RictTextComplain.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Doctor:";
            // 
            // CmbDoctor
            // 
            this.CmbDoctor.FormattingEnabled = true;
            this.CmbDoctor.Location = new System.Drawing.Point(119, 91);
            this.CmbDoctor.Name = "CmbDoctor";
            this.CmbDoctor.Size = new System.Drawing.Size(168, 23);
            this.CmbDoctor.TabIndex = 3;
            this.CmbDoctor.SelectedIndexChanged += new System.EventHandler(this.CmbDoctor_SelectedIndexChanged);
            // 
            // getAppointment
            // 
            this.getAppointment.Font = new System.Drawing.Font("Courier New", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.getAppointment.Location = new System.Drawing.Point(120, 247);
            this.getAppointment.Name = "getAppointment";
            this.getAppointment.Size = new System.Drawing.Size(167, 26);
            this.getAppointment.TabIndex = 2;
            this.getAppointment.Text = "Get Appointment";
            this.getAppointment.UseVisualStyleBackColor = true;
            this.getAppointment.Click += new System.EventHandler(this.getAppointment_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Speciality :";
            // 
            // cmbSpeciality
            // 
            this.cmbSpeciality.FormattingEnabled = true;
            this.cmbSpeciality.Location = new System.Drawing.Point(119, 62);
            this.cmbSpeciality.Name = "cmbSpeciality";
            this.cmbSpeciality.Size = new System.Drawing.Size(168, 23);
            this.cmbSpeciality.TabIndex = 0;
            this.cmbSpeciality.SelectedIndexChanged += new System.EventHandler(this.cmbSpeciality_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(326, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(908, 117);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(902, 95);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(326, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(905, 360);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Active Appointments";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(899, 338);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // FrmPatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1246, 519);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBox = false;
            this.Name = "FrmPatientDetail";
            this.Text = "Patient Detail";
            this.Load += new System.EventHandler(this.FrmPatientDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblNamSur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button getAppointment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSpeciality;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox RictTextComplain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbDoctor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel LnkEditInfo;
        private System.Windows.Forms.TextBox txtAppointmentId;
        private System.Windows.Forms.Label label1;
    }
}