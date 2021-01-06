using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoDatabase
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

   

        private void frmAvvio_Load(object sender, EventArgs e)
        {

        }


        private void btn_Aerei_Click(object sender, EventArgs e)
        {
            frmAerei myForm1 = new frmAerei();
            myForm1.Show();
        }

        private void btnVoli_Click(object sender, EventArgs e)
        {
            frmVoli myForm2 = new frmVoli();
            myForm2.Show();
        }

        private void btnAereoporti_Click(object sender, EventArgs e)
        {
            frmAeroporti myForm3 = new frmAeroporti();
            myForm3.Show();
        }

        private void aeroportoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInserisciAeroporti FormDaAprire = new frmInserisciAeroporti();
            FormDaAprire.Show();
        }

        private void voloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInserisciVoli FormDaAprire = new frmInserisciVoli();
            FormDaAprire.Show();
        }

        private void aereoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInserisciAerei FormDaAprire = new frmInserisciAerei();
            FormDaAprire.Show();
        }


    }
}
