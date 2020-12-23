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
    public partial class frmVisualizzaAeroporti : Form
    {

        Aeroporti _MioAeroporto;

        public frmVisualizzaAeroporti()
        {  
        }

        public frmVisualizzaAeroporti(Aeroporti MioAeroporto): this()
        {
            this._MioAeroporto = MioAeroporto;
            InitializeComponent();
        }


        private void frmVisualizzaPersona_Load(object sender, EventArgs e)
        {
            this.tblAeroportiTableAdapter.Fill(this.aeroportoDataSet.tblAeroporti);


            txtSigla.Text = this._MioAeroporto.Sigla;
            txtNome.Text = this._MioAeroporto.Nome;
            updPiste.Value = this._MioAeroporto.Piste;
            updTerminal.Value = this._MioAeroporto.Terminal;
            updGates.Value = this._MioAeroporto.Gates;
            txtNazione.Text = this._MioAeroporto.Nazione;
            txtCitta.Text = this._MioAeroporto.Citta;

            if(this._MioAeroporto.Militare==true)
            {
                cbkMilitare.Checked = true;
            }
            if (this._MioAeroporto.Internazionale == true)
            {
                cbkInternazionale.Checked = true;
            }
        }

    

        private void updTerminal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void updGates_ValueChanged(object sender, EventArgs e)
        {

        }

        private void updPiste_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
