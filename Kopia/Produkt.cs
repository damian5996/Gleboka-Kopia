using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopia
{
    class Produkt
    {
        private string nazwa;
        private double cena;
        public Produkt() { }
        public Produkt(string nazwa, double cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
        }
        public string GetNazwa()
        {
            return this.nazwa;
        }
        public double GetCena()
        {
            return this.cena;
        }

    }
}
