namespace HospitalProject
{
    partial class FrmPatientEntery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientEntery));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.Lnk_Signup = new System.Windows.Forms.LinkLabel();
            this.SignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Entry Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(196, 115);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(196, 84);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(100, 20);
            this.MskTC.TabIndex = 1;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // Lnk_Signup
            // 
            this.Lnk_Signup.AutoSize = true;
            this.Lnk_Signup.Location = new System.Drawing.Point(335, 122);
            this.Lnk_Signup.Name = "Lnk_Signup";
            this.Lnk_Signup.Size = new System.Drawing.Size(146, 13);
            this.Lnk_Signup.TabIndex = 9;
            this.Lnk_Signup.TabStop = true;
            this.Lnk_Signup.Text = "Save or Sign Up New Patient";
            this.Lnk_Signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_Signup_LinkClicked);
            // 
            // SignIn
            // 
            this.SignIn.Location = new System.Drawing.Point(221, 141);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(75, 23);
            this.SignIn.TabIndex = 6;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // FrmPatientEntery
            // 
            this.AcceptButton = this.SignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(549, 225);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.Lnk_Signup);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPatientEntery";
            this.Text = "Patient Entery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.LinkLabel Lnk_Signup;
        private System.Windows.Forms.Button SignIn;
    }
}