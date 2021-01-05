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

        private void frmVoli_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblVoli'. È possibile spostarla o rimuoverla se necessario.
            this.tblVoliTableAdapter.Fill(this.aeroportoDataSet.tblVoli);

            this.tblVoliTableAdapter.Fill(this.aeroportoDataSet.tblVoli);

        }


       



        
 

            
        private void RefreshGrid()
        {
            dvgVoli.DataSource = null;
            this.tblVoliTableAdapter.Fill(this.aeroportoDataSet.tblVoli);
            dvgVoli.DataSource = tblVoliBindingSource;
        }

        private void tsbNuovo_Click(object sender, EventArgs e)
        {
            frmInserisciVoli formDaAprire = new frmInserisciVoli(this.RefreshGrid);
            formDaAprire.Show();
        }

        private void tsbModifica_Click(object sender, EventArgs e)
        {
            string Codice;

            if (dvgVoli.SelectedCells.Count > 0)
            {
                int selectedrowindex = dvgVoli.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dvgVoli.Rows[selectedrowindex];
                Codice = Convert.ToString(selectedRow.Cells[0].Value);
                frmModificaVoli formDaAprire = new frmModificaVoli(this.RefreshGrid, Codice);
                formDaAprire.Show();
            }
        }

        private void tsbNascondi_Click(object sender, EventArgs e)
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
                    this.RefreshGrid();
                }
            }
        }

        private void tsbElimina_Click(object sender, EventArgs e)
        {
            string Sigla;

            if (dvgVoli.SelectedCells.Count > 0)
            {
                int selectedrowindex = dvgVoli.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dvgVoli.Rows[selectedrowindex];
                Sigla = Convert.ToString(selectedRow.Cells[0].Value);


                if (MessageBox.Show("Vuoi eliminare la persona selezionata?", "Emilinazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //MessageBox.Show("Placeholder, funzione già presente ma non attiva");

                    tblVoliTableAdapter.EliminaVoli(Sigla);
                    this.RefreshGrid();
                }
            }
        }

        private void tsbVisualizza_Click(object sender, EventArgs e)
        {
            string Codice; ;
            string DataOraPartenza;
            string DataOraArrivo;
            bool Internazionale;
            string Partenza;
            int GatePartenza;
            int Durata;
            string Destinazione;
            string CodiceAereo;

            if (dvgVoli.SelectedCells.Count > 0)
            {
                int selectedrowindex = dvgVoli.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dvgVoli.Rows[selectedrowindex];
                Codice = Convert.ToString(selectedRow.Cells[0].Value);
                DataOraPartenza = Convert.ToString(selectedRow.Cells[1].Value);
                DataOraArrivo = Convert.ToString(selectedRow.Cells[2].Value);
                Internazionale = Convert.ToBoolean(selectedRow.Cells[3].Value);
                Partenza = Convert.ToString(selectedRow.Cells[4].Value);
                GatePartenza = Convert.ToInt32(selectedRow.Cells[5].Value);
                Durata = Convert.ToInt32(selectedRow.Cells[6].Value);
                CodiceAereo = Convert.ToString(selectedRow.Cells[7].Value);
                Voli MioVolo = new Voli(Codice, DataOraPartenza, DataOraArrivo, Internazionale, CodiceAereo, Durata, GatePartenza);
                frmVisualizzaVoli formDaAprire = new frmVisualizzaVoli(MioVolo);
                formDaAprire.Show();

            }
        }
    }
    } 
