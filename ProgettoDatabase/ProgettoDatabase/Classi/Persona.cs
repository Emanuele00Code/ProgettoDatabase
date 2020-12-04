using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDatabase.Classi
{
   public class Persona
    {
        public string CodicePersona {get;}
        public string Nome { get; }
        public string Cognome { get; }
        public string Nazione { get; }
        public string DataNascita { get; }
        public string Sesso { get; }
        public string TipoDocumento { get; }
        public string NumeroDocumento { get; }

        public Persona(string CodicePersona,string Nome, string Cognome, string Nazione,string DataNascita,string Sesso,string TipoDocumento,string NumeroDocumento)
        {
          this.CodicePersona=CodicePersona;
          this.Nome=Nome;
          this.Cognome=Cognome;
          this.Nazione=Nazione;
          this.DataNascita=DataNascita;
          this.Sesso=Sesso;
          this.TipoDocumento=TipoDocumento;
          this.NumeroDocumento=NumeroDocumento;
        }



    }
}
