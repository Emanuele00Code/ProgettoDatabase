﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoDatabase.Classi
{
    public class Aerei
    {
        public string Modello { get; set; }
        public int CapacitaMassima { get; set; }
        public int LitriCarburante { get; set; }
        public int NumeroMotori { get; set; }
        public string TipoPropulsione { get; set; }
        public bool Internazionale { get; set; }
        public int Raggio { get; set; }
        public int VelocitaMax { get; set; }
        public string CompagniaAerea { get; set; }
        public string CodiceAereo { get; set; }

        public Aerei( string Modello, int CapacitaMassima, int LitriCarburante,int NumeroMotori, string TipoPropulsione,bool Internazionale, int Raggio,int VelocitaMax,string CompagniaAerea, string CodiceAereo) 
        {
            this.Modello = Modello;
            this.CapacitaMassima = CapacitaMassima;
            this.LitriCarburante = LitriCarburante;
            this.NumeroMotori = NumeroMotori;
            this.TipoPropulsione = TipoPropulsione;
            this.Internazionale = Internazionale;
            this.Raggio = Raggio;
            this.VelocitaMax = VelocitaMax;
            this.CompagniaAerea = CompagniaAerea;
            this.CodiceAereo = CodiceAereo;
        }


    }
}
