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
    public partial class frmInserisciAeroporti : Form
    {



        public frmInserisciAeroporti()
        {  
            InitializeComponent();
        }


        private void btnSalva_Click(object sender, EventArgs e)
        {
            if ((txtSigla.Text != "") && (txtNome.Text != "") && (txtNazione.Text != "") && (txtCitta.Text != "") && (updPiste.Value > 0) && (updTerminal.Value > 0) && (updGates.Value > 0))
            {
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tblAeroportiTableAdapter.InserisciAeroporto(txtSigla.Text, txtNome.Text, Convert.ToByte(updGates.Value), Convert.ToByte(updTerminal.Value), Convert.ToByte(updGates.Value), txtNazione.Text, txtCitta.Text, cbkMilitare.Checked, cbkInternazionale.Checked);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void frmInserisciPersona_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblAeroporti'. È possibile spostarla o rimuoverla se necessario.
            this.tblAeroportiTableAdapter.Fill(this.aeroportoDataSet.tblAeroporti);
        }




        private void btnSalvaENuovo_Click(object sender, EventArgs e)
        {
            if ((txtSigla.Text != "") && (txtNome.Text != "") && (txtNazione.Text != "") && (txtCitta.Text != "") && (updPiste.Value > 0) && (updTerminal.Value > 0) && (updGates.Value > 0))
            { 
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblAeroportiTableAdapter.InserisciAeroporto(txtSigla.Text, txtNome.Text, Convert.ToByte(updGates.Value), Convert.ToByte(updTerminal.Value), Convert.ToByte(updGates.Value), txtNazione.Text, txtCitta.Text, cbkMilitare.Checked, cbkInternazionale.Checked);
                txtSigla.Text = "";
                txtNome.Text = "";
                updPiste.Value = 0;
                updTerminal.Value = 0;
                updGates.Value = 0;
                txtNazione.Text = "";
                txtCitta.Text = "";
                cbkMilitare.Checked = false;
                cbkInternazionale.Checked = false;
            }
            }
            else
            {
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        }
}
