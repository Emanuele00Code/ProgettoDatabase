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
    public partial class frmInserisciPersona : Form
    {


        public frmInserisciPersona()
        {  
            InitializeComponent();
        }


        private void btnSalva_Click(object sender, EventArgs e)
        {
            tblPersoneTableAdapter.InserisciPersona(txtCodice.Text, txtNome.Text, txtCognome.Text, txtNazione.Text, txtDataNascita.Text, txtSesso.Text, txtTipoDocumento.Text, txtNumeroDocumento.Text);
            this.Close();
        }

        private void frmInserisciPersona_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblPersone'. È possibile spostarla o rimuoverla se necessario.
            //this.tblPersoneTableAdapter.Fill(this.aeroportoDataSet.tblPersone);
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblPersone'. È possibile spostarla o rimuoverla se necessario.
            this.tblPersoneTableAdapter.Fill(this.aeroportoDataSet.tblPersone);
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblTipiDocumento'. È possibile spostarla o rimuoverla se necessario.
            this.tblTipiDocumentoTableAdapter.Fill(this.aeroportoDataSet.tblTipiDocumento);
        }

        private void radMaschio_CheckedChanged(object sender, EventArgs e)
        {
            txtSesso.Text = "Maschio";
        }

        private void radAltro_CheckedChanged(object sender, EventArgs e)
        {
            txtSesso.Text = "Altro";
        }

        private void radFemmina_CheckedChanged(object sender, EventArgs e)
        {
            txtSesso.Text = "Femmina";
        }

        private void radNonSpecificato_CheckedChanged(object sender, EventArgs e)
        {
            txtSesso.Text = "Non specificato";
        }

        private void cmbTipoDocumento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtTipoDocumento.Text = cmbTipoDocumento.SelectedValue.ToString();
        }

        private void dtpDataNascita_ValueChanged(object sender, EventArgs e)
        {
            string Mese = dtpDataNascita.Value.Month < 10 ? "0" + dtpDataNascita.Value.Month.ToString() : dtpDataNascita.Value.Month.ToString();
            string Giorno = dtpDataNascita.Value.Day < 10 ? "0" + dtpDataNascita.Value.Day.ToString() : dtpDataNascita.Value.Day.ToString();
            txtDataNascita.Text = dtpDataNascita.Value.Year.ToString() + Mese + Giorno;
        }

        private void btnSalvaNuovo_Click(object sender, EventArgs e)
        {
            tblPersoneTableAdapter.InserisciPersona(txtCodice.Text, txtNome.Text, txtCognome.Text, txtNazione.Text, txtDataNascita.Text, txtSesso.Text, txtTipoDocumento.Text, txtNumeroDocumento.Text);
            txtCodice.Text = "";
            txtNome.Text = "";
            txtCognome.Text = "";
            txtDataNascita.Text = "";
            txtSesso.Text = "Maschio";
            txtNazione.Text = "";
            txtNumeroDocumento.Text = "";
            txtTipoDocumento.Text = "Carta identità";
            dtpDataNascita.Value = DateTime.Today;
            radMaschio.Checked = true;
        }
    }
}
