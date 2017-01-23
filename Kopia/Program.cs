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
            Zamowienie zamowienie1 = new Zamowienie("S6 Edge", 1299, "Samsung", 2);
            Zamowienie zamowienie2 = new Zamowienie();

            Console.WriteLine("{0}, {1}, {2}, {3}", zamowienie1.GetNazwa(), zamowienie1.GetCena(), zamowienie1.GetModel(), zamowienie1.GetIleSztuk());

            Console.WriteLine("{0}, {1}, {2}, {3}", zamowienie2.GetNazwa(), zamowienie2.GetCena(), zamowienie2.GetModel(), zamowienie2.GetIleSztuk());
            zamowienie2 = zamowienie1.GlebokaKopia();

            Console.WriteLine("{0}, {1}, {2}, {3}", zamowienie2.GetNazwa(), zamowienie2.GetCena(), zamowienie2.GetModel(), zamowienie2.GetIleSztuk());
            Console.ReadKey();
        }
    }
}
