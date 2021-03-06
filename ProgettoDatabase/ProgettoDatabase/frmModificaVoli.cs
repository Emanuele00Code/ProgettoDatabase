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
    public partial class frmModificaVoli : Form
    {

        string _Codice;
        readonly Action _RefreshGrid;

        //Metodo costruttore senza parametri
        public frmModificaVoli()
        {
        }

        //Metodo costruttore con parametri
        public frmModificaVoli(Action RefreshGrid, string Codice) : this()
        {
            this._RefreshGrid = RefreshGrid;
            this._Codice = Codice;
            InitializeComponent();
        }


        //Con le righe di codice successive evito che esca una data negativa
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

        //Con le righe di codice successive evito che esca una data negativa
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

        //Evento di Salva (carico i dati sul dataset e chiudo la form)
        private void btnSalva_Click(object sender, EventArgs e)
        {
            //If che controlla che non ci siano parametri vuoti o a 0
            if ((updDurata.Value > 0) && (updGatePartenza.Value > 0))
            {
                //If che chiede la conferma per apportare le modifiche
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Con try e catch controllo se la chiave primaria è duplicata
                    try
                    {
                        tblVoliTableAdapter.ModificaVoli(Convert.ToDateTime(dtpDataPartenza.Value), Convert.ToDateTime(dtpDataArrivo.Value), cmbCodiceAereo.Text,
                           cmbPartenza.Text, Convert.ToInt16(updDurata.Value), Convert.ToByte(updGatePartenza.Value), chkInternazionale.Checked, _Codice);
                        this._RefreshGrid();
                    }
                    //Caso di chiave primaria duplicata
                    catch (SqlException ex) when (ex.Number == 2627)
                    {
                        MessageBox.Show("Chiave primaria duplicata, usarne una differente");
                    }


                }

            }
            else
            {
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);


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



        private void frmModificaVoli_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblAeroporti'. È possibile spostarla o rimuoverla se necessario.
            this.tblAeroportiTableAdapter.Fill(this.aeroportoDataSet.tblAeroporti);
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblAerei'. È possibile spostarla o rimuoverla se necessario.
            this.tblAereiTableAdapter.Fill(this.aeroportoDataSet.tblAerei);

            this.tblVoliTableAdapter.FillByCodice(this.aeroportoDataSet.tblVoli, this._Codice);


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