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
    public partial class frmModificaAeroporti : Form
    {

        string _Sigla;
        readonly Action _RefreshGrid;
        public frmModificaAeroporti()
        {
        }

        public frmModificaAeroporti(Action RefreshGrid,string Sigla) : this()
        {
            this._RefreshGrid = RefreshGrid;
            this._Sigla = Sigla;
            InitializeComponent();
        }




        private void btnSalva_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") && (txtNazione.Text != "") && (txtCitta.Text != "") && (updPiste.Value > 0) && (updTerminal.Value > 0) && (updGates.Value > 0))
            {
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tblAeroportiTableAdapter.ModificaAeroporto(Convert.ToByte(updPiste.Value), Convert.ToByte(updTerminal.Value), Convert.ToByte(updGates.Value), txtNazione.Text, txtCitta.Text, cbkMilitare.Checked, cbkInternazionale.Checked, _Sigla, txtNome.Text);
                    this._RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }



        private void frmModificaAeroporti_Load(object sender, EventArgs e)
        {
            
            this.tblAeroportiTableAdapter.FillBySigla(this.aeroportoDataSet.tblAeroporti,this._Sigla);


            }
    }
}
