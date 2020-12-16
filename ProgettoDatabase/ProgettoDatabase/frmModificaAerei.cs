﻿using System;
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
            }
        }

        

        
    }
}
