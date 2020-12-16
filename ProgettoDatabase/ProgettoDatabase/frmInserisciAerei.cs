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
    public partial class frmInserisciAerei : Form
    {



        public frmInserisciAerei()
        {
            InitializeComponent();
        }


        private void btnSalva_Click(object sender, EventArgs e)
        {
            if ((txtCodice.Text != "") && (txtCompagnia.Text != "") && (txtMarca.Text != "") && (txtModello.Text != "") && (updCapacita.Value > 0) && (updRaggio.Value > 0) && (updLitri.Value > 0) && (updMotori.Value > 0) && (updVelocita.Value > 0) && (txtPropulsione.Text != ""))
            {
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tblAereiTableAdapter.InserisciAerei(txtCodice.Text, txtMarca.Text, txtModello.Text, Convert.ToInt16(updCapacita.Value), Convert.ToInt16(updLitri.Value), Convert.ToByte(updMotori.Value), txtPropulsione.Text, chkInternazionale.Checked, Convert.ToInt16(updRaggio.Value), Convert.ToInt16(updVelocita.Value), txtCompagnia.Text);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void frmInserisciAerei_Load(object sender, EventArgs e)
        {

        }







        private void btnSalvaENuovo_Click(object sender, EventArgs e)
        {
            if ((txtCodice.Text != "") && (txtCompagnia.Text != "")  && (txtMarca.Text != "") && (txtModello.Text != "") && (updCapacita.Value > 0) && (updRaggio.Value > 0) && (updLitri.Value > 0) && (updMotori.Value > 0) && (updVelocita.Value > 0) && (txtPropulsione.Text != ""))
            {
                if (MessageBox.Show("Vuoi salvare le modifiche?", "Salvataggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tblAereiTableAdapter.InserisciAerei(txtCodice.Text, txtMarca.Text, txtModello.Text, Convert.ToInt16(updCapacita.Value), Convert.ToInt16(updLitri.Value), Convert.ToByte(updMotori.Value), txtPropulsione.Text, chkInternazionale.Checked, Convert.ToInt16(updRaggio.Value), Convert.ToInt16(updVelocita.Value), txtCompagnia.Text);
                    txtCodice.Text = "";
                    txtCompagnia.Text = "";
                    txtMarca.Text = "";
                    txtModello.Text = "";
                    updCapacita.Value = 0;
                    updLitri.Value = 0;
                    updMotori.Value = 0;
                    updRaggio.Value = 0;
                    updVelocita.Value = 0;
                    txtPropulsione.Text = "";
                    chkInternazionale.Checked = false;
                }
                else
                {
                    MessageBox.Show("Non puoi lasciare campi vuoti oppure a zero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
