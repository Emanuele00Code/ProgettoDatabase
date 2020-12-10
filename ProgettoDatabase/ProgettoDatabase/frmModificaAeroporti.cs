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

        public frmModificaAeroporti()
        {
        }

        public frmModificaAeroporti(string Sigla) : this()
        {
            this._Sigla = Sigla;
            InitializeComponent();
        }




        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblAeroportiTableAdapter.ModificaAeroporto(Convert.ToByte(updPiste.Value), Convert.ToByte(updTerminal.Value), Convert.ToByte(updGates.Value), txtNazione.Text, txtCitta.Text, cbkMilitare.Checked, cbkInternazionale.Checked, _Sigla, txtNome.Text);
            }
        }



        private void frmModificaAeroporti_Load(object sender, EventArgs e)
        {
            
            this.tblAeroportiTableAdapter.FillBySigla(this.aeroportoDataSet.tblAeroporti,this._Sigla);


            }
    }
}
