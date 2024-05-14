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
    public partial class FrmDoctorEditInfo : Form
    {
        public FrmDoctorEditInfo()
        {
            InitializeComponent();
        }
        SqlGoTake con=new SqlGoTake();

        public string TCno;
        private void FrmDoctorEditInfo_Load(object sender, EventArgs e)
        {
            MskTC.Text= TCno;
            SqlCommand command= new SqlCommand("Select * From Tbl_Doctors where DoctorTC=@p1",con.Connection());
            command.Parameters.AddWithValue("@p1", TCno);
            SqlDataReader dr=command.ExecuteReader();
            while(dr.Read())
            {
                TxtName.Text = dr[1].ToString();
                TxtSurname.Text = dr[2].ToString();
                CmbSpecialities.Text = dr[3].ToString();
                TxtPassword.Text = dr[5].ToString();
            }con.Connection().Close();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Doctors set DoctorName=@p1,DoctorSurname=@p2,DoctorSpeciality=@p3,DoctorPassword=@p4 where DoctorTC=@p5" , con.Connection());
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command.Parameters.AddWithValue("@p3",CmbSpecialities.Text);
            command.Parameters.AddWithValue("@p4",TxtPassword.Text);
            command.Parameters.AddWithValue("@p5",TCno);
            command.ExecuteNonQuery();
            con.Connection().Close();
            MessageBox.Show("Updated !");
        }
    }
}
