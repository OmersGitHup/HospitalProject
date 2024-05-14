namespace HospitalProject
{
    partial class FrmSpeciality
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpeciality));
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.TxtSpecialityName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSpecialityID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(114, 252);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(130, 32);
            this.BtnDelete.TabIndex = 62;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnAdd.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(114, 128);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(130, 32);
            this.BtnAdd.TabIndex = 61;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(268, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(423, 240);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEdit.Font = new System.Drawing.Font("MV Boli", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(114, 214);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 32);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.Text = "Apply Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // TxtSpecialityName
            // 
            this.TxtSpecialityName.Location = new System.Drawing.Point(115, 72);
            this.TxtSpecialityName.Name = "TxtSpecialityName";
            this.TxtSpecialityName.Size = new System.Drawing.Size(130, 20);
            this.TxtSpecialityName.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Speciality Name";
            // 
            // TxtSpecialityID
            // 
            this.TxtSpecialityID.Location = new System.Drawing.Point(114, 44);
            this.TxtSpecialityID.Name = "TxtSpecialityID";
            this.TxtSpecialityID.Size = new System.Drawing.Size(130, 20);
            this.TxtSpecialityID.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Speciality Id";
            // 
            // FrmSpeciality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 313);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.TxtSpecialityName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSpecialityID);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSpeciality";
            this.Text = "Speciality Panel";
            this.Load += new System.EventHandler(this.FrmSpeciality_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox TxtSpecialityName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSpecialityID;
        private System.Windows.Forms.Label label4;
    }
}