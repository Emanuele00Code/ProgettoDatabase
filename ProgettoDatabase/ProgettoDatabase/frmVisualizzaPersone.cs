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
using TestDatabase.Classi;

namespace TestDatabase
{
    public partial class frmVisualizzaPersona : Form
    {

        Persona _MiaPersona;

        public frmVisualizzaPersona()
        {  
        }

        public frmVisualizzaPersona(Persona MiaPersona): this()
        {
            this._MiaPersona = MiaPersona;
            InitializeComponent();
        }



   

        private void btnSalva_Click(object sender, EventArgs e)
        {
         
        }

        private void frmVisualizzaPersona_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblPersone'. È possibile spostarla o rimuoverla se necessario.
            //this.tblPersoneTableAdapter.Fill(this.aeroportoDataSet.tblPersone);
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblPersone'. È possibile spostarla o rimuoverla se necessario.
            this.tblPersoneTableAdapter.Fill(this.aeroportoDataSet.tblPersone);
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblTipiDocumento'. È possibile spostarla o rimuoverla se necessario.
            this.tblTipiDocumentoTableAdapter.Fill(this.aeroportoDataSet.tblTipiDocumento);


            txtCodice.Text = this._MiaPersona.CodicePersona;
            txtNome.Text = this._MiaPersona.Nome;
            txtCognome.Text = this._MiaPersona.Cognome;
            txtNazione.Text = this._MiaPersona.Nazione;
            dtpDataNascita.Value = DateTime.ParseExact(this._MiaPersona.DataNascita, "yyyyMMdd", CultureInfo.InvariantCulture);

            switch (this._MiaPersona.Sesso)
            {
                case "Maschio":
                    radMaschio.Checked = true;
                    break;
                case "Femmina":
                    radFemmina.Checked = true;
                    break;
                case "Altro":
                    radAltro.Checked = true;
                    break;
                case "Non specificato":
                    radNonSpecificato.Checked = true;
                    break;
            }

            cmbTipoDocumento.SelectedValue = this._MiaPersona.TipoDocumento;
            txtNumeroDocumento.Text = this._MiaPersona.NumeroDocumento;


        }
    }
}
