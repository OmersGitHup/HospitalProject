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
    public partial class FrmSecretaryEntry : Form
    {
        public FrmSecretaryEntry()
        {
            InitializeComponent();
        }

        SqlGoTake con=new SqlGoTake();
        private void SignIn_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * From Tbl_Secretaries where SecretaryTC=@p1 and SecretaryPassword=@p2",con.Connection());
            sqlCommand.Parameters.AddWithValue("@p1", MskTC.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                FrmSecretaryDetail goFormSecdetail = new FrmSecretaryDetail();
                goFormSecdetail.tcSecretary=MskTC.Text;
                goFormSecdetail.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Password or Username");
            }

        }
    }
}
