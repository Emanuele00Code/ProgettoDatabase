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
    public partial class frmModificaPersona : Form
    {

        string _CodicePersona;
        


        public frmModificaPersona()
        {  
        }

        public frmModificaPersona(string CodicePersona):this()
        {
            this._CodicePersona = CodicePersona;
            InitializeComponent();
        }



        private void frmModificaPersona_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblPersone'. È possibile spostarla o rimuoverla se necessario.
            //this.tblPersoneTableAdapter.Fill(this.aeroportoDataSet.tblPersone);
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblPersone'. È possibile spostarla o rimuoverla se necessario.
            // this.tblPersoneTableAdapter.Fill(this.aeroportoDataSet.tblPersone);
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblTipiDocumento'. È possibile spostarla o rimuoverla se necessario.
            this.tblTipiDocumentoTableAdapter.Fill(this.aeroportoDataSet.tblTipiDocumento);
            this.tblPersoneTableAdapter.FillByCodicePersona(this.aeroportoDataSet.tblPersone, this._CodicePersona);

            dtpDataNascita.Value = DateTime.ParseExact(txtDataNascita.Text, "yyyyMMdd", CultureInfo.CurrentCulture);
                  
            switch (txtSesso.Text)
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

             cmbTipoDocumento.SelectedValue = txtTipoDocumento.Text;



        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblPersoneTableAdapter.ModificaPersona(txtCodice.Text, txtNome.Text, txtCognome.Text, txtNazione.Text, txtDataNascita.Text, txtSesso.Text, txtTipoDocumento.Text, txtNumeroDocumento.Text);
            }
        }

        private void dtpDataNascita_ValueChanged(object sender, EventArgs e)
        {

            string Mese = dtpDataNascita.Value.Month <10 ? "0" + dtpDataNascita.Value.Month.ToString() : dtpDataNascita.Value.Month.ToString();
            string Giorno = dtpDataNascita.Value.Day <10 ? "0" + dtpDataNascita.Value.Day.ToString() : dtpDataNascita.Value.Day.ToString();
            txtDataNascita.Text = dtpDataNascita.Value.Year.ToString()+ Mese + Giorno;
            
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

        // Cambiare l'evento
        private void cmbTipoDocumento_SelectionChangeCommitted(object sender, EventArgs e)
        {
             txtTipoDocumento.Text = cmbTipoDocumento.SelectedValue.ToString();
        }

    }
}
