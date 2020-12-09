using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoDatabase.Classi
{
    public class Aeroporti
    {
        public string Sigla { get; }
        public string Nome { get; }
        public int Piste { get; }
        public int Terminal { get; }
        public int Gates { get; }
        public string Nazione { get; }
        public string Citta { get; }
        public bool Militare { get; }
        public bool Internazionale { get; }

        public Aeroporti(string Sigla, string Nome, int Piste, int Terminal, int Gates, string Nazione, string Citta, bool Militare, bool Internazionale)
        {
            this.Sigla = Sigla;
            this.Nome = Nome;
            this.Piste = Piste;
            this.Terminal = Terminal;
            this.Gates = Gates;
            this.Nazione = Nazione;
            this.Citta = Citta;
            this.Militare = Militare;
            this.Internazionale = Internazionale;
        }
    }
}
