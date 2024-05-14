namespace HospitalProject
{
    partial class FrmDoctorPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorPanel));
            this.CmbSpe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbSpe
            // 
            this.CmbSpe.FormattingEnabled = true;
            this.CmbSpe.Location = new System.Drawing.Point(117, 149);
            this.CmbSpe.Name = "CmbSpe";
            this.CmbSpe.Size = new System.Drawing.Size(130, 21);
            this.CmbSpe.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Speciality";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(117, 96);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(130, 21);
            this.TxtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Name";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(117, 122);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(130, 21);
            this.TxtSurname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Surname";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(117, 176);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(130, 21);
            this.MskTC.TabIndex = 4;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(117, 203);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(130, 21);
            this.TxtPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Password";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEdit.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(117, 330);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 32);
            this.btnEdit.TabIndex = 45;
            this.btnEdit.Text = "Apply Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(821, 240);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnAdd.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(117, 244);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(130, 32);
            this.BtnAdd.TabIndex = 47;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(117, 368);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(130, 32);
            this.BtnDelete.TabIndex = 48;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmDoctorPanel
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1150, 450);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbSpe);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDoctorPanel";
            this.Text = "Doctor Panel";
            this.Load += new System.EventHandler(this.FrmDoctorPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbSpe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
    }
}