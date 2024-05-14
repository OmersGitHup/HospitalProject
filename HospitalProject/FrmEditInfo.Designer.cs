namespace HospitalProject
{
    partial class FrmEditInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditInfo));
            this.btnEdit = new System.Windows.Forms.Button();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.MskPhoneN = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEdit.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(123, 202);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 32);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Apply Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "Man\t",
            "Woman"});
            this.CmbGender.Location = new System.Drawing.Point(123, 175);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(100, 21);
            this.CmbGender.TabIndex = 22;
            // 
            // MskPhoneN
            // 
            this.MskPhoneN.Location = new System.Drawing.Point(123, 123);
            this.MskPhoneN.Mask = "(999) 000-0000";
            this.MskPhoneN.Name = "MskPhoneN";
            this.MskPhoneN.Size = new System.Drawing.Size(100, 21);
            this.MskPhoneN.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Phone Number";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(123, 45);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 21);
            this.TxtName.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Name";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(123, 71);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(100, 21);
            this.TxtSurname.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Gender";
            // 
            // MskTC
            // 
            this.MskTC.Enabled = false;
            this.MskTC.Location = new System.Drawing.Point(123, 97);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(100, 21);
            this.MskTC.TabIndex = 18;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(123, 149);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 21);
            this.TxtPassword.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID";
            // 
            // FrmEditInfo
            // 
            this.AcceptButton = this.btnEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(310, 277);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.CmbGender);
            this.Controls.Add(this.MskPhoneN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEditInfo";
            this.Text = "Edit Info";
            this.Load += new System.EventHandler(this.FrmEditInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.MaskedTextBox MskPhoneN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}