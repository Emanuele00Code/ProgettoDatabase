using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDatabase.Classi;

namespace TestDatabase
{
    public partial class frmPersone : Form
    {
        public frmPersone()
        {
            InitializeComponent();
        }

        private void frmPersone_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblPersone'. È possibile spostarla o rimuoverla se necessario.
            this.tblPersoneTableAdapter.Fill(this.aeroportoDataSet.tblPersone);

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblPersoneTableAdapter.Update(aeroportoDataSet.tblPersone);
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {

            string CodicePersona;

            if (dgvPersone.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvPersone.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPersone.Rows[selectedrowindex];
                CodicePersona = Convert.ToString(selectedRow.Cells[0].Value);
                frmModificaPersona FormDaAprire = new frmModificaPersona(CodicePersona);
                FormDaAprire.Show();
            }

        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            frmInserisciPersona FormDaAprire = new frmInserisciPersona();
            FormDaAprire.Show();
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            string CodicePersona;
            string Nome;
            string Cognome;
            string Nazione;
            string DataNascita;
            string Sesso;
            string TipoDocumento;
            string NumeroDocumento;

            if (dgvPersone.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvPersone.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPersone.Rows[selectedrowindex];
                CodicePersona = Convert.ToString(selectedRow.Cells[0].Value);
                Nome = Convert.ToString(selectedRow.Cells[1].Value);
                Cognome = Convert.ToString(selectedRow.Cells[2].Value);
                Nazione = Convert.ToString(selectedRow.Cells[3].Value);
                DataNascita = Convert.ToString(selectedRow.Cells[4].Value);
                Sesso = Convert.ToString(selectedRow.Cells[5].Value);
                TipoDocumento = Convert.ToString(selectedRow.Cells[6].Value);
                NumeroDocumento = Convert.ToString(selectedRow.Cells[7].Value);
                Persona MiaPersona = new Persona(CodicePersona, Nome, Cognome, Nazione, DataNascita, Sesso, TipoDocumento, NumeroDocumento);
                frmVisualizzaPersona FormDaAprire = new frmVisualizzaPersona(MiaPersona);
                FormDaAprire.Show();
            }

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            string CodicePersona;

            if (dgvPersone.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvPersone.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPersone.Rows[selectedrowindex];
                CodicePersona = Convert.ToString(selectedRow.Cells[0].Value);


                if (MessageBox.Show("Vuoi eliminare la persona selezionata?", "Emilinazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tblPersoneTableAdapter.EliminaPersona(CodicePersona);
                }
            }
        }

        private void btnFittizia_Click(object sender, EventArgs e)
        {
            string CodicePersona;

            if (dgvPersone.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvPersone.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPersone.Rows[selectedrowindex];
                CodicePersona = Convert.ToString(selectedRow.Cells[0].Value);


                if (MessageBox.Show("Vuoi eliminare la persona selezionata?", "Emilinazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tblPersoneTableAdapter.DisattivaPersona(CodicePersona);
                }
            }
        }
    }
}
