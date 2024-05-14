using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject
{
    public partial class FrmSecretaryDetail : Form
    {
        public FrmSecretaryDetail()
        {
            InitializeComponent();
        }

        public string tcSecretary;
        SqlGoTake con = new SqlGoTake();
        private void FrmSecretaryDetail_Load(object sender, EventArgs e)
        {
            LblTC.Text = tcSecretary;


            //Get Name Surname

            SqlCommand cmd = new SqlCommand("Select SecretaryNameSurname From Tbl_Secretaries where SecretaryTC=@p1",con.Connection());
            cmd.Parameters.AddWithValue("@p1", tcSecretary);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                LblNameSurname.Text = da[0].ToString();
            }
            con.Connection().Close();
            
            //Take Specialities
            DataTable dt1= new DataTable();
            SqlDataAdapter sqlDataadapter = new SqlDataAdapter("Select * From Tbl_Specialities", con.Connection());
            sqlDataadapter.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Take Doctors Details
            DataTable dt2= new DataTable();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("Select (DoctorName+'  '+DoctorSurname) as 'Doctor',DoctorSpeciality From Tbl_Doctors", con.Connection());
            sqlDataAdapter2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Take Specialities
            SqlCommand cmd2 = new SqlCommand("Select SpecialityName from Tbl_Specialities", con.Connection());
            SqlDataReader sqlDataReader = cmd2.ExecuteReader();
            while (sqlDataReader.Read())
            {
                CmbSpe.Items.Add(sqlDataReader[0]);
            }
            con.Connection().Close();

        }
        

        private void BtnAppoinCreate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Appointments (AppointmentDate,AppointmetTime,AppointmentSpeciality,AppointmentDoctor) values (@a1,@a2,@a3,@a4)",con.Connection());
            command.Parameters.AddWithValue("@a1", MskDate.Text);
            command.Parameters.AddWithValue("@a2", MskTime.Text);
            command.Parameters.AddWithValue("@a3", CmbSpe.Text);
            command.Parameters.AddWithValue("@a4", CmbDoctor.Text);
            command.ExecuteNonQuery();
            con.Connection().Close();
            MessageBox.Show("Appointment Created! ");
        }

        private void CmbSpe_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();
            CmbDoctor.Text = "";

            SqlCommand command = new SqlCommand("Select DoctorName,DoctorSurname from Tbl_Doctors where DoctorSpeciality=@p1 ", con.Connection());
            command.Parameters.AddWithValue("@p1",CmbSpe.Text);
            SqlDataReader dr= command.ExecuteReader();
            while (dr.Read())
            {
                CmbDoctor.Items.Add(dr[0]+" " + dr[1]);
            }
            con.Connection().Close();
        }

        private void BtnCreateAnnoun_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Insert into Tbl_Announcment(Announcment) values(@a1)", con.Connection());
            sqlCommand.Parameters.AddWithValue("@a1",RchAnnou.Text);
            sqlCommand.ExecuteNonQuery();
            con.Connection().Close ();
            MessageBox.Show("Announcment Created !");
            RchAnnou.Text = "";
        }

        private void BtnDoctorPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel fdp= new FrmDoctorPanel();
            fdp.Show();
        }

        private void BtnSpecialityPanel_Click(object sender, EventArgs e)
        {
            FrmSpeciality speciality= new FrmSpeciality();
            speciality.Show();
        }

        private void BtnListAppoint_Click(object sender, EventArgs e)
        {
            FrmAppointmentList frmAppointmentList = new FrmAppointmentList();
            frmAppointmentList.Show();
        }

        public int id;
         

        private void BtnAppoinUpdate_Click(object sender, EventArgs e)
        {
        //    SqlCommand command = new SqlCommand("Update Tbl_Appoinmtments set AppointmentId=@di,AppointmentDate=@d1,AppointmetTime=@d2,AppointmentSpeciality=@d3,AppointmentDoctor=@d4,AppointmentStatu=@d5,PatientTC=@6 where AppointmentId=@c", con.Connection());
        //    command.Parameters.AddWithValue("@d1", TxtID.Text);
        }

        private void btnAnnouncment_Click(object sender, EventArgs e)
        {
            FrmAnnon frmAnnon = new FrmAnnon();
            frmAnnon.Show();
        }
    }
}
