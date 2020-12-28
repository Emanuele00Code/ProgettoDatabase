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
    public partial class frmInserisciAerei : Form
    {

        readonly Action _RefreshGrid;

        public frmInserisciAerei()
        {          
            InitializeComponent();
        }
        public frmInserisciAerei(Action RefreshGrid)
        {
            this._RefreshGrid = RefreshGrid;
            InitializeComponent();
        }


        private void btnSalva_Click(object sender, EventArgs e)
        {
            if ((txtCodice.Text != "") && (txtCompagnia.Text != "") && (cmbModello.Text != "") && (updCapacita.Value > 0) && (updRaggio.Value > 0) && (updLitri.Value > 0) && (updMotori.Value > 0) && (updVelocita.Value > 0) && (txtPropulsione.Text != ""))
            {
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        tblAereiTableAdapter.InserisciAerei(txtCodice.Text, cmbModello.Text, Convert.ToInt16(updCapacita.Value), Convert.ToInt16(updLitri.Value), Convert.ToByte(updMotori.Value), txtPropulsione.Text, chkInternazionale.Checked, Convert.ToInt16(updRaggio.Value), Convert.ToInt16(updVelocita.Value), txtCompagnia.Text);
                        this._RefreshGrid();
                        this.Close();
                    }
                    catch (SqlException ex) when (ex.Number == 2627)
                    {
                        MessageBox.Show("Chiave primaria duplicata, usarne una differente");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtCodice.Text == "")
                {
                    errorProvider1.SetError(txtCodice, "Inserire i dati correttamente");
                }
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








        private void btnSalvaENuovo_Click(object sender, EventArgs e)
        {
            if ((txtCodice.Text != "") && (txtCompagnia.Text != "")  && (cmbModello.Text != "") && (updCapacita.Value > 0) && (updRaggio.Value > 0) && (updLitri.Value > 0) && (updMotori.Value > 0) && (updVelocita.Value > 0) && (txtPropulsione.Text != ""))
            {
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        tblAereiTableAdapter.InserisciAerei(txtCodice.Text, cmbModello.Text, Convert.ToInt16(updCapacita.Value), Convert.ToInt16(updLitri.Value), Convert.ToByte(updMotori.Value), txtPropulsione.Text, chkInternazionale.Checked, Convert.ToInt16(updRaggio.Value), Convert.ToInt16(updVelocita.Value), txtCompagnia.Text);
                        txtCodice.Text = "";
                        txtCompagnia.Text = "";
                        cmbModello.Text = "";
                        updCapacita.Value = 0;
                        updLitri.Value = 0;
                        updMotori.Value = 0;
                        updRaggio.Value = 0;
                        updVelocita.Value = 0;
                        txtPropulsione.Text = "";
                        chkInternazionale.Checked = false;
                        this._RefreshGrid();
                    }
                    catch (SqlException ex) when (ex.Number == 2627)
                    {
                        MessageBox.Show("Chiave primaria duplicata, usarne una differente");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtCodice.Text == "")
                {
                    errorProvider1.SetError(txtCodice, "Inserire i dati correttamente");
                }
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

        private void cmbModello_SelectedIndexChanged(object sender, EventArgs e)
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

        private void frmInserisciAerei_Load(object sender, EventArgs e)
        {
            this.marcheTableAdapter.Fill(this.aeroportoDataSet.Marche);
             this.modelliTableAdapter.Fill(this.aeroportoDataSet.Modelli);

        }

        private void cmbMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string marca = cmbMarca.SelectedValue.ToString();
            this.modelliTableAdapter.FillByMarca(this.aeroportoDataSet.Modelli, marca);
        }

    }
}
