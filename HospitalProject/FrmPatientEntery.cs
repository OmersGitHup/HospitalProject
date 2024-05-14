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
    public partial class FrmPatientEntery : Form
    {
        public FrmPatientEntery()
        {
            InitializeComponent();
        }

        SqlGoTake con = new SqlGoTake();

        private void Lnk_Signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientSignUp frm = new FrmPatientSignUp();
            frm.Show();

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Tbl_Patients Where PatientTC=@p1 and PatientPassword=@p2",con.Connection());
            command.Parameters.AddWithValue("@p1", MskTC.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr=command.ExecuteReader();
            if (dr.Read()) {
            FrmPatientDetail frm = new FrmPatientDetail();
                
                //Moving PatientID to FrmPatientDetail Forum
                frm.PatientID=MskTC.Text;

                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Password or UserId");
            }
            con.Connection().Close();
        }
    }
}
