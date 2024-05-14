namespace HospitalProject
{
    partial class FrmDoctorSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorSignIn));
            this.SignIn = new System.Windows.Forms.Button();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignIn
            // 
            this.SignIn.Location = new System.Drawing.Point(163, 149);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(75, 23);
            this.SignIn.TabIndex = 13;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(138, 92);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(100, 22);
            this.MskTC.TabIndex = 1;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(138, 123);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 22);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doctor Entry Panel";
            // 
            // FrmDoctorSignIn
            // 
            this.AcceptButton = this.SignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 242);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDoctorSignIn";
            this.Text = "Doctor Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}