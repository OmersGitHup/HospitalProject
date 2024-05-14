namespace HospitalProject
{
    partial class FrmEntriesPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntriesPanel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSecretaryEnter = new System.Windows.Forms.Button();
            this.BtnDoctorEnter = new System.Windows.Forms.Button();
            this.BtnPatientEnter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(116, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(441, 57);
            this.label4.TabIndex = 7;
            this.label4.Text = "Local Brandium Hospital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalProject.Properties.Resources.heartbeatico;
            this.pictureBox1.Location = new System.Drawing.Point(563, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSecretaryEnter
            // 
            this.BtnSecretaryEnter.BackgroundImage = global::HospitalProject.Properties.Resources._2548789;
            this.BtnSecretaryEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSecretaryEnter.Location = new System.Drawing.Point(527, 233);
            this.BtnSecretaryEnter.Name = "BtnSecretaryEnter";
            this.BtnSecretaryEnter.Size = new System.Drawing.Size(186, 162);
            this.BtnSecretaryEnter.TabIndex = 2;
            this.BtnSecretaryEnter.UseVisualStyleBackColor = true;
            this.BtnSecretaryEnter.Click += new System.EventHandler(this.BtnSecretaryEnter_Click);
            // 
            // BtnDoctorEnter
            // 
            this.BtnDoctorEnter.BackgroundImage = global::HospitalProject.Properties.Resources._1021799;
            this.BtnDoctorEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoctorEnter.Location = new System.Drawing.Point(314, 233);
            this.BtnDoctorEnter.Name = "BtnDoctorEnter";
            this.BtnDoctorEnter.Size = new System.Drawing.Size(186, 162);
            this.BtnDoctorEnter.TabIndex = 1;
            this.BtnDoctorEnter.UseVisualStyleBackColor = true;
            this.BtnDoctorEnter.Click += new System.EventHandler(this.BtnDoctorEnter_Click);
            // 
            // BtnPatientEnter
            // 
            this.BtnPatientEnter.BackgroundImage = global::HospitalProject.Properties.Resources.patientico;
            this.BtnPatientEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPatientEnter.Location = new System.Drawing.Point(89, 233);
            this.BtnPatientEnter.Name = "BtnPatientEnter";
            this.BtnPatientEnter.Size = new System.Drawing.Size(186, 162);
            this.BtnPatientEnter.TabIndex = 0;
            this.BtnPatientEnter.UseVisualStyleBackColor = true;
            this.BtnPatientEnter.Click += new System.EventHandler(this.BtnPatientEnter_Click);
            // 
            // FrmEntriesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSecretaryEnter);
            this.Controls.Add(this.BtnDoctorEnter);
            this.Controls.Add(this.BtnPatientEnter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEntriesPanel";
            this.Text = "Local Brandium";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPatientEnter;
        private System.Windows.Forms.Button BtnDoctorEnter;
        private System.Windows.Forms.Button BtnSecretaryEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

