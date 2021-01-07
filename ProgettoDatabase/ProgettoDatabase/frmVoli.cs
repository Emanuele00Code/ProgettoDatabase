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

        //evento Load
        private void frmVoli_Load(object sender, EventArgs e)
        {
            //Con l'utilizzo del metodo Fill aggiungo/aggiorno righe all'interno del DataSet
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblVoli'. È possibile spostarla o rimuoverla se necessario.
            this.tblVoliTableAdapter.Fill(this.aeroportoDataSet.tblVoli);

            this.tblVoliTableAdapter.Fill(this.aeroportoDataSet.tblVoli);

        }









        //Utilizziamo RefreshGrid per ricaricare la DataGridView
        private void RefreshGrid()
        {
            //Pongo il DataSource dalla DataGridView a Null
            dvgVoli.DataSource = null;
            //Richiamo il riempimento del table adapter di Aerei
            this.tblVoliTableAdapter.Fill(this.aeroportoDataSet.tblVoli);
            //Inserisco nella DataGridViewAerei i dati del TableAdapter
            dvgVoli.DataSource = tblVoliBindingSource;
        }


        //Evento sul click di Nuovo
        private void tsbNuovo_Click(object sender, EventArgs e)
        {
            //Se avviene il click su Nuovo si apre la form InserisciVoli
            frmInserisciVoli formDaAprire = new frmInserisciVoli(this.RefreshGrid);
            formDaAprire.Show();
        }

        //Evento sul click di Modifica
        private void tsbModifica_Click(object sender, EventArgs e)
        {
            //Dichiariamo Codice, che è di tipo string
            string Codice;

            //Faccio un controllo per vedere se la cella è stata selezionata
            if (dvgVoli.SelectedCells.Count > 0)
            {
                //Dichiaro una variabile che contiene il numero della riga selezionata
                int selectedrowindex = dvgVoli.SelectedCells[0].RowIndex;
                //Dichiaro un oggetto DataGridViewRow contenente le celle della riga all'indice "selectedrowindex"
                DataGridViewRow selectedRow = dvgVoli.Rows[selectedrowindex];
                //CodiceAerei conterrà il contentuo della cella ottenuta in precedenza
                Codice = Convert.ToString(selectedRow.Cells[0].Value);
                //Istanzio la nuova form passando Refresh e Codice
                frmModificaVoli formDaAprire = new frmModificaVoli(this.RefreshGrid, Codice);
                //Apro "FormDaAprire
                formDaAprire.Show();
            }
        }

        //Evento click di Nascondi
        private void tsbNascondi_Click(object sender, EventArgs e)
        {
            string Sigla;

            if (dvgVoli.SelectedCells.Count > 0)
            {
                //Dichiaro una variabile che contiene il numero della riga selezionata
                int selectedrowindex = dvgVoli.SelectedCells[0].RowIndex;
                //Dichiaro un oggetto DataGridViewRow contenente le celledella riga all'indice "selectedrowindex"
                DataGridViewRow selectedRow = dvgVoli.Rows[selectedrowindex];
                //Sigla sarà uguale al contenuto della prima cella ottenuta in precedenza
                Sigla = Convert.ToString(selectedRow.Cells[0].Value);

                //Se avviene il click su SI l'elemento verrà nascosto
                if (MessageBox.Show("Vuoi eliminare la persona selezionata?", "Emilinazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //Richiamo la stored procedure DisattivaVoli, passando la sigla del volo che voglio disattivare
                    tblVoliTableAdapter.DisattivaVoli(Sigla);
                    //Richiamo il metodo RefreshGrid
                    this.RefreshGrid();
                }
            }
        }

        //Evento click di Elimina
        private void tsbElimina_Click(object sender, EventArgs e)
        {
            string Sigla;
            //Controllo se la cella è stata selezionata
            if (dvgVoli.SelectedCells.Count > 0)
            {
                //Dichiaro una variabile che contiene il numero della riga selezionata
                int selectedrowindex = dvgVoli.SelectedCells[0].RowIndex;
                //Dichiaro un oggetto DatagRidViewRow contenete le celle della riga all'indice "selectedrowindex"
                DataGridViewRow selectedRow = dvgVoli.Rows[selectedrowindex];
                //Sigla sarà uguale al contenuto della prima cella ottenuto in precedenza
                Sigla = Convert.ToString(selectedRow.Cells[0].Value);

                //Se avviene il click su SI l'elemento verrà nascosto
                if (MessageBox.Show("Vuoi eliminare la persona selezionata?", "Emilinazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //MessageBox.Show("Placeholder, funzione già presente ma non attiva");
                    //Richiamo la stored Procedure Elimina Aereo passando in ingresso la sigla
                    //dell'aereo che voglio eliminare
                    tblVoliTableAdapter.EliminaVoli(Sigla);
                    this.RefreshGrid();
                }
            }
        }

        //Evento click di Visualizza
        private void tsbVisualizza_Click(object sender, EventArgs e)
        {
            //Dichiaro i dati
            string Codice;
            string DataOraPartenza;
            string DataOraArrivo;
            bool Internazionale;
            string Partenza;
            int GatePartenza;
            int Durata;
            string Destinazione;
            string CodiceAereo;

            // Questo ciclo assegna ad ogni variabile il corrispettivo valore contenuto nella DataGridView Voli
            // nella riga selezionata della DataGridView Voli
            // Controllo se la cella è stata selezionata
            if (dvgVoli.SelectedCells.Count > 0)
            {
                //Dichiaro un indice di selezione uguale all'indice del primo campo della riga selezionata
                int selectedrowindex = dvgVoli.SelectedCells[0].RowIndex;

                //Dichiaro un oggetto DataGridViewRow contente le celle della riga all'indice "selectedrowindex"
                DataGridViewRow selectedRow = dvgVoli.Rows[selectedrowindex];

                //Codice sarà uguale al contenuto della prima cella ottenuto in precedenza
                Codice = Convert.ToString(selectedRow.Cells[0].Value);

                //DataOraPartenza sarà uguale al contenuto della seconda cella che si trova in selectedRow
                DataOraPartenza = Convert.ToString(selectedRow.Cells[1].Value);

                //DataOraArrivo sarà uguale al contenuto della terza cella che si trova in selectedRow
                DataOraArrivo = Convert.ToString(selectedRow.Cells[2].Value);

                //Internazionale sarà uguale al contenuto della quarta cella che si trova in selectedRow
                Internazionale = Convert.ToBoolean(selectedRow.Cells[3].Value);

                //Partenza sarà uguale al contenuto della quinta cella che si trova in selectedRow
                Partenza = Convert.ToString(selectedRow.Cells[4].Value);

                //GatePartenza sarà uguale al contenuto della sesta cella che si trova in selectedRow
                GatePartenza = Convert.ToInt32(selectedRow.Cells[5].Value);

                //Durata sarà uguale al contenuto della settima cella che si trova in selectedRow
                Durata = Convert.ToInt32(selectedRow.Cells[6].Value);

                //CodiceAereo sarà uguale al contenuto dell'ottava cella che si trova in selectedRow
                CodiceAereo = Convert.ToString(selectedRow.Cells[7].Value);

                //Voli un istanza di Voli passando tutti i parametri scritti in precedenza in ingresso
                Voli MioVolo = new Voli(Codice, DataOraPartenza, DataOraArrivo, Internazionale, CodiceAereo, Durata, GatePartenza);

                //Istanzio la nuova form passando in ingresso il nuovo Volo 'MieiVoli'
                frmVisualizzaVoli formDaAprire = new frmVisualizzaVoli(MioVolo);
                formDaAprire.Show();

            }
        }
    }
}
