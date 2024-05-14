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
    public partial class FrmSpeciality : Form
    {
        public FrmSpeciality()
        {
            InitializeComponent();
        }
        SqlGoTake con=new SqlGoTake();

        private void FrmSpeciality_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Specialities",con.Connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into Tbl_Specialities (SpecialityName) values(@s1)", con.Connection());
            command.Parameters.AddWithValue("@s1", TxtSpecialityName.Text);
            command.ExecuteNonQuery();
            con.Connection().Close();
            MessageBox.Show("Speciality Added !");
            TxtSpecialityName.Text = "";

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtSpecialityID.Text = "";
            TxtSpecialityName.Text = "";
            int choosed = dataGridView1.SelectedCells[0].RowIndex;
            TxtSpecialityID.Text = dataGridView1.Rows[choosed].Cells[0].Value.ToString();
            TxtSpecialityName.Text = dataGridView1.Rows[choosed].Cells[1].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Tbl_Specialities where SpecialityId=@b1", con.Connection());
            command.Parameters.AddWithValue("@b1", TxtSpecialityID.Text);
            command.ExecuteNonQuery();
            con.Connection().Close();
            MessageBox.Show("Deleted !");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Specialities set SpecialityName=@p1 where SpecialityId=@b1  ", con.Connection());
            command.Parameters.AddWithValue("@p1", TxtSpecialityName.Text);
            command.Parameters.AddWithValue("@b1", TxtSpecialityID.Text);
            command.ExecuteNonQuery();
            con.Connection().Close();
            MessageBox.Show("Updated !");
        }
    }
}
