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
        {
            if((txtCodice.Text!="")&&(txtCodiceAereo.Text!="")&&(txtPartenza.Text!="")&&(txtDestinazione.Text!="")&&(updDurata.Value>0)&&(updGatePartenza.Value>0))
            {
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tblVoliTableAdapter.InserisciVoli(txtCodice.Text, dtpDataPartenza.Value, dtpDataArrivo.Value, txtCodiceAereo.Text, txtPartenza.Text, Convert.ToByte(updDurata.Value), Convert.ToByte(updGatePartenza.Value), txtDestinazione.Text, chkInternazionale.Checked);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero","Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }

      



        private void btnSalvaENuovo_Click(object sender, EventArgs e)
        {
            if ((txtCodice.Text != "") && (txtCodiceAereo.Text != "") && (txtPartenza.Text != "") && (txtDestinazione.Text != "") && (updDurata.Value > 0) && (updGatePartenza.Value > 0))
            {
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tblVoliTableAdapter.InserisciVoli(txtCodice.Text, dtpDataPartenza.Value, dtpDataArrivo.Value, txtCodiceAereo.Text, txtPartenza.Text, Convert.ToByte(updDurata.Value), Convert.ToByte(updGatePartenza.Value), txtDestinazione.Text, chkInternazionale.Checked);
                    txtCodice.Text = "";
                    dtpDataPartenza.Value = DateTime.Today;
                    dtpDataArrivo.Value = DateTime.Today;
                    txtCodice.Text = "";
                    txtPartenza.Text = "";
                    updDurata.Value = 0;
                    updGatePartenza.Value = 0;
                    txtDestinazione.Text = "";
                    chkInternazionale.Checked = false;


                }
            }
            else
            {
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
    
}
