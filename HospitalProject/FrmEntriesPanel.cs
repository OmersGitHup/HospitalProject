using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProject
{
    public partial class FrmEntriesPanel : Form
    {
        public FrmEntriesPanel()
        {
            InitializeComponent();
        }

        private void BtnPatientEnter_Click(object sender, EventArgs e)
        {
            FrmPatientEntery frm = new FrmPatientEntery();
            frm.Show();
            this.Hide();


        }

        private void BtnDoctorEnter_Click(object sender, EventArgs e)
        {
            FrmDoctorSignIn frm = new FrmDoctorSignIn();
            frm.Show();
            this.Hide();
        }

        private void BtnSecretaryEnter_Click(object sender, EventArgs e)
        {
            FrmSecretaryEntry frm = new FrmSecretaryEntry();
            frm.Show();
            this.Hide();
        }
        
    }
}
