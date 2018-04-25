using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Vlucht
{
    class Vlucht
    {
        public enum Bestemmingen
        {
            Frankrijk, Engeland, Duitsland
        }
        public static int Vluchtnummer { get; set; }
        public Bestemmingen Bestemming { get; set; }
        //public string Vertrek { get; set; }
       // private string vertrek; mag weg, want er wordt niets mee gedaan

        public string Vertrek
        {
            get { return "België"; }
        }


        public DateTime VertrekDatum { get; set; }
        public DateTime Terugdatum { get; set; }

        public Vlucht(Bestemmingen bestemming, DateTime vertrekDatum, DateTime terugdatum)
        {
            Vluchtnummer++;
            Bestemming = bestemming;
            VertrekDatum = vertrekDatum;
            Terugdatum = terugdatum;
        }

        //public Vlucht(int vluchtnummer) :this(vluchtnummer, Bestemmingen.Duitsland, DateTime.Today, DateTime.Today.AddHours(2))
        //{
        //}

        public int Vluchtduur()
        {
            int duur = (Terugdatum.Hour - VertrekDatum.Hour);
            return duur;
        }

        public override string ToString()
        {
            string resultaat = "Vlucht " + Vluchtnummer + " Vliegt van " + Vertrek + " naar " + Bestemming + "\n";
            resultaat += "En duurt " + Vluchtduur() + " uur.";
            return resultaat;
        }
    }
}
