using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopia
{
    class Program
    {
        static void Main(string[] args)
        {
            Zamowienie zam1 = new Zamowienie("S6 Edge", 1299, "Samsung", 2);
            Zamowienie zam2 = new Zamowienie();

            if (Object.ReferenceEquals(zam1.GetTelefon(), zam2.GetTelefon()))
                Console.WriteLine("Referencje odwołują się do tego samego obiektu");
            else
                Console.WriteLine("Referencje nie odwołują się do tego samego obiektu");

            Console.WriteLine("zam1 = {0}, {1}, {2}, {3}", zam1.GetNazwa(), zam1.GetCena(), zam1.GetModel(), zam1.GetIleSztuk());

            Console.WriteLine("zam2 = {0}, {1}, {2}, {3}", zam2.GetNazwa(), zam2.GetCena(), zam2.GetModel(), zam2.GetIleSztuk());


            zam2 = zam1.GlebokaKopiaZamowienia();


            Console.WriteLine("zam2(po kopiowaniu) = {0}, {1}, {2}, {3}", zam2.GetNazwa(), zam2.GetCena(), zam2.GetModel(), zam2.GetIleSztuk());


            if (Object.ReferenceEquals(zam1.GetTelefon(), zam2.GetTelefon()))
                Console.WriteLine("Referencje odwołują się do tego samego obiektu\n");
            else
                Console.WriteLine("Referencje nie odwołują się do tego samego obiektu\n");

            Telefon tele1 = new Telefon("kdksdk", 2000, "TAK");
            Telefon tele2 = new Telefon();

            if (Object.ReferenceEquals(tele1.GetProdukt(), tele2.GetProdukt()))
                Console.WriteLine("Referencje odwołują się do tego samego obiektu");
            else
                Console.WriteLine("Referencje nie odwołują się do tego samego obiektu");

            Console.WriteLine("tele1 = {0}, {1}, {2}", tele1.GetNazwa(), tele1.GetCena(), tele1.GetModel());

            Console.WriteLine("tele2 = {0}, {1}, {2}", tele2.GetNazwa(), tele2.GetCena(), tele2.GetModel());

            tele2 = tele1.GlebokaKopiaTelefonu();

            Console.WriteLine("tele2(po kopiowaniu) = {0}, {1}, {2}", tele2.GetNazwa(), tele2.GetCena(), tele2.GetModel());

            if (Object.ReferenceEquals(tele1.GetProdukt(), tele2.GetProdukt()))
                Console.WriteLine("Referencje odwołują się do tego samego obiektu\n");
            else
                Console.WriteLine("Referencje nie odwołują się do tego samego obiektu\n");

            Produkt prod1 = new Produkt("BLABLA", 199);
            Produkt prod2 = new Produkt();
            if (Object.ReferenceEquals(prod1.GetNazwa(), prod2.GetNazwa()))
                Console.WriteLine("Referencje odwołują się do tego samego obiektu");
            else
                Console.WriteLine("Referencje nie odwołują się do tego samego obiektu");
            if (Object.ReferenceEquals(prod1.GetCena(), prod2.GetCena()))
                Console.WriteLine("Referencje odwołują się do tego samego obiektu");
            else
                Console.WriteLine("Referencje nie odwołują się do tego samego obiektu");

            Console.WriteLine("prod1 = {0}, {1}", prod1.GetNazwa(), prod1.GetCena());

            Console.WriteLine("prod2 = {0}, {1}", prod2.GetNazwa(), prod2.GetCena());

            prod2 = prod1.KopiaProduktu();
            Console.WriteLine("prod2(po kopiowaniu) = {0}, {1}", prod2.GetNazwa(), prod2.GetCena());

            if (Object.ReferenceEquals(prod1.GetNazwa(), prod2.GetNazwa()))
                Console.WriteLine("Referencje odwołują się do tego samego obiektu");
            else
                Console.WriteLine("Referencje nie odwołują się do tego samego obiektu");
            if (Object.ReferenceEquals(prod1.GetCena(), prod2.GetCena()))
                Console.WriteLine("Referencje odwołują się do tego samego obiektu");
            else
                Console.WriteLine("Referencje nie odwołują się do tego samego obiektu");

            Console.ReadKey();
            

        }
    }
}
