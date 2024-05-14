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
    public partial class FrmAppointmentList : Form
    {
        public FrmAppointmentList()
        {
            InitializeComponent();
        }
        SqlGoTake con=new SqlGoTake();


        private void FrmAppointmentList_Load(object sender, EventArgs e)
        {
            DataTable dt= new DataTable();
            SqlDataAdapter da= new SqlDataAdapter("Select * From Tbl_Appointments",con.Connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        

        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //FrmSecretaryDetail.=dataGridView1.SelectedCells[0].RowIndex;



    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
