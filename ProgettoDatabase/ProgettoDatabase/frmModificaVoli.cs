using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgettoDatabase.Classi;

namespace ProgettoDatabase
{
    public partial class frmModificaVoli : Form
    {

        string _Codice;

        public frmModificaVoli()
        {
        }

        public frmModificaVoli(string Codice) : this()
        {
            this._Codice = Codice;
            InitializeComponent();
        }




        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //tblVoliTableAdapter.InserisciVoli(txtCodice.Text, txtCodiceAereo.Text, Convert.ToByte(updDurata.Value), Convert.ToByte(updGatePartenza.Value), txtPartenza.Text);
            }
        }

 

        private void frmModificaVoli_Load(object sender, EventArgs e)
        {
            
            this.tblVoliTableAdapter.FillByCodice(this.aeroportoDataSet.tblVoli,this._Codice);


         }

    }
}
