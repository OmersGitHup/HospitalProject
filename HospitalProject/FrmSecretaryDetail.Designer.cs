namespace HospitalProject
{
    partial class FrmSecretaryDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretaryDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblNameSurname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCreateAnnoun = new System.Windows.Forms.Button();
            this.RchAnnou = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnAppoinUpdate = new System.Windows.Forms.Button();
            this.BtnAppoinCreate = new System.Windows.Forms.Button();
            this.ChkStatu = new System.Windows.Forms.CheckBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.CmbDoctor = new System.Windows.Forms.ComboBox();
            this.CmbSpe = new System.Windows.Forms.ComboBox();
            this.MskTime = new System.Windows.Forms.MaskedTextBox();
            this.MskDate = new System.Windows.Forms.MaskedTextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnListAppoint = new System.Windows.Forms.Button();
            this.BtnSpecialityPanel = new System.Windows.Forms.Button();
            this.BtnDoctorPanel = new System.Windows.Forms.Button();
            this.btnAnnouncment = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblNameSurname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretary Info";
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Location = new System.Drawing.Point(121, 54);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(59, 18);
            this.LblNameSurname.TabIndex = 8;
            this.LblNameSurname.Text = "Null Null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name Surname :";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(121, 32);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(96, 18);
            this.LblTC.TabIndex = 6;
            this.LblTC.Text = "00000000000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCreateAnnoun);
            this.groupBox2.Controls.Add(this.RchAnnou);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Announcement";
            // 
            // BtnCreateAnnoun
            // 
            this.BtnCreateAnnoun.Location = new System.Drawing.Point(9, 178);
            this.BtnCreateAnnoun.Name = "BtnCreateAnnoun";
            this.BtnCreateAnnoun.Size = new System.Drawing.Size(252, 33);
            this.BtnCreateAnnoun.TabIndex = 1;
            this.BtnCreateAnnoun.Text = "Create";
            this.BtnCreateAnnoun.UseVisualStyleBackColor = true;
            this.BtnCreateAnnoun.Click += new System.EventHandler(this.BtnCreateAnnoun_Click);
            // 
            // RchAnnou
            // 
            this.RchAnnou.Location = new System.Drawing.Point(9, 25);
            this.RchAnnou.Name = "RchAnnou";
            this.RchAnnou.Size = new System.Drawing.Size(252, 137);
            this.RchAnnou.TabIndex = 0;
            this.RchAnnou.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnAppoinUpdate);
            this.groupBox3.Controls.Add(this.BtnAppoinCreate);
            this.groupBox3.Controls.Add(this.ChkStatu);
            this.groupBox3.Controls.Add(this.MskTC);
            this.groupBox3.Controls.Add(this.CmbDoctor);
            this.groupBox3.Controls.Add(this.CmbSpe);
            this.groupBox3.Controls.Add(this.MskTime);
            this.groupBox3.Controls.Add(this.MskDate);
            this.groupBox3.Controls.Add(this.TxtID);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(303, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 355);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment Panel";
            // 
            // BtnAppoinUpdate
            // 
            this.BtnAppoinUpdate.Location = new System.Drawing.Point(34, 277);
            this.BtnAppoinUpdate.Name = "BtnAppoinUpdate";
            this.BtnAppoinUpdate.Size = new System.Drawing.Size(138, 27);
            this.BtnAppoinUpdate.TabIndex = 14;
            this.BtnAppoinUpdate.Text = "Update Appoinment (Beta)";
            this.BtnAppoinUpdate.UseVisualStyleBackColor = true;
            this.BtnAppoinUpdate.Click += new System.EventHandler(this.BtnAppoinUpdate_Click);
            // 
            // BtnAppoinCreate
            // 
            this.BtnAppoinCreate.Location = new System.Drawing.Point(34, 238);
            this.BtnAppoinCreate.Name = "BtnAppoinCreate";
            this.BtnAppoinCreate.Size = new System.Drawing.Size(138, 33);
            this.BtnAppoinCreate.TabIndex = 3;
            this.BtnAppoinCreate.Text = "Create Appoinment";
            this.BtnAppoinCreate.UseVisualStyleBackColor = true;
            this.BtnAppoinCreate.Click += new System.EventHandler(this.BtnAppoinCreate_Click);
            // 
            // ChkStatu
            // 
            this.ChkStatu.AutoSize = true;
            this.ChkStatu.Location = new System.Drawing.Point(158, 210);
            this.ChkStatu.Name = "ChkStatu";
            this.ChkStatu.Size = new System.Drawing.Size(60, 22);
            this.ChkStatu.TabIndex = 13;
            this.ChkStatu.Text = "Statu";
            this.ChkStatu.UseVisualStyleBackColor = true;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(88, 178);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(130, 26);
            this.MskTC.TabIndex = 12;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // CmbDoctor
            // 
            this.CmbDoctor.FormattingEnabled = true;
            this.CmbDoctor.Location = new System.Drawing.Point(88, 148);
            this.CmbDoctor.Name = "CmbDoctor";
            this.CmbDoctor.Size = new System.Drawing.Size(130, 26);
            this.CmbDoctor.TabIndex = 11;
            // 
            // CmbSpe
            // 
            this.CmbSpe.FormattingEnabled = true;
            this.CmbSpe.Location = new System.Drawing.Point(88, 120);
            this.CmbSpe.Name = "CmbSpe";
            this.CmbSpe.Size = new System.Drawing.Size(130, 26);
            this.CmbSpe.TabIndex = 10;
            this.CmbSpe.SelectedIndexChanged += new System.EventHandler(this.CmbSpe_SelectedIndexChanged);
            // 
            // MskTime
            // 
            this.MskTime.Location = new System.Drawing.Point(88, 92);
            this.MskTime.Mask = "00:00";
            this.MskTime.Name = "MskTime";
            this.MskTime.Size = new System.Drawing.Size(130, 26);
            this.MskTime.TabIndex = 9;
            this.MskTime.ValidatingType = typeof(System.DateTime);
            // 
            // MskDate
            // 
            this.MskDate.Location = new System.Drawing.Point(88, 61);
            this.MskDate.Mask = "00/00/0000";
            this.MskDate.Name = "MskDate";
            this.MskDate.Size = new System.Drawing.Size(130, 26);
            this.MskDate.TabIndex = 8;
            this.MskDate.ValidatingType = typeof(System.DateTime);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(88, 29);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(130, 26);
            this.TxtID.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Doctor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "TC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Speciality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(576, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(434, 232);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Specialities";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(576, 250);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(434, 239);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(428, 214);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAnnouncment);
            this.groupBox6.Controls.Add(this.BtnListAppoint);
            this.groupBox6.Controls.Add(this.BtnSpecialityPanel);
            this.groupBox6.Controls.Add(this.BtnDoctorPanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 382);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(558, 107);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Quick Access";
            // 
            // BtnListAppoint
            // 
            this.BtnListAppoint.Location = new System.Drawing.Point(246, 25);
            this.BtnListAppoint.Name = "BtnListAppoint";
            this.BtnListAppoint.Size = new System.Drawing.Size(133, 23);
            this.BtnListAppoint.TabIndex = 2;
            this.BtnListAppoint.Text = "List Appointments";
            this.BtnListAppoint.UseVisualStyleBackColor = true;
            this.BtnListAppoint.Click += new System.EventHandler(this.BtnListAppoint_Click);
            // 
            // BtnSpecialityPanel
            // 
            this.BtnSpecialityPanel.Location = new System.Drawing.Point(124, 25);
            this.BtnSpecialityPanel.Name = "BtnSpecialityPanel";
            this.BtnSpecialityPanel.Size = new System.Drawing.Size(116, 23);
            this.BtnSpecialityPanel.TabIndex = 1;
            this.BtnSpecialityPanel.Text = "Speciality Panel";
            this.BtnSpecialityPanel.UseVisualStyleBackColor = true;
            this.BtnSpecialityPanel.Click += new System.EventHandler(this.BtnSpecialityPanel_Click);
            // 
            // BtnDoctorPanel
            // 
            this.BtnDoctorPanel.Location = new System.Drawing.Point(9, 25);
            this.BtnDoctorPanel.Name = "BtnDoctorPanel";
            this.BtnDoctorPanel.Size = new System.Drawing.Size(106, 23);
            this.BtnDoctorPanel.TabIndex = 0;
            this.BtnDoctorPanel.Text = "Doctor Panel";
            this.BtnDoctorPanel.UseVisualStyleBackColor = true;
            this.BtnDoctorPanel.Click += new System.EventHandler(this.BtnDoctorPanel_Click);
            // 
            // btnAnnouncment
            // 
            this.btnAnnouncment.Location = new System.Drawing.Point(385, 25);
            this.btnAnnouncment.Name = "btnAnnouncment";
            this.btnAnnouncment.Size = new System.Drawing.Size(133, 23);
            this.btnAnnouncment.TabIndex = 3;
            this.btnAnnouncment.Text = "Announcments !";
            this.btnAnnouncment.UseVisualStyleBackColor = true;
            this.btnAnnouncment.Click += new System.EventHandler(this.btnAnnouncment_Click);
            // 
            // FrmSecretaryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmSecretaryDetail";
            this.Text = "FrmSecretaryDetail";
            this.Load += new System.EventHandler(this.FrmSecretaryDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RchAnnou;
        private System.Windows.Forms.Button BtnCreateAnnoun;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox MskDate;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAppoinCreate;
        private System.Windows.Forms.CheckBox ChkStatu;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.ComboBox CmbDoctor;
        private System.Windows.Forms.ComboBox CmbSpe;
        private System.Windows.Forms.MaskedTextBox MskTime;
        private System.Windows.Forms.Button BtnAppoinUpdate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnListAppoint;
        private System.Windows.Forms.Button BtnSpecialityPanel;
        private System.Windows.Forms.Button BtnDoctorPanel;
        private System.Windows.Forms.Button btnAnnouncment;
    }
}