using ProgettoDatabase.Classi;
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

namespace ProgettoDatabase
{
    public partial class frmVisualizzaVoli : Form
    {

        Voli _MioVolo;

        //Metodo cotruttore senza parametri
        public frmVisualizzaVoli()
        {
        }

        //Metodo cotruttore con parametri
        public frmVisualizzaVoli(Voli MioVolo) : this()
        {
            this._MioVolo = MioVolo;
            InitializeComponent();
        }
        private void frmVisualizzaVoli_Load(object sender, EventArgs e)
        {
            // Con l'utilizzo del metodo fill aggiungo/aggiorno righe all'interno del dataset
            this.tblVoliTableAdapter.Fill(this.aeroportoDataSet.tblVoli);

            // Riempo i componenti della form con i dati relativi al volo "_MioVolo"
            txtCodice.Text = this._MioVolo.Codice;
            txtCodiceAereo.Text = this._MioVolo.CodiceAereo;
            dtpDataArrivo.Value = Convert.ToDateTime(this._MioVolo.DataOraArrivo);
            dtpDataPartenza.Value = Convert.ToDateTime(this._MioVolo.DataOraPartenza);
            txtCodiceAereo.Text = this._MioVolo.CodiceAereo;
            updDurata.Value = this._MioVolo.Durata;
            updGatePartenza.Value = this._MioVolo.GatePartenza;
            //Controllo se Internazionale sia true
            if (this._MioVolo.Internazionale == true)
            {
                chkInternazionale.Checked = true;
            }

        }

    }
}
