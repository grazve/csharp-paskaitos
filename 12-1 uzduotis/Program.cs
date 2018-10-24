using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_uzduotis
{
    class Lektuvas
    {
        public int SparnuIlgis;
        public string Pavadinimas;
        public int Vietos;
        public string Klase;
        public int VarikliuSkaicius;
        public string VariklioTipas;

        public Lektuvas()
        {

        }

        public Lektuvas(int sparil, string pava, int viet, string kl, int varsk, string vart)
        {
            SparnuIlgis = sparil;
            Pavadinimas = pava;
            Vietos = viet;
            Klase = kl;
            VarikliuSkaicius = varsk;
            VariklioTipas = vart; 
        }

        public void Isvedimas()
        {
            Console.WriteLine("Lektuvas {0} turi {1} vietu, jo sparnu ilgis {2}", SparnuIlgis, Pavadinimas, Vietos);
        }
        public void skaiciavimas()
        {
            Console.WriteLine(SparnuIlgis / 2);
        }
        public int SparnoIlgis()
        {
            return SparnuIlgis / 2;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var lektuvas1 = new Lektuvas();
            var lektuvas2 = new Lektuvas();

            lektuvas1.Pavadinimas = "Boeying";
            lektuvas1.Vietos = 600;
            lektuvas1.Klase = "Tarpatlantinis";
            lektuvas1.SparnuIlgis = 500;
            lektuvas1.VarikliuSkaicius = 2;
            lektuvas1.VariklioTipas = "Turbo";

            lektuvas2.Pavadinimas = "Kukuruznikas";
            lektuvas2.Vietos = 1;
            lektuvas2.Klase = "Ukinis";
            lektuvas2.SparnuIlgis = 2;
            lektuvas2.VarikliuSkaicius = 1;
            lektuvas2.VariklioTipas = "Reaktyvinis";

            Console.WriteLine(lektuvas1.Pavadinimas);
            Console.WriteLine(lektuvas2.VariklioTipas);
            Console.WriteLine(lektuvas1.VarikliuSkaicius);

            lektuvas1.Isvedimas();
            lektuvas2.Isvedimas();

            lektuvas1.skaiciavimas();
            lektuvas2.skaiciavimas();

            var lektuvas3 = new Lektuvas(5, "F15", 2, "Naikintuvas", 2, "Reaktyvinis");
            lektuvas3.Isvedimas();
        }
    }
}
