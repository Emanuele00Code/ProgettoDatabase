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
    public partial class frmInserisciAeroporti : Form
    {


        readonly Action _RefreshGrid;
        public frmInserisciAeroporti(Action RefreshGrid)
        {
            this._RefreshGrid = RefreshGrid;
            InitializeComponent();
        }
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
                    
                    try
                    {
                        tblAeroportiTableAdapter.InserisciAeroporto(txtSigla.Text, txtNome.Text, Convert.ToByte(updGates.Value), Convert.ToByte(updTerminal.Value), Convert.ToByte(updGates.Value), txtNazione.Text, txtCitta.Text, cbkMilitare.Checked, cbkInternazionale.Checked);
                        this._RefreshGrid();
                        this.Close();
                    }
                    catch (SqlException ex) when (ex.Number == 2627)
                    {
                        MessageBox.Show("Chiave primaria duplicata, usarne una differente");
                    }
                }
            }
            else
            {
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtSigla.Text == "")
                {
                    errorProvider1.SetError(txtSigla, "Inserire i dati correttamente");
                }
                if (txtNome.Text == "")
                {
                    errorProvider2.SetError(txtNome, "Inserire i dati correttamente");
                }
                if (txtNazione.Text == "")
                {
                    errorProvider3.SetError(txtNazione, "Inserire i dati correttamente");
                }
                if (txtCitta.Text == "")
                {
                    errorProvider4.SetError(txtCitta, "Inserire i dati correttamente");
                }
                if (updPiste.Value <= 0)
                {
                    errorProvider5.SetError(updPiste, "Inserire i dati correttamente");
                }
                if (updGates.Value <= 0)
                {
                    errorProvider6.SetError(updGates, "Inserire i dati correttamente");
                }
                if (updTerminal.Value <= 0)
                {
                    errorProvider7.SetError(updTerminal, "Inserire i dati correttamente");
                }
            }
            }

            private void frmInserisciPersona_Load(object sender, EventArgs e)
        {
            this.tblAeroportiTableAdapter.Fill(this.aeroportoDataSet.tblAeroporti);
        }




        private void btnSalvaENuovo_Click(object sender, EventArgs e)
        {
            if ((txtSigla.Text != "") && (txtNome.Text != "") && (txtNazione.Text != "") && (txtCitta.Text != "") && (updPiste.Value > 0) && (updTerminal.Value > 0) && (updGates.Value > 0))
            { 
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
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
                        this._RefreshGrid();
                    }
                    catch (SqlException ex) when (ex.Number == 2627)
                    {
                        MessageBox.Show("Chiave primaria duplicata, usarne una differente");
                    }
                }
            }
            else
            {
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtSigla.Text == "")
                {
                    errorProvider1.SetError(txtSigla, "Inserire i dati correttamente");
                }
                if (txtNome.Text == "")
                {
                    errorProvider2.SetError(txtNome, "Inserire i dati correttamente");
                }
                if (txtNazione.Text == "")
                {
                    errorProvider3.SetError(txtNazione, "Inserire i dati correttamente");
                }
                if (txtCitta.Text =="")
                {
                    errorProvider4.SetError(txtCitta, "Inserire i dati correttamente");
                }
                if (updPiste.Value <= 0)
                {
                    errorProvider5.SetError(updPiste, "Inserire i dati correttamente");
                }
                if (updGates.Value <= 0)
                {
                    errorProvider6.SetError(updGates, "Inserire i dati correttamente");
                }
                if (updTerminal.Value <= 0)
                {
                    errorProvider7.SetError(updTerminal, "Inserire i dati correttamente");
                }
            }
        }

        private void txtSigla_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider2.Clear();
        }

        private void txtNazione_TextChanged(object sender, EventArgs e)
        {
            errorProvider3.Clear();
        }

        private void updPiste_ValueChanged(object sender, EventArgs e)
        {
            errorProvider5.Clear();

        }

        private void updTerminal_ValueChanged(object sender, EventArgs e)
        {
            errorProvider7.Clear();

        }

        private void updGates_ValueChanged(object sender, EventArgs e)
        {
            errorProvider6.Clear();

        }

        private void txtCitta_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider4.Clear();
        }
    }
}
