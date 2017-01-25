using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopia
{
    class Zamowienie:Telefon
    {
        private Telefon telefon;
        private int ileSztuk;

        public Telefon GetTelefon()
        {
            telefon = new Telefon(GetNazwa(),GetCena(),GetModel());
            return telefon;
        }
        public Zamowienie() { }
        public Zamowienie(string nazwa, double cena, string model, int ileSztuk)
            :base(nazwa,cena,model)
        {
            this.ileSztuk = ileSztuk;
            this.telefon = new Telefon(nazwa, cena, model);
        }
        public int GetIleSztuk()
        {
            return this.ileSztuk;
        }
        
        public Zamowienie GlebokaKopiaZamowienia()
        {
            Zamowienie temp = new Zamowienie(telefon.GetNazwa(), telefon.GetCena(), telefon.GetModel(), ileSztuk);
            if (telefon != null)
                temp.telefon = telefon.GlebokaKopiaTelefonu();
            
            return temp;
        }
    }
}
