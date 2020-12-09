﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgettoDatabase.Classi;

namespace ProgettoDatabase
{
    public partial class frmAeroporti : Form
    {
        public frmAeroporti()
        {
            InitializeComponent();
        }

        private void frmPersone_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblAeroporti'. È possibile spostarla o rimuoverla se necessario.
            this.tblAeroportiTableAdapter.Fill(this.aeroportoDataSet.tblAeroporti);

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblAeroportiTableAdapter.Update(aeroportoDataSet.tblAeroporti);
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            string Sigla;

            if (dvgAeroporti.SelectedCells.Count > 0)
            {
                int selectedrowindex = dvgAeroporti.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dvgAeroporti.Rows[selectedrowindex];
                Sigla = Convert.ToString(selectedRow.Cells[0].Value);
                frmModificaAeroporti formDaAprire = new frmModificaAeroporti(Sigla);
                formDaAprire.Show();
            }

        }

  

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            frmInserisciAeroporti formDaAprire = new frmInserisciAeroporti();
            formDaAprire.Show();
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            string Sigla; ;
            string Nome;
            int Piste;
            int Terminal;
            int  Gates;
            string Nazione;
            string Citta;
            bool Militare;
            bool Internazionale;

            if (dvgAeroporti.SelectedCells.Count > 0)
            {
                int selectedrowindex = dvgAeroporti.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dvgAeroporti.Rows[selectedrowindex];
                Sigla = Convert.ToString(selectedRow.Cells[0].Value);
                Nome = Convert.ToString(selectedRow.Cells[1].Value);
                Piste = Convert.ToInt32(selectedRow.Cells[2].Value);
                Terminal = Convert.ToInt32(selectedRow.Cells[3].Value);
                Gates = Convert.ToInt32(selectedRow.Cells[4].Value);
                Nazione = Convert.ToString(selectedRow.Cells[5].Value);
                Citta = Convert.ToString(selectedRow.Cells[6].Value);
                Militare = Convert.ToBoolean(selectedRow.Cells[7].Value);
                Internazionale = Convert.ToBoolean(selectedRow.Cells[8].Value);
                Aeroporti MioAeroporto = new Aeroporti(Sigla, Nome, Piste, Terminal, Gates, Nazione, Citta, Militare,Internazionale);
                frmVisualizzaAeroporti FormDaAprire = new frmVisualizzaAeroporti(MioAeroporto);
                FormDaAprire.Show();
            }

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            string Sigla;

            if (dvgAeroporti.SelectedCells.Count > 0)
            {
                int selectedrowindex = dvgAeroporti.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dvgAeroporti.Rows[selectedrowindex];
                Sigla = Convert.ToString(selectedRow.Cells[0].Value);


                if (MessageBox.Show("Vuoi eliminare la persona selezionata?", "Emilinazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tblAeroportiTableAdapter.EliminaAeroporto(Sigla);
                }
            }
        }

        private void btnFittizia_Click(object sender, EventArgs e)
        {
            string Sigla;

            if (dvgAeroporti.SelectedCells.Count > 0)
            {
                int selectedrowindex = dvgAeroporti.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dvgAeroporti.Rows[selectedrowindex];
                Sigla = Convert.ToString(selectedRow.Cells[0].Value);


                if (MessageBox.Show("Vuoi eliminare la persona selezionata?", "Emilinazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tblAeroportiTableAdapter.DisattivaAeroporto(Sigla);
                }
            }
        }

    }
}