using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopia
{
    class Telefon:Produkt
    {
        private Produkt produkt;
        private string model;
        public Telefon() { }
        public Telefon(string nazwa, double cena, string model)
            : base (nazwa, cena)
        {
            this.model = model;
        }
        public string GetModel()
        {
            return this.model;
        }

    }
}
