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
        readonly Action _RefreshGrid;

        public frmModificaVoli()
        {
        }
        public frmModificaVoli(Action RefreshGrid, string Codice) : this()
        {
            this._RefreshGrid = RefreshGrid;
            this._Codice = Codice;
            InitializeComponent();
        }





        private void btnSalva_Click(object sender, EventArgs e)
        {
            if ((txtCodice.Text != "") && (txtCodiceAereo.Text != "") && (txtPartenza.Text != "") && (txtDestinazione.Text != "") && (updDurata.Value > 0) && (updGatePartenza.Value > 0))
            {
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tblVoliTableAdapter.ModificaVoli(Convert.ToDateTime(dtpDataPartenza.Value), Convert.ToDateTime(dtpDataArrivo.Value), txtCodiceAereo.Text, txtPartenza.Text, Convert.ToInt16(updDurata.Value), (float)updGatePartenza.Value, txtDestinazione.Text, Convert.ToBoolean(chkInternazionale.Checked), _Codice);
                    this._RefreshGrid();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }

 

        private void frmModificaVoli_Load(object sender, EventArgs e)
        {
            
            this.tblVoliTableAdapter.FillByCodice(this.aeroportoDataSet.tblVoli,this._Codice);


         }


    }
}
