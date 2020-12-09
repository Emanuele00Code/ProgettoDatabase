using System;
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
    public partial class frmVoli : Form
    {
        public frmVoli()
        {
            InitializeComponent();
        }

        private void frmPersone_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblVoli'. È possibile spostarla o rimuoverla se necessario.
            this.tblVoliTableAdapter.Fill(this.aeroportoDataSet.tblVoli);
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblVoli'. È possibile spostarla o rimuoverla se necessario.
            this.tblVoliTableAdapter.Fill(this.aeroportoDataSet.tblVoli);
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblAeroporti'. È possibile spostarla o rimuoverla se necessario.

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //tblVoliTableAdapter.Update(aeroportoDataSet.tblAeroporti);
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            string Codice;

            if (dvgVoli.SelectedCells.Count > 0)
            {
                int selectedrowindex = dvgVoli.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dvgVoli.Rows[selectedrowindex];
                Codice = Convert.ToString(selectedRow.Cells[0].Value);
                //frmModificaVoli formDaAprire = new frmModificaVoli(Codice);
                //formDaAprire.Show();
            }

        }

  

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            frmInserisciVoli formDaAprire = new frmInserisciVoli();
            formDaAprire.Show();
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            string Codice;
            string CodiceAereo;
            int Durata;
            int GatePartenza;
            string SiglaAereoporto;

            if (dvgVoli.SelectedCells.Count > 0)
            {
                int selectedrowindex = dvgVoli.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dvgVoli.Rows[selectedrowindex];
                Codice = Convert.ToString(selectedRow.Cells[0].Value);
                CodiceAereo = Convert.ToString(selectedRow.Cells[1].Value);
                Durata = Convert.ToInt32(selectedRow.Cells[2].Value);
                GatePartenza = Convert.ToInt32(selectedRow.Cells[3].Value);
                SiglaAereoporto = Convert.ToString(selectedRow.Cells[4].Value);
                //Voli MioVolo = new Voli(Codice, CodiceAereo, Durata, GatePartenza, SiglaAereoporto);
                //frmVisualizzaVoli FormDaAprire = new frmVisualizzaVoli(MioVolo);
                //FormDaAprire.Show();
            }

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            string Sigla;

            if (dvgVoli.SelectedCells.Count > 0)
            {
                int selectedrowindex = dvgVoli.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dvgVoli.Rows[selectedrowindex];
                Sigla = Convert.ToString(selectedRow.Cells[0].Value);


                if (MessageBox.Show("Vuoi eliminare la persona selezionata?", "Emilinazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tblVoliTableAdapter.EliminaVoli(Sigla);
                }
            }
        }

        private void btnFittizia_Click(object sender, EventArgs e)
        {
            string Sigla;

            if (dvgVoli.SelectedCells.Count > 0)
            {
                int selectedrowindex = dvgVoli.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dvgVoli.Rows[selectedrowindex];
                Sigla = Convert.ToString(selectedRow.Cells[0].Value);


                if (MessageBox.Show("Vuoi eliminare la persona selezionata?", "Emilinazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tblVoliTableAdapter.DisattivaVoli(Sigla);
                }
            }
        }

    }
}
