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
    public partial class frmAerei : Form
    {
        public frmAerei()
        {
            InitializeComponent();
        }

        private void frmAerei_Load(object sender, EventArgs e)
        {
            // Con l'utilizzo del metodo fill aggiungo/aggiorno righe all'interno del dataset
            this.tblAereiTableAdapter.Fill(this.aeroportoDataSet.tblAerei);

        }


        // Metodo refresh utlizzato per ricaricare la DataGridView
        private void RefreshGrid()
        {
            // Pongo il DataSource della DataGridView Aerei a Null
            dgvAerei.DataSource = null;
            // Richiamo il riempimento del table adapter di Aerei
            this.tblAereiTableAdapter.Fill(this.aeroportoDataSet.tblAerei);
            // Inserisco nella DataGridViewAerei i dati del TableAdapter
            dgvAerei.DataSource = tblAereiBindingSource;
        }
        // Aggiungi un nuovo Aereo
        private void tsbNuovo_Click(object sender, EventArgs e)
        {
            // Instanza della nuova form con passaggio del metodo RefreshGrid
            frmInserisciAerei FormDaAprire = new frmInserisciAerei(this.RefreshGrid);
            // Mostro "FormDaAprire" a schermo
            FormDaAprire.Show();
        }

        // Modifico un Aereo già esistente
        private void tsbModifica_Click(object sender, EventArgs e)
        {
            string CodiceAerei;

            // Questo ciclo assegna alla variabile CodiceAerei il valore contenuto della colonna Codice Aereo
            // nella riga selezionata della DataGridView Aerei
            // Controllo se la cella è stata selezionata
            if (dgvAerei.SelectedCells.Count > 0)
            {
                // Dichiaro un indice di selezione uguale all'indice del primo campo della riga selezionata
                int selectedrowindex = dgvAerei.SelectedCells[0].RowIndex;
                // Dichiaro un oggetto DataGridViewRow contente le celle della riga all'indice 'selectedrowindex'
                DataGridViewRow selectedRow = dgvAerei.Rows[selectedrowindex];
                // CodiceAerei sarà uguale al contenuto della prima cella ottenuto in precedenza
                CodiceAerei = Convert.ToString(selectedRow.Cells[0].Value);
                // Istanzio la nuova form passando il metodo di refresh e CodiceAerei
                frmModificaAerei FormDaAprire = new frmModificaAerei(this.RefreshGrid, CodiceAerei);
                // Mostro "FormDaAprire" a schermo
                FormDaAprire.Show();

            }
        }

        // Nascondo un Aereo
        private void tsbNascondi_Click(object sender, EventArgs e)
        {
            string CodiceAerei;

            // Questo ciclo assegna alla variabile CodiceAerei il valore contenuto della colonna Codice Aereo
            // nella riga selezionata della DataGridView Aerei
            // Controllo se la cella è stata selezionata
            if (dgvAerei.SelectedCells.Count > 0)
            {
                // dichiaro un indice di selezione uguale all'indice del primo campo della riga selezionata
                int selectedrowindex = dgvAerei.SelectedCells[0].RowIndex;
                // Dichiaro un oggetto DataGridViewRow contente le celle della riga all'indice 'selectedrowindex'
                DataGridViewRow selectedRow = dgvAerei.Rows[selectedrowindex];
                // CodiceAerei sarà uguale al contenuto della prima cella ottenuto in precedenza
                CodiceAerei = Convert.ToString(selectedRow.Cells[0].Value);


                if (MessageBox.Show("Vuoi eliminare l'Aereo selezionato?", "Eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Richiamo la stored Procedure Disattiva Aereo passando in ingresso il codice
                    // dell'aereo che voglio disattivare
                    tblAereiTableAdapter.DisattivaAereo(CodiceAerei);
                    // Richiamo il refresh della DataGridView
                    this.RefreshGrid();
                }
            }
        }

        // Elimino un Aereo
        private void tsbElimina_Click(object sender, EventArgs e)
        {
            string CodiceAerei;

            // Questo ciclo assegna alla variabile CodiceAerei il valore contenuto della colonna Codice Aereo
            // nella riga selezionata della DataGridView Aerei
            // Controllo se la cella è stata selezionata
            if (dgvAerei.SelectedCells.Count > 0)
            {
                // dichiaro un indice di selezione uguale all'indice del primo campo della riga selezionata
                int selectedrowindex = dgvAerei.SelectedCells[0].RowIndex;
                // Dichiaro un oggetto DataGridViewRow contente le celle della riga all'indice 'selectedrowindex'
                DataGridViewRow selectedRow = dgvAerei.Rows[selectedrowindex];
                // CodiceAerei sarà uguale al contenuto della prima cella ottenuto in precedenza
                CodiceAerei = Convert.ToString(selectedRow.Cells[0].Value);


                if (MessageBox.Show("Vuoi eliminare l'Aereo selezionato?", "Eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Richiamo la stored Procedure Elimina Aereo passando in ingresso il codice
                    // dell'aereo che voglio eliminare
                    tblAereiTableAdapter.EliminaAereo(CodiceAerei);
                    // Richiamo il refresh della DataGridView
                    this.RefreshGrid();
                }
            }
        }

        // Visualizzo un Aereo
        private void tsbVisualizza_Click(object sender, EventArgs e)
        {
            
            string Modello;
            int CapacitaMassima;
            int LitriCarburante;
            int NumeroMotori;
            string TipoPropulsione;
            bool Internazionale;
            int Raggio;
            int VelocitaMax;
            string CompagniaAerea;
            string CodiceAereo;

            // Questo ciclo assegna ad ogni variabile il corrispettivo valore contenuto nella DataGridView Aerei
            // nella riga selezionata della DataGridView Aerei
            // Controllo se la cella è stata selezionata
            if (dgvAerei.SelectedCells.Count > 0)
            {
                // dichiaro un indice di selezione uguale all'indice del primo campo della riga selezionata
                int selectedrowindex = dgvAerei.SelectedCells[0].RowIndex;
                // Dichiaro un oggetto DataGridViewRow contente le celle della riga all'indice 'selectedrowindex'
                DataGridViewRow selectedRow = dgvAerei.Rows[selectedrowindex];
                // CodiceAerei sarà uguale al contenuto della prima cella ottenuto in precedenza
                CodiceAereo = Convert.ToString(selectedRow.Cells[0].Value);
                // Modello sarà uguale al contenuto della seconda cella che si trova in selectedRow
                Modello = Convert.ToString(selectedRow.Cells[1].Value);
                // CapacitaMassima sarà uguale al contenuto della terza cella che si trova in selectedRow
                CapacitaMassima = Convert.ToInt16(selectedRow.Cells[2].Value);
                // LitriCarburante sarà uguale al contenuto della quarta cella che si trova in selectedRow
                LitriCarburante = Convert.ToInt16(selectedRow.Cells[3].Value);
                // NumeroMotori sarà uguale al contenuto della quinta cella che si trova in selectedRow
                NumeroMotori = Convert.ToInt16(selectedRow.Cells[4].Value);
                // TipoPropulsione sarà uguale al contenuto della sesta cella che si trova in selectedRow
                TipoPropulsione = Convert.ToString(selectedRow.Cells[5].Value);
                // Internazionale sarà uguale al contenuto della settima cella che si trova in selectedRow
                Internazionale = Convert.ToBoolean(selectedRow.Cells[6].Value);
                // Raggio sarà uguale al contenuto dell'ottava cella che si trova in selectedRow
                Raggio = Convert.ToInt16(selectedRow.Cells[7].Value);
                // VelocitaMax sarà uguale al contenuto della Nona cella che si trova in selectedRow
                VelocitaMax = Convert.ToInt16(selectedRow.Cells[8].Value);
                // CompagniaAerea sarà uguale al contenuto della decima cella che si trova in selectedRow
                CompagniaAerea = Convert.ToString(selectedRow.Cells[9].Value);

                // Dichiaro un istanza di Aerei passando tutti i parametri scritti in precedenza in ingresso
                Aerei MiaAerei = new Aerei(Modello, CapacitaMassima, LitriCarburante, NumeroMotori, TipoPropulsione, Internazionale, Raggio, VelocitaMax, CompagniaAerea, CodiceAereo);
                // Istanzio la nuova form passando in ingresso il nuovo Aereo 'MiaAerei'
                frmVisualizzaAerei FormDaAprire = new frmVisualizzaAerei(MiaAerei);
                // Mostro "FormDaAprire" a schermo
                FormDaAprire.Show();
            }
        }
    }
}
