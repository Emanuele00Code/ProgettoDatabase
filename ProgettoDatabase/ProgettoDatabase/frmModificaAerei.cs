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

        public frmModificaAerei()
        {  
        }

        public frmModificaAerei(string CodiceAerei):this()
        {
            this._CodiceAerei = CodiceAerei;
            InitializeComponent();
        }



        private void frmModificaAerei_Load(object sender, EventArgs e)
        {
            
            this.tblAereiTableAdapter.FillByCodiceAereo(this.aeroportoDataSet.tblAerei, this._CodiceAerei);

            

        }
        
        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblAereiTableAdapter.ModificaAereo(txtMarca.Text, txtModello.Text, Convert.ToInt16(updCapacita.Value), Convert.ToInt16(updLitri.Value), Convert.ToByte(updMotori.Value),  txtPropulsione.Text, chkInternazionale.Checked, Convert.ToInt16(updRaggio.Value), Convert.ToInt16(updVelocita.Value), txtCompagnia.Text, _CodiceAerei) ;
               
                
            }
        }

        

        
    }
}
