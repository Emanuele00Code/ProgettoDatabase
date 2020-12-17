using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        public frmModificaAerei()
        {  
        }

        public frmModificaAerei(Action RefreshGrid,string CodiceAerei):this()
        {
            this._RefreshGrid = RefreshGrid;
            this._CodiceAerei = CodiceAerei;
            InitializeComponent();
        }



        private void frmModificaAerei_Load(object sender, EventArgs e)
        {
            
            this.tblAereiTableAdapter.FillByCodiceAereo(this.aeroportoDataSet.tblAerei, this._CodiceAerei);

            

        }
        
        private void btnSalva_Click(object sender, EventArgs e)
        {
            if ((txtCompagnia.Text != "") && (txtMarca.Text != "") && (txtModello.Text != "") && (updCapacita.Value > 0) && (updRaggio.Value > 0) && (updLitri.Value > 0) && (updMotori.Value > 0) && (updVelocita.Value > 0) && (txtPropulsione.Text != ""))
            {
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tblAereiTableAdapter.ModificaAereo(txtMarca.Text, txtModello.Text, Convert.ToInt16(updCapacita.Value), Convert.ToInt16(updLitri.Value), Convert.ToByte(updMotori.Value), txtPropulsione.Text, chkInternazionale.Checked, Convert.ToInt16(updRaggio.Value), Convert.ToInt16(updVelocita.Value), txtCompagnia.Text, _CodiceAerei);
                    this._RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtCompagnia.Text == "")
                {
                    errorProvider2.SetError(txtCompagnia, "Inserire i dati correttamente");
                }
                if (txtMarca.Text == "")
                {
                    errorProvider3.SetError(txtMarca, "Inserire i dati correttamente");
                }
                if (txtModello.Text == "")
                {
                    errorProvider4.SetError(txtModello, "Inserire i dati correttamente");
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

    private void txtMarca_KeyUp(object sender, KeyEventArgs e)
    {
        errorProvider3.Clear();

    }

    private void txtModello_KeyUp(object sender, KeyEventArgs e)
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

 
    }
}
