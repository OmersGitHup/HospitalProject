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
    public partial class FrmAnnon : Form
    {
        public FrmAnnon()
        {
            InitializeComponent();
        }

        SqlGoTake con=new SqlGoTake();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FrmAnnon_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Announcment", con.Connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
