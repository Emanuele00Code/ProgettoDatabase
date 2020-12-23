using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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



        private void dtpDataPartenza_ValueChanged(object sender, EventArgs e)
        {
            dtpDataPartenza.Value.ToString("dd/MM/yyyy HH:mm:ss");
            TimeSpan tp = Convert.ToDateTime(dtpDataArrivo.Value) - Convert.ToDateTime(dtpDataPartenza.Value);
            if (tp.TotalMinutes < 0)
            {
                dtpDataArrivo.Value = dtpDataPartenza.Value;
                updDurata.Value = 0;
            }
            else
            {
                updDurata.Value = (decimal)tp.TotalMinutes;
            }
        }
        private void dtpDataArrivo_ValueChanged(object sender, EventArgs e)
        {
            dtpDataArrivo.Text = dtpDataArrivo.Value.ToString("dd/MM/yyyy HH:mm:ss");
            TimeSpan tp = Convert.ToDateTime(dtpDataArrivo.Value) - Convert.ToDateTime(dtpDataPartenza.Value);
            if (tp.TotalMinutes < 0)
            {
                dtpDataPartenza.Value = dtpDataArrivo.Value;
                updDurata.Value=0;
            }
            else
            {
                updDurata.Value = (decimal)tp.TotalMinutes;
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if ((txtCodiceAereo.Text != "") && (updDurata.Value > 0) && (updGatePartenza.Value > 0))
            {

                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                        tblVoliTableAdapter.ModificaVoli( Convert.ToDateTime(dtpDataPartenza.Value), Convert.ToDateTime(dtpDataArrivo.Value), txtCodiceAereo.Text,
                           txtPartenza.Text, Convert.ToInt16(updDurata.Value), Convert.ToByte(updGatePartenza.Value), chkInternazionale.Checked, _Codice);
                    this._RefreshGrid();

                }

            }
            else
            {
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                if (txtCodiceAereo.Text == "")
                {
                    errorProvider2.SetError(txtCodiceAereo, "Inserire i dati correttamente");
                }
                if (updDurata.Value <= 0)
                {
                    errorProvider4.SetError(updDurata, "Inserire i dati correttamente");
                }
                if (updGatePartenza.Value <= 0)
                {
                    errorProvider5.SetError(updGatePartenza, "Inserire i dati correttamente");
                }
            }
        }



        private void frmModificaVoli_Load(object sender, EventArgs e)
        {
            
            this.tblVoliTableAdapter.FillByCodice(this.aeroportoDataSet.tblVoli,this._Codice);


         }

        private void txtCodiceAereo_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider2.Clear();
        }


        private void updDurata_ValueChanged(object sender, EventArgs e)
        {
            errorProvider4.Clear();
        }

        private void updGatePartenza_ValueChanged(object sender, EventArgs e)
        {
            errorProvider5.Clear();
        }

  
    }
}
