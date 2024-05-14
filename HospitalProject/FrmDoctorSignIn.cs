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
    public partial class FrmDoctorSignIn : Form
    {
        public FrmDoctorSignIn()
        {
            InitializeComponent();
        }
        SqlGoTake con= new SqlGoTake();

        private void SignIn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Tbl_Doctors where DoctorTC=@p1 and DoctorPassword=@p2",con.Connection());
            command.Parameters.AddWithValue("@p1", MskTC.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr=command.ExecuteReader();
            if (dr.Read())
            {
                FrmDoctorDetails frm = new FrmDoctorDetails();
                frm.TC=MskTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password or UserName");
            }
            con.Connection().Close();
        }
    }
}
