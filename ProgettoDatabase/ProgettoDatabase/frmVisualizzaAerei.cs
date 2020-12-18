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
    public partial class frmVisualizzaAerei : Form
    {

        Aerei _MiaAerei;

        public frmVisualizzaAerei()
        {  
        }

        public frmVisualizzaAerei(Aerei MiaAerei): this()
        {
            this._MiaAerei = MiaAerei;
            InitializeComponent();
        }



   

        private void frmVisualizzaAerei_Load(object sender, EventArgs e)
        {
            


            txtCodice.Text = this._MiaAerei.CodiceAereo;
            txtCompagnia.Text = this._MiaAerei.CompagniaAerea;
            
            txtModello.Text = this._MiaAerei.Modello;
            updCapacita.Value = Convert.ToDecimal(this._MiaAerei.CapacitaMassima);
            updLitri.Value = Convert.ToDecimal(this._MiaAerei.LitriCarburante);
            updMotori.Value = Convert.ToDecimal(this._MiaAerei.NumeroMotori);
            updRaggio.Value = Convert.ToDecimal(this._MiaAerei.Raggio);
            updVelocita.Value = Convert.ToDecimal(this._MiaAerei.VelocitaMax);
            txtPropulsione.Text = this._MiaAerei.TipoPropulsione;
            chkInternazionale.Checked = this._MiaAerei.Internazionale;
        }
    }
}
