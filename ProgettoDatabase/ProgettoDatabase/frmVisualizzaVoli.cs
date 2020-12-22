using ProgettoDatabase.Classi;
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

namespace ProgettoDatabase
{
    public partial class frmVisualizzaVoli : Form
    {

        Voli _MioVolo;

        public frmVisualizzaVoli()
        {
        }

        public frmVisualizzaVoli(Voli MioVolo) : this()
        {
            this._MioVolo = MioVolo;
            InitializeComponent();
        }
        private void frmVisualizzaVoli_Load(object sender, EventArgs e)
        {
            this.tblVoliTableAdapter.Fill(this.aeroportoDataSet.tblVoli);

            txtCodice.Text = this._MioVolo.Codice;
            txtCodiceAereo.Text = this._MioVolo.CodiceAereo;
            dtpDataArrivo.Value = Convert.ToDateTime(this._MioVolo.DataOraArrivo);
            dtpDataPartenza.Value = Convert.ToDateTime(this._MioVolo.DataOraPartenza);
            txtCodiceAereo.Text = this._MioVolo.CodiceAereo;
            updDurata.Value = this._MioVolo.Durata;
            updGatePartenza.Value = this._MioVolo.GatePartenza;
            if (this._MioVolo.Internazionale == true)
            {
                chkInternazionale.Checked = true;
            }

        }
    }
}
