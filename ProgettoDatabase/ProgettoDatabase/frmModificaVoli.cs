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
                tblVoliTableAdapter.ModificaVoli(Convert.ToDateTime(dtpDataPartenza.Value), Convert.ToDateTime(dtpDataArrivo.Value), txtCodiceAereo.Text, txtPartenza.Text, Convert.ToInt16(updDurata.Value), (float)updGatePartenza.Value, txtDestinazione.Text, Convert.ToBoolean(chkInternazionale.Checked), _Codice);
            }
        }

 

        private void frmModificaVoli_Load(object sender, EventArgs e)
        {
            
            this.tblVoliTableAdapter.FillByCodice(this.aeroportoDataSet.tblVoli,this._Codice);


         }

    }
}
