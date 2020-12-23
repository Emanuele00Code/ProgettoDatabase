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
        
        public string DataOraPartenza { get; }

        public string DataOraArrivo { get; }

        public string CodiceAereo { get; }
        public int Durata { get; }
        public int GatePartenza { get; }

        public bool Internazionale { get; }

        public Voli(string Codice, string DataOraPartenza,string DataOraArrivo, bool internazionale, string CodiceAereo, int Durata, int GatePartenza )
        {
            this.Codice = Codice;
            this.DataOraPartenza = DataOraPartenza;
            this.DataOraArrivo = DataOraArrivo; 
            this.CodiceAereo = CodiceAereo;
            this.Durata = Durata;
            this.GatePartenza = GatePartenza;
            this.Internazionale = Internazionale;
        }
    }
}
