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
    public partial class frmInserisciAerei : Form
    {
        bool avvio;
        readonly Action _RefreshGrid;

        // Costruttore senza parametri
        public frmInserisciAerei()
        {
            avvio = true;
            InitializeComponent();
        }

        // Costruttore con parametri (passo il metodo RefreshGrid per il refresh della DataGridView)
        public frmInserisciAerei(Action RefreshGrid)
        {
            avvio = false;
            this._RefreshGrid = RefreshGrid;
            InitializeComponent();
        }

        // Bottone che carica i dati sul dataset, chiudendo la form
        private void btnSalva_Click(object sender, EventArgs e)
        {
               // Controllo che non ci siano dei parametri vuoti o uguali a 0
            if ((txtCodice.Text != "") && (txtCompagnia.Text != "") && (cmbModello.Text != "") && (updCapacita.Value > 0) && (updRaggio.Value > 0) && (updLitri.Value > 0) && (updMotori.Value > 0) && (updVelocita.Value > 0) && (txtPropulsione.Text != ""))
            {
                // Chiedo conferma per apportare le modifiche
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Con try e catch controllo se la chiave primaria è duplicata
                    try
                    {
                        // Richiamo la stored procedure InserisciAerei, per inserire i nuovi dati nel dataset
                        tblAereiTableAdapter.InserisciAerei(txtCodice.Text, cmbModello.Text, Convert.ToInt16(updCapacita.Value), Convert.ToInt16(updLitri.Value), Convert.ToByte(updMotori.Value), txtPropulsione.Text, chkInternazionale.Checked, Convert.ToInt16(updRaggio.Value), Convert.ToInt16(updVelocita.Value), txtCompagnia.Text);
                        if (!this.avvio)
                        {
                            this._RefreshGrid();
                            
                        }
                        this.Close();
                    }
                    // In caso di chiave primaria duplicata
                    catch (SqlException ex) when (ex.Number == 2627)
                    {
                        MessageBox.Show("Chiave primaria duplicata, usarne una differente");
                    }
                    
                }
            }
            // Se sono presenti degli errori
            else
            {
                // Imposto gli error provider in modo da vedere dove non è corretto l'inserimento
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtCodice.Text == "")
                {
                    errorProvider1.SetError(txtCodice, "Inserire i dati correttamente");
                }
                if (txtCompagnia.Text == "")
                {
                    errorProvider2.SetError(txtCompagnia, "Inserire i dati correttamente");
                }
               
                if (cmbModello.Text == "")
                {
                    errorProvider4.SetError(cmbModello, "Inserire i dati correttamente");
                }
                if (updCapacita.Value <= 0)
                {
                    errorProvider5.SetError(updCapacita, "Inserire i dati correttamente");
                }
                if (updRaggio.Value <= 0)
                {
                    errorProvider6.SetError(updRaggio, "Inserire i dati correttamente");
                }
                if (updLitri.Value <= 0)
                {
                    errorProvider7.SetError(updLitri, "Inserire i dati correttamente");
                }
                if (updMotori.Value <= 0)
                {
                    errorProvider8.SetError(updMotori, "Inserire i dati correttamente");
                }
                if (txtPropulsione.Text == "")
                {
                    errorProvider9.SetError(txtPropulsione, "Inserire i dati correttamente");
                }
                if (updVelocita.Value <= 0)
                {
                    errorProvider10.SetError(updVelocita, "Inserire i dati correttamente");
                }
            }
        }


        // Bottone che carica i dati sul dataset e ci permette di creare un nuovo Aereo
        private void btnSalvaENuovo_Click(object sender, EventArgs e)
        {
            // Controllo che non ci siano dei parametri vuoti o uguali a 0
            if ((txtCodice.Text != "") && (txtCompagnia.Text != "")  && (cmbModello.Text != "") && (updCapacita.Value > 0) && (updRaggio.Value > 0) && (updLitri.Value > 0) && (updMotori.Value > 0) && (updVelocita.Value > 0) && (txtPropulsione.Text != ""))
            {
                // Chiedo conferma per apportare le modifiche

                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Con try e catch controllo se la chiave primaria è duplicata
                    try
                    {
                        // Richiamo la stored procedure InserisciAerei, per inserire i nuovi dati nel dataset
                        tblAereiTableAdapter.InserisciAerei(txtCodice.Text, cmbModello.Text, Convert.ToInt16(updCapacita.Value), Convert.ToInt16(updLitri.Value), Convert.ToByte(updMotori.Value), txtPropulsione.Text, chkInternazionale.Checked, Convert.ToInt16(updRaggio.Value), Convert.ToInt16(updVelocita.Value), txtCompagnia.Text);
                        // Imposto tutti i componenti della form a 0 o vuoti
                        txtCodice.Text = "";
                        txtCompagnia.Text = "";
                        cmbModello.Text = "";
                        updCapacita.Value = 0;
                        updLitri.Value = 0;
                        updMotori.Value = 0;
                        updRaggio.Value = 0;
                        updVelocita.Value = 0;
                        txtPropulsione.Text = "";
                        chkInternazionale.Checked = false;
                        // Aggiorno la DataGridView Aerei
                        if (!this.avvio)
                        {
                            this._RefreshGrid();
                        }
                    }
                    // In caso di chiave primaria duplicata
                    catch (SqlException ex) when (ex.Number == 2627)
                    {
                        MessageBox.Show("Chiave primaria duplicata, usarne una differente");
                    }
                    
                }
            }
            // Se sono presenti degli errori
            else
            {
                // Imposto gli error provider in modo da vedere dove non è corretto l'inserimento
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtCodice.Text == "")
                {
                    errorProvider1.SetError(txtCodice, "Inserire i dati correttamente");
                }
                if (txtCompagnia.Text == "")
                {
                    errorProvider2.SetError(txtCompagnia, "Inserire i dati correttamente");
                }
               
                if (cmbModello.Text == "")
                {
                    errorProvider4.SetError(cmbModello, "Inserire i dati correttamente");
                }
                if (updCapacita.Value <= 0)
                {
                    errorProvider5.SetError(updCapacita, "Inserire i dati correttamente");
                }
                if (updRaggio.Value <= 0)
                {
                    errorProvider6.SetError(updRaggio, "Inserire i dati correttamente");
                }
                if (updLitri.Value <= 0)
                {
                    errorProvider7.SetError(updLitri, "Inserire i dati correttamente");
                }
                if (updMotori.Value <= 0)
                {
                    errorProvider8.SetError(updMotori, "Inserire i dati correttamente");
                }
                if (txtPropulsione.Text == "")
                {
                    errorProvider9.SetError(txtPropulsione, "Inserire i dati correttamente");
                }
                if (updVelocita.Value <= 0)
                {
                    errorProvider10.SetError(updVelocita, "Inserire i dati correttamente");
                }
            }
        }

        // Pulisco gli error provider se vengono effettuate le modifiche ai componenti
        private void updCapacita_ValueChanged(object sender, EventArgs e)
        {
            errorProvider5.Clear();
        }

        private void updLitri_ValueChanged(object sender, EventArgs e)
        {
            errorProvider7.Clear();
        }

        private void updMotori_ValueChanged(object sender, EventArgs e)
        {
            errorProvider8.Clear();
        }

        private void updRaggio_ValueChanged(object sender, EventArgs e)
        {
            errorProvider6.Clear();
        }

        private void updVelocita_ValueChanged(object sender, EventArgs e)
        {
            errorProvider10.Clear();
        }

        private void txtCodice_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void cmbModello_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider4.Clear();
        }


        private void txtPropulsione_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider9.Clear();

        }

        private void txtCompagnia_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider2.Clear();
        }

        private void frmInserisciAerei_Load(object sender, EventArgs e)
        {
            this.marcheTableAdapter.Fill(this.aeroportoDataSet.Marche);
             this.modelliTableAdapter.Fill(this.aeroportoDataSet.Modelli);

        }

        private void cmbMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string marca = cmbMarca.SelectedValue.ToString();
            this.modelliTableAdapter.FillByMarca(this.aeroportoDataSet.Modelli, marca);
        }

    }
}
