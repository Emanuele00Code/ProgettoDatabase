using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoDatabase.Classi
{
    public class Voli
    {
        public string Codice { get; }
        //DataOraPartenza
        //DataOraArrivo
        public string CodiceAereo { get; }
        public string SiglaAereoporto { get; }
        public int Durata { get; }
        public int GatePartenza { get; }

        public Voli(string Codice, string CodiceAereo, string SiglaAereoporto, int Durata, int GatePartenza)
        {
            this.Codice = Codice;
            //this.DataOraPartenza = DataOraPartenza;
            //this.DataOraArrivo = DataOraPartenza;
            this.CodiceAereo = CodiceAereo;
            this.SiglaAereoporto = SiglaAereoporto;
            this.Durata = Durata;
            this.GatePartenza = GatePartenza;
        }
    }
}
