﻿using System;
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
    public partial class frmModificaAerei : Form
    {

       string _CodiceAerei;
        readonly Action _RefreshGrid;

        // Costruttore senza parametri
        public frmModificaAerei()
        {  
        }

        // Costruttore con parametri (passo il metodo RefreshGrid per il refresh della DataGridView
        // e il codice dell'Aereo da modificare)
        public frmModificaAerei(Action RefreshGrid,string CodiceAerei):this()
        {
            this._RefreshGrid = RefreshGrid;
            this._CodiceAerei = CodiceAerei;
            InitializeComponent();
        }



        private void frmModificaAerei_Load(object sender, EventArgs e)
        {
            // Con l'utilizzo del metodo fill aggiungo/aggiorno righe all'interno del dataset
            this.marcheTableAdapter.Fill(this.aeroportoDataSet1.Marche);
            // Richiamo il fill che prende i parametri in base al CodiceAereo ricevuto in ingresso
            this.tblAereiTableAdapter.FillByCodiceAereo(this.aeroportoDataSet.tblAerei, this._CodiceAerei);

        }

        // Bottone che carica i dati sul dataset, chiudendo la form
        private void btnSalva_Click(object sender, EventArgs e)
        {
            // Controllo che non ci siano dei parametri vuoti o uguali a 0
            if ((txtCompagnia.Text != "") && (cmbModello.Text != "") && (updCapacita.Value > 0) && (updRaggio.Value > 0) && (updLitri.Value > 0) && (updMotori.Value > 0) && (updVelocita.Value > 0) && (txtPropulsione.Text != ""))
            {
                // Chiedo conferma per apportare le modifiche
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Controllo se l'utente ha selezionato un valore nel combobox
                    if(cmbModello.Text!="*Seleziona una Marca*")
                    {
                        // Richiamo la stored procedure InserisciAerei, per inserire i nuovi dati nel dataset
                        // siccome ho selezionato una Marca prendo il modello dal Combobox dei modelli
                        tblAereiTableAdapter.ModificaAereo(cmbModello.Text, Convert.ToInt16(updCapacita.Value), Convert.ToInt16(updLitri.Value), Convert.ToByte(updMotori.Value), txtPropulsione.Text, chkInternazionale.Checked, Convert.ToInt16(updRaggio.Value), Convert.ToInt16(updVelocita.Value), txtCompagnia.Text, _CodiceAerei);
                    }
                    else
                    {
                            // Richiamo la stored procedure InserisciAerei, per inserire i nuovi dati nel dataset
                            // siccome non ho selezionato una Marca prendo il modello dal txt contenente il modello corrente
                            tblAereiTableAdapter.ModificaAereo(txtModello.Text, Convert.ToInt16(updCapacita.Value), Convert.ToInt16(updLitri.Value), Convert.ToByte(updMotori.Value), txtPropulsione.Text, chkInternazionale.Checked, Convert.ToInt16(updRaggio.Value), Convert.ToInt16(updVelocita.Value), txtCompagnia.Text, _CodiceAerei);
                            this._RefreshGrid();
                                            
                    }
                    
                }
            }
            // Se sono presenti degli errori
            else
            {                
                // Imposto gli error provider in modo da vedere dove non è corretto l'inserimento
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    private void txtMarca_KeyUp(object sender, KeyEventArgs e)
    {
        errorProvider3.Clear();

    }

    private void cmbModello_SelectionChangeCommitted(object sender, EventArgs e)
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

     // Riempimento del combobox Modelli
    private void cmbMarca_SelectionChangeCommitted(object sender, EventArgs e)
    {
        // Dichiaro una variabile Marca contente la Marca selezionata
        string marca = cmbMarca.SelectedValue.ToString();
            // Richiamo il riempimento passando il parametro Marca
            // i valori verranno selezionati filtrando per la marca in ingresso
            cmbModello.Text = "";
        this.modelliTableAdapter.FillByMarca(this.aeroportoDataSet.Modelli, marca);
    }


    }
}
