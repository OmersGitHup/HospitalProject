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
    public partial class FrmPatientDetail : Form
    {
        public FrmPatientDetail()
        {
            InitializeComponent();
        }

        public string PatientID;

        SqlGoTake con=new SqlGoTake();
        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            LblTC.Text= PatientID;
             

            //Take Name Surname
            SqlCommand command=new SqlCommand("Select PatientName,PatientSurname From Tbl_Patients Where PatientTC=@p1",con.Connection());
            command.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr= command.ExecuteReader();
            while(dr.Read())
            {
                LblNamSur.Text = dr[0] +" "+ dr[1];
            }
            con.Connection().Close();

            //Appointment History

            DataTable dt= new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select * From Tbl_Appointments where PatientTC="+LblTC.Text,con.Connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //Take Specialities
            SqlCommand command1 = new SqlCommand("Select SpecialityName From Tbl_Specialities", con.Connection());
            SqlDataReader dr2 = command1.ExecuteReader();
            while(dr2.Read())
            {
                cmbSpeciality.Items.Add(dr2[0]);
            }
            con.Connection().Close();

        }

        private void cmbSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();
            SqlCommand command3 = new SqlCommand("Select DoctorName,DoctorSurname From Tbl_Doctors where DoctorSpeciality=@p1", con.Connection());
            command3.Parameters.AddWithValue("@p1", cmbSpeciality.Text);
            SqlDataReader dr3 = command3.ExecuteReader();
            while(dr3.Read())
            {
                CmbDoctor.Items.Add(dr3[0]+" "+ dr3[1]);
            }
            con.Connection().Close();
        }

        private void CmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointments where AppointmentSpeciality='"+cmbSpeciality.Text+"'" + "and AppointmentDoctor='"+CmbDoctor.Text+"'and AppointmentStatu=0",con.Connection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LnkEditInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEditInfo fr= new FrmEditInfo();
            fr.tcno = LblTC.Text;
            fr.Show();
        }

        private void getAppointment_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Appointments set AppointmentStatu=1,PatientTC=@p1,PatientComplaint=@p2 where AppointmentId=@p3", con.Connection());
            command.Parameters.AddWithValue("@p1",PatientID);
            command.Parameters.AddWithValue("@p2",RictTextComplain.Text);
            command.Parameters.AddWithValue("@p3",txtAppointmentId.Text);
            command.ExecuteNonQuery();
            con.Connection().Close();
            MessageBox.Show("Appointment Created ","Info",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosed = dataGridView2.SelectedCells[0].RowIndex;
            txtAppointmentId.Text = dataGridView2.Rows[choosed].Cells[0].Value.ToString();
        }
    }
}
