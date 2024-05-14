namespace HospitalProject
{
    partial class FrmDoctorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorDetails));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblNameSurname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RchComplain = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnAnnouncment = new System.Windows.Forms.Button();
            this.BtnSıgnOut = new System.Windows.Forms.Button();
            this.BtnEditInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblNameSurname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DoctorInfo";
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Location = new System.Drawing.Point(102, 54);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(52, 22);
            this.LblNameSurname.TabIndex = 4;
            this.LblNameSurname.Text = "Null Null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name Surname";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(102, 32);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(65, 22);
            this.LblTC.TabIndex = 2;
            this.LblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RchComplain);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 394);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Detail";
            // 
            // RchComplain
            // 
            this.RchComplain.Location = new System.Drawing.Point(10, 55);
            this.RchComplain.Name = "RchComplain";
            this.RchComplain.Size = new System.Drawing.Size(217, 157);
            this.RchComplain.TabIndex = 2;
            this.RchComplain.Text = "";
            this.RchComplain.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Complain";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(261, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 659);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointments List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 636);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnAnnouncment);
            this.groupBox4.Controls.Add(this.BtnSıgnOut);
            this.groupBox4.Controls.Add(this.BtnEditInfo);
            this.groupBox4.Location = new System.Drawing.Point(12, 546);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 125);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quick Accsess";
            // 
            // BtnAnnouncment
            // 
            this.BtnAnnouncment.Location = new System.Drawing.Point(91, 23);
            this.BtnAnnouncment.Name = "BtnAnnouncment";
            this.BtnAnnouncment.Size = new System.Drawing.Size(86, 28);
            this.BtnAnnouncment.TabIndex = 3;
            this.BtnAnnouncment.Text = "Announcement";
            this.BtnAnnouncment.UseVisualStyleBackColor = true;
            this.BtnAnnouncment.Click += new System.EventHandler(this.BtnAnnouncment_Click);
            // 
            // BtnSıgnOut
            // 
            this.BtnSıgnOut.Location = new System.Drawing.Point(10, 57);
            this.BtnSıgnOut.Name = "BtnSıgnOut";
            this.BtnSıgnOut.Size = new System.Drawing.Size(167, 32);
            this.BtnSıgnOut.TabIndex = 1;
            this.BtnSıgnOut.Text = "Sign Out";
            this.BtnSıgnOut.UseVisualStyleBackColor = true;
            this.BtnSıgnOut.Click += new System.EventHandler(this.BtnSıgnOut_Click);
            // 
            // BtnEditInfo
            // 
            this.BtnEditInfo.Location = new System.Drawing.Point(10, 23);
            this.BtnEditInfo.Name = "BtnEditInfo";
            this.BtnEditInfo.Size = new System.Drawing.Size(75, 28);
            this.BtnEditInfo.TabIndex = 0;
            this.BtnEditInfo.Text = "Edit Info";
            this.BtnEditInfo.UseVisualStyleBackColor = true;
            this.BtnEditInfo.Click += new System.EventHandler(this.BtnEditInfo_Click);
            // 
            // FrmDoctorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1074, 762);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoctorDetails";
            this.Text = "Doctor Detail Panel";
            this.Load += new System.EventHandler(this.FrmDoctorDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox RchComplain;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAnnouncment;
        private System.Windows.Forms.Button BtnSıgnOut;
        private System.Windows.Forms.Button BtnEditInfo;
    }
}