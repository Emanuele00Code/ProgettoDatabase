using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDatabase
{
    public partial class frmAvvio : Form
    {
        public frmAvvio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tstLabelOra.Text= DateTime.Now.ToString("HH:mm:ss");
        }

        private void frmAvvio_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.vwVoliConPiuPasseggeri'. È possibile spostarla o rimuoverla se necessario.
            this.vwVoliConPiuPasseggeriTableAdapter.Fill(this.aeroportoDataSet.vwVoliConPiuPasseggeri);
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.vwVoliConPiuIncasso'. È possibile spostarla o rimuoverla se necessario.
            this.vwVoliConPiuIncassoTableAdapter.Fill(this.aeroportoDataSet.vwVoliConPiuIncasso);
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblPersone'. È possibile spostarla o rimuoverla se necessario.
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.vwAereiConMaggiorNumeroVoli'. È possibile spostarla o rimuoverla se necessario.
            this.vwAereiConMaggiorNumeroVoliTableAdapter.Fill(this.aeroportoDataSet.vwAereiConMaggiorNumeroVoli);
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.vwVoliConPilota'. È possibile spostarla o rimuoverla se necessario.
            this.vwVoliConPilotaTableAdapter.Fill(this.aeroportoDataSet.vwVoliConPilota);
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.vwNumeroVoliBologna'. È possibile spostarla o rimuoverla se necessario.
            this.vwNumeroVoliBolognaTableAdapter.Fill(this.aeroportoDataSet.vwNumeroVoliBologna);
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.vwNumeroVoliBologna'. È possibile spostarla o rimuoverla se necessario.
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.vwAereiConMaggiorNumeroVoli'. È possibile spostarla o rimuoverla se necessario.
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.tblPersone'. È possibile spostarla o rimuoverla se necessario.
            // TODO: questa riga di codice carica i dati nella tabella 'aeroportoDataSet.vwListaPasseggeri'. È possibile spostarla o rimuoverla se necessario.
            this.vwListaPasseggeriTableAdapter.Fill(this.aeroportoDataSet.vwListaPasseggeri);



            //Aerei con maggior numero Voli
            foreach (var item in aeroportoDataSet.vwAereiConMaggiorNumeroVoli)
            {
                lblAereoMaggioriVoli.Text += " " + item.CodiceAereo.ToString();
            }

            //Voli con più incasso
            foreach (var item in aeroportoDataSet.vwVoliConPiuIncasso)
            {
                lblVoliMaggioreIncasso.Text += " " + item.CodiceVolo.ToString();
            }

            //Voli con più passeggeri
            foreach (var item in aeroportoDataSet.vwVoliConPiuPasseggeri)
            {
                lblVoliMaggioriPasseggeri.Text += " " + item.CodiceVolo.ToString();
            }



        }

        private void personeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersone MiePersone = new frmPersone();
            MiePersone.Show();
        }




    }
}
