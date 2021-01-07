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
    public partial class frmInserisciVoli : Form
    {

        bool avvio;
        readonly Action _RefreshGrid;
        //Metodo costruttore senza parametri
        public frmInserisciVoli()
        {
            avvio = true;
            InitializeComponent();
        }

        //Metodo costruttore con parametri
        public frmInserisciVoli(Action RefreshGrid)
        {
            avvio = false;
            this._RefreshGrid = RefreshGrid;
            InitializeComponent();
        }

        //Evento di Salva
        private void btnSalva_Click(object sender, EventArgs e)
        {
            //If che controlla che non ci siano dei parametri vuoti o uguali a 0
            if ((txtCodice.Text != "") && (updDurata.Value > 0) && (updGatePartenza.Value > 0))
            {
                //If che chiede la conferma delle modifiche
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Con try e catch controllo se la chiave primaria è duplicata
                    try
                    {
                        // Richiamo la stored procedure InserisciVoli, per inserire i nuovi dati nel dataset
                        tblVoliTableAdapter.InserisciVoli(txtCodice.Text, dtpDataPartenza.Value, dtpDataArrivo.Value, cmbCodiceAereo.Text, cmbPartenza.Text, Convert.ToInt16(updDurata.Value), Convert.ToByte(updGatePartenza.Value), chkInternazionale.Checked);
                        // Aggiorno la DataGridView Aerei se non mi trovo nella form Avvio 
                        if (!this.avvio)
                        {
                            this._RefreshGrid();

                        }
                        this.Close();
                    }
                    //Caso di chiave primaria duplicata
                    catch (SqlException ex) when (ex.Number == 2627)
                    {
                        MessageBox.Show("Chiave primaria duplicata, usarne una differente");
                    }

                }

            }
            //Else in caso di errori
            else
            {
                // Imposto gli error provider in modo da vedere dove non è corretto l'inserimento
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtCodice.Text == "")
                {
                    errorProvider1.SetError(txtCodice, "Inserire i dati correttamente");
                }
                if (cmbCodiceAereo.Text == "")
                {
                    errorProvider2.SetError(cmbCodiceAereo, "Inserire i dati correttamente");
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





        //Evento di SalvaENuovo
        private void btnSalvaENuovo_Click(object sender, EventArgs e)
        {
            // Controllo che non ci siano campi vuoti o uguali 0
            if ((txtCodice.Text != "") && (updDurata.Value > 0) && (updGatePartenza.Value > 0))
            {
                //If che chiede conferma per apportare le modifiche
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Con try e catch controllo se la chiave primaria è duplicata
                    try
                    {
                        // Richiamo la stored procedure InserisciVoli, per inserire i nuovi dati nel dataset
                        tblVoliTableAdapter.InserisciVoli(txtCodice.Text, dtpDataPartenza.Value, dtpDataArrivo.Value, cmbCodiceAereo.Text, cmbPartenza.Text, Convert.ToInt16(updDurata.Value), Convert.ToByte(updGatePartenza.Value), chkInternazionale.Checked);
                        if (!this.avvio)
                        {
                            this._RefreshGrid();

                        }
                        txtCodice.Text = "";
                        updDurata.Value = 0;
                        updGatePartenza.Value = 0;
                    }
                    //Caso di chiave perimaria duplicata
                    catch (SqlException ex) when (ex.Number == 2627)
                    {
                        MessageBox.Show("Chiave primaria duplicata, usarne una differente");
                    }
                }

            }
            //Else in caso siano presenti degli errori
            else
            {
                // Imposto gli error provider in modo da vedere dove non è corretto l'inserimento
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtCodice.Text == "")
                {
                    errorProvider1.SetError(txtCodice, "Inserire i dati correttamente");
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

        //Righe di codice per calcolare la durata del volo ed evitare durate negative
        private void dtpDataPartenza_ValueChanged(object sender, EventArgs e)
        {
            dtpDataPartenza.Value.ToString("dd/MM/yyyy HH:mm:ss");
            TimeSpan tp = Convert.ToDateTime(dtpDataArrivo.Value) - Convert.ToDateTime(dtpDataPartenza.Value);
            if (tp.TotalMinutes < 0)
            {
                dtpDataArrivo.Value = dtpDataPartenza.Value;
                updDurata.Value = 0;
            }
            else
            {
                updDurata.Value = (decimal)tp.TotalMinutes;
            }
        }

        //Righe di codice per calcolare la durata del volo ed evitare durate negative
        private void dtpDataArrivo_ValueChanged(object sender, EventArgs e)
        {
            dtpDataArrivo.Text = dtpDataArrivo.Value.ToString("dd/MM/yyyy HH:mm:ss");
            TimeSpan tp = Convert.ToDateTime(dtpDataArrivo.Value) - Convert.ToDateTime(dtpDataPartenza.Value);
            if (tp.TotalMinutes < 0)
            {
                dtpDataPartenza.Value = dtpDataArrivo.Value;
                updDurata.Value = 0;
            }
            else
            {
                updDurata.Value = (decimal)tp.TotalMinutes;
            }
        }

        private void frmInserisciVoli_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblAeroporti'. È possibile spostarla o rimuoverla se necessario.
            this.tblAeroportiTableAdapter.Fill(this.aeroportoDataSet.tblAeroporti);
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblAerei'. È possibile spostarla o rimuoverla se necessario.
            this.tblAereiTableAdapter.Fill(this.aeroportoDataSet.tblAerei);
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblVoli'. È possibile spostarla o rimuoverla se necessario.
            //this.tblVoliTableAdapter.Fill(this.aeroportoDataSet.tblVoli);
        }

        // pulizia error provider

        private void txtCodice_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtCodiceAereo_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider2.Clear();
        }

        private void updDurata_ValueChanged(object sender, EventArgs e)
        {
            errorProvider4.Clear();
        }

        private void updGatePartenza_ValueChanged(object sender, EventArgs e)
        {
            errorProvider5.Clear();
        }

    }

}
