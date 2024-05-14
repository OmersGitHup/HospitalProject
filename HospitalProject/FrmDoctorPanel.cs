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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }
        SqlGoTake con=new SqlGoTake();

        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("Select * From Tbl_Doctors", con.Connection());
            sqlDataAdapter2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            //Take Specialities
            SqlCommand cmd2 = new SqlCommand("Select SpecialityName from Tbl_Specialities", con.Connection());
            SqlDataReader sqlDataReader = cmd2.ExecuteReader();
            while (sqlDataReader.Read())
            {
                CmbSpe.Items.Add(sqlDataReader[0]);
            }
            con.Connection().Close();


        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into Tbl_Doctors (DoctorName,DoctorSurname,DoctorSpeciality,DoctorTC,DoctorPassword) values(@d1,@d2,@d3,@d4,@d5)",con.Connection());
            command.Parameters.AddWithValue("@d1", TxtName.Text);
            command.Parameters.AddWithValue("@d2",TxtSurname.Text);
            command.Parameters.AddWithValue("@d3", CmbSpe.Text);
            command.Parameters.AddWithValue("@d4", MskTC.Text);
            command.Parameters.AddWithValue("@d5", TxtPassword.Text);
            command.ExecuteNonQuery();
            con.Connection().Close();
            MessageBox.Show("Doctor Created", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            TxtName.Text = "";
            TxtSurname.Text = "";
            CmbSpe.Text = "";
            MskTC.Text = "";
            TxtPassword.Text = "";
            int choosed = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[choosed].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[choosed].Cells[2].Value.ToString();
            CmbSpe.Text = dataGridView1.Rows[choosed].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[choosed].Cells[4].Value.ToString();
            TxtPassword.Text = dataGridView1.Rows[choosed].Cells[5].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Tbl_Doctors where DoctorTC=@p1",con.Connection());
            command.Parameters.AddWithValue("@p1", MskTC.Text);
            command.ExecuteNonQuery();
             con.Connection().Close();
            MessageBox.Show("Doctor Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtName.Text = "";
            TxtSurname.Text = "";
            CmbSpe.Text = "";
            MskTC.Text = "";
            TxtPassword.Text = "";



        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Doctors set DoctorName=@d1,DoctorSurname=@d2,DoctorSpeciality=@d3,DoctorTC=@d4,DoctorPassword=@d5 where DoctorTC=@d4", con.Connection());
            command.Parameters.AddWithValue("@d1", TxtName.Text);
            command.Parameters.AddWithValue("@d2", TxtSurname.Text);
            command.Parameters.AddWithValue("@d3", CmbSpe.Text);
            command.Parameters.AddWithValue("@d4", MskTC.Text);
            command.Parameters.AddWithValue("@d5", TxtPassword.Text);
            command.ExecuteNonQuery();
            con.Connection().Close();
            MessageBox.Show("Doctor Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
