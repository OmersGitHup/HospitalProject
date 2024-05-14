using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalProject
{
    public partial class FrmPatientSignUp : Form
    {
        public FrmPatientSignUp()
        {
            InitializeComponent();
        }

        SqlGoTake con=new SqlGoTake();

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand command= new SqlCommand("insert into Tbl_Patients(PatientName,PatientSurname,PatientTC,PatientPhone,PatientPassword,PatientGender) values(@p1,@p2,@p3,@p4,@p5,@p6)",con.Connection());
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command.Parameters.AddWithValue("@p3", MskTC.Text);
            command.Parameters.AddWithValue("@p4", MskPhoneN.Text);
            command.Parameters.AddWithValue("@p5", TxtPassword.Text);
            command.Parameters.AddWithValue("@p6", CmbGender.Text);
            command.ExecuteNonQuery();
            con.Connection().Close();
            MessageBox.Show("Patient Saved and Password:" + TxtPassword.Text,"Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //this.Hide();

        }
    }
}
