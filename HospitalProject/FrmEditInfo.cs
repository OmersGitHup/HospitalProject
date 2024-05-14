using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject
{
    public partial class FrmEditInfo : Form
    {
        public FrmEditInfo()
        {
            InitializeComponent();
        }

        public string tcno;

        SqlGoTake con = new SqlGoTake();

        private void FrmEditInfo_Load(object sender, EventArgs e)
        {
            MskTC.Text= tcno;
            SqlCommand command=new SqlCommand("Select * From Tbl_Patients Where PatientTC=@p1",con.Connection());
            command.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TxtName.Text = reader[1].ToString();
                TxtSurname.Text = reader[2].ToString();
                MskPhoneN.Text = reader[4].ToString();
                TxtPassword.Text = reader[5].ToString();
                CmbGender.Text = reader[6].ToString();
            }
            con.Connection().Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Patients set PatientName=@p1,PatientSurname=@p2,PatientPhone=@p3,PatientPassword=@p4,PatientGender=@p5 where PatientTC=@p6", con.Connection());
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command.Parameters.AddWithValue("@p3", MskPhoneN.Text);
            command.Parameters.AddWithValue("@p4", TxtPassword.Text);
            command.Parameters.AddWithValue("@p5", CmbGender.Text);
            command.Parameters.AddWithValue("@p6", tcno);
            command.ExecuteNonQuery();
            con.Connection().Close() ;
            MessageBox.Show("Information Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();

        }
    }
}
