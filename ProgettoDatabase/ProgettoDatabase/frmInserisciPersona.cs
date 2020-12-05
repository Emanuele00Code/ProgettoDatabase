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
             if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblPersoneTableAdapter.InserisciPersona(txtCodice.Text, txtNome.Text, txtCognome.Text, txtNazione.Text, txtDataNascita.Text, txtSesso.Text, txtTipoDocumento.Text, txtNumeroDocumento.Text);
                this.Close();
            }
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

        private void radFemmina_CheckedChanged(object sender, EventArgs e)
        {
            txtSesso.Text = "Femmina";
        }

        private void radAltro_CheckedChanged(object sender, EventArgs e)
        {
            txtSesso.Text = "Altro";
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
            string Giorno = dtpDataNascita.Value.Day < 10 ? "0" + dtpDataNascita.Value.Day.ToString() : dtpDataNascita.Value.Day.ToString();
            string Mese = dtpDataNascita.Value.Month < 10 ? "0" + dtpDataNascita.Value.Month.ToString() : dtpDataNascita.Value.Month.ToString();
            txtDataNascita.Text = dtpDataNascita.Value.Year.ToString() + dtpDataNascita.Value.Month.ToString() + dtpDataNascita.Value.Day.ToString();
        }

        private void btnSalvaENuovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblPersoneTableAdapter.InserisciPersona(txtCodice.Text, txtNome.Text, txtCognome.Text, txtNazione.Text, txtDataNascita.Text, txtSesso.Text, txtTipoDocumento.Text, txtNumeroDocumento.Text);
                txtCodice.Text = "";
                txtNome.Text = "";
                txtCognome.Text = "";
                txtDataNascita.Text = "";
                txtSesso.Text = "Maschio";
                txtNazione.Text = "";
                txtTipoDocumento.Text = "Carta identità";
                txtNumeroDocumento.Text = "";
                dtpDataNascita.Value = DateTime.Today;
                radMaschio.Checked = true;
            }
        }
    }
}
