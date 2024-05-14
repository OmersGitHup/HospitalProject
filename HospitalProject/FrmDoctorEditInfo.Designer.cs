namespace HospitalProject
{
    partial class FrmDoctorEditInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorEditInfo));
            this.btnEdit = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbSpecialities = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEdit.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(108, 196);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 32);
            this.btnEdit.TabIndex = 34;
            this.btnEdit.Text = "Apply Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(108, 39);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 21);
            this.TxtName.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Name";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(108, 65);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(100, 21);
            this.TxtSurname.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Surname";
            // 
            // MskTC
            // 
            this.MskTC.Enabled = false;
            this.MskTC.Location = new System.Drawing.Point(108, 91);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(100, 21);
            this.MskTC.TabIndex = 30;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(108, 143);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 21);
            this.TxtPassword.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Specialities";
            // 
            // CmbSpecialities
            // 
            this.CmbSpecialities.FormattingEnabled = true;
            this.CmbSpecialities.Location = new System.Drawing.Point(107, 116);
            this.CmbSpecialities.Name = "CmbSpecialities";
            this.CmbSpecialities.Size = new System.Drawing.Size(101, 21);
            this.CmbSpecialities.TabIndex = 39;
            // 
            // FrmDoctorEditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(297, 266);
            this.Controls.Add(this.CmbSpecialities);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDoctorEditInfo";
            this.Text = "Edit Doctor Info Panel";
            this.Load += new System.EventHandler(this.FrmDoctorEditInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSpecialities;
    }
}