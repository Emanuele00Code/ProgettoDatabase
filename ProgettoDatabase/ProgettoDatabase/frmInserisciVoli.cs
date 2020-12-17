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
    public partial class frmInserisciVoli : Form
    {



        public frmInserisciVoli()
        {  
            InitializeComponent();
        }


        private void btnSalva_Click(object sender, EventArgs e)
        {    if ((txtCodice.Text != "") && (txtCodiceAereo.Text != "") && (txtDestinazione.Text != "") && (updDurata.Value > 0) && (updGatePartenza.Value > 0))
            {

                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tblVoliTableAdapter.InserisciVoli(txtCodice.Text, dtpDataPartenza.Value, dtpDataArrivo.Value, txtCodiceAereo.Text, txtPartenza.Text, Convert.ToByte(updDurata.Value), Convert.ToByte(updGatePartenza.Value), txtDestinazione.Text, chkInternazionale.Checked);
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtCodice.Text == "")
                {
                    errorProvider1.SetError(txtCodice, "Inserire i dati correttamente");
                }
                if (txtCodiceAereo.Text == "")
                {
                    errorProvider2.SetError(txtCodiceAereo, "Inserire i dati correttamente");
                }
                if (txtDestinazione.Text == "")
                {
                    errorProvider3.SetError(txtDestinazione, "Inserire i dati correttamente");
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






        private void btnSalvaENuovo_Click(object sender, EventArgs e)
        {
            if ((txtCodice.Text != "") && (txtCodiceAereo.Text != "") && (txtDestinazione.Text != "") && (updDurata.Value > 0) && (updGatePartenza.Value > 0))
            {

                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tblVoliTableAdapter.InserisciVoli(txtCodice.Text, dtpDataPartenza.Value, dtpDataArrivo.Value, txtCodiceAereo.Text, txtPartenza.Text, Convert.ToByte(updDurata.Value), Convert.ToByte(updGatePartenza.Value), txtDestinazione.Text, chkInternazionale.Checked);
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtCodice.Text == "")
                {
                    errorProvider1.SetError(txtCodice, "Inserire i dati correttamente");
                }
                if (txtCodiceAereo.Text == "")
                {
                    errorProvider2.SetError(txtCodiceAereo, "Inserire i dati correttamente");
                }
                if (txtDestinazione.Text == "")
                {
                    errorProvider3.SetError(txtDestinazione, "Inserire i dati correttamente");
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

    
        private void dtpDataPartenza_ValueChanged(object sender, EventArgs e)
        {
            {
                string Giorno = dtpDataPartenza.Value.Day < 10 ? "0" + dtpDataPartenza.Value.Day.ToString() : dtpDataPartenza.Value.Day.ToString();
                string Mese = dtpDataPartenza.Value.Month < 10 ? "0" + dtpDataPartenza.Value.Month.ToString() : dtpDataPartenza.Value.Month.ToString();
                txtDataNascita.Text = dtpDataPartenza.Value.Year.ToString() + dtpDataPartenza.Value.Month.ToString() + dtpDataPartenza.Value.Day.ToString();
            }
        }

        private void dtpDataArrivo_ValueChanged(object sender, EventArgs e)
        {
            {
                string Giorno = dtpDataArrivo.Value.Day < 10 ? "0" + dtpDataArrivo.Value.Day.ToString() : dtpDataArrivo.Value.Day.ToString();
                string Mese = dtpDataArrivo.Value.Month < 10 ? "0" + dtpDataArrivo.Value.Month.ToString() : dtpDataArrivo.Value.Month.ToString();
                txtDataNascita.Text = dtpDataArrivo.Value.Year.ToString() + dtpDataArrivo.Value.Month.ToString() + dtpDataArrivo.Value.Day.ToString();
            }
        }

        private void frmInserisciVoli_Load(object sender, EventArgs e)
        {

        }

        private void txtCodice_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtCodiceAereo_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider2.Clear();
        }

        private void txtDestinazione_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider3.Clear();
        }

        private void updDurata_ValueChanged(object sender, EventArgs e)
        {
            errorProvider4.Clear();
        }

        private void updGatePartenza_ValueChanged(object sender, EventArgs e)
        {
            errorProvider5.Clear();
        }

        private void txtCodice_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
