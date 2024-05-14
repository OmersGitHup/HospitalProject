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
    public partial class FrmDoctorDetails : Form
    {
        public FrmDoctorDetails()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        SqlGoTake con=new SqlGoTake();
        public string TC;

        private void FrmDoctorDetails_Load(object sender, EventArgs e)
        {
            LblTC.Text= TC;

            //DoctorNameSurname
            SqlCommand command = new SqlCommand("Select DoctorName,DoctorSurname From Tbl_Doctors where DoctorTC=@p1",con.Connection());
            command.Parameters.AddWithValue("@p1",TC);
            SqlDataReader dr= command.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[0] + " " + dr[1];
            }con.Connection();

            //GetAppointment
            DataTable dt=new DataTable();
            SqlDataAdapter da =new SqlDataAdapter("Select * From Tbl_Appointments where AppointmentDoctor='"+LblNameSurname.Text+"'",con.Connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void BtnEditInfo_Click(object sender, EventArgs e)
        {
            FrmDoctorEditInfo frm = new FrmDoctorEditInfo();
            frm.TCno = TC;
            frm.Show();
        }

        private void BtnAnnouncment_Click(object sender, EventArgs e)
        {
            FrmAnnon frm = new FrmAnnon();
            frm.Show();
        }

        private void BtnSıgnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosed = dataGridView1.SelectedCells[0].RowIndex;
            RchComplain.Text = dataGridView1.Rows[choosed].Cells[7].Value.ToString();
        }
    }
}
