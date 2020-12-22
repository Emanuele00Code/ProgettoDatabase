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
            
            this.tblAereiTableAdapter.Fill(this.aeroportoDataSet.tblAerei);

        }


        
        private void RefreshGrid()
        {
            dgvAerei.DataSource = null;
            this.tblAereiTableAdapter.Fill(this.aeroportoDataSet.tblAerei);
            dgvAerei.DataSource = tblAereiBindingSource;
        }

        private void tsbNuovo_Click(object sender, EventArgs e)
        {
            frmInserisciAerei FormDaAprire = new frmInserisciAerei(this.RefreshGrid);
            FormDaAprire.Show();
        }

        private void tsbModifica_Click(object sender, EventArgs e)
        {
            string CodiceAerei;

            if (dgvAerei.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAerei.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAerei.Rows[selectedrowindex];
                CodiceAerei = Convert.ToString(selectedRow.Cells[0].Value);
                frmModificaAerei FormDaAprire = new frmModificaAerei(this.RefreshGrid, CodiceAerei);
                FormDaAprire.Show();

            }
        }

        private void tsbNascondi_Click(object sender, EventArgs e)
        {
            string CodiceAerei;

            if (dgvAerei.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAerei.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAerei.Rows[selectedrowindex];
                CodiceAerei = Convert.ToString(selectedRow.Cells[0].Value);


                if (MessageBox.Show("Vuoi eliminare l'Aereo selezionato?", "Eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    tblAereiTableAdapter.DisattivaAereo(CodiceAerei);
                    this.RefreshGrid();
                }
            }
        }

        private void tsbElimina_Click(object sender, EventArgs e)
        {
            string CodiceAerei;

            if (dgvAerei.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAerei.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAerei.Rows[selectedrowindex];
                CodiceAerei = Convert.ToString(selectedRow.Cells[0].Value);


                if (MessageBox.Show("Vuoi eliminare l'Aereo selezionato?", "Eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    
                    tblAereiTableAdapter.EliminaAereo(CodiceAerei);
                    this.RefreshGrid();
                }
            }
        }

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


            if (dgvAerei.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAerei.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvAerei.Rows[selectedrowindex];
                CodiceAereo = Convert.ToString(selectedRow.Cells[0].Value);
                Modello = Convert.ToString(selectedRow.Cells[1].Value);
                CapacitaMassima = Convert.ToInt16(selectedRow.Cells[2].Value);
                LitriCarburante = Convert.ToInt16(selectedRow.Cells[3].Value);
                NumeroMotori = Convert.ToInt16(selectedRow.Cells[4].Value);
                TipoPropulsione = Convert.ToString(selectedRow.Cells[5].Value);
                Internazionale = Convert.ToBoolean(selectedRow.Cells[6].Value);
                Raggio = Convert.ToInt16(selectedRow.Cells[7].Value);
                VelocitaMax = Convert.ToInt16(selectedRow.Cells[8].Value);
                CompagniaAerea = Convert.ToString(selectedRow.Cells[9].Value);

                Aerei MiaAerei = new Aerei(Modello, CapacitaMassima, LitriCarburante, NumeroMotori, TipoPropulsione, Internazionale, Raggio, VelocitaMax, CompagniaAerea, CodiceAereo);
                frmVisualizzaAerei FormDaAprire = new frmVisualizzaAerei(MiaAerei);
                FormDaAprire.Show();
            }
        }
    }
}
