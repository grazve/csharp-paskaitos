using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_uzduotis
{
    class Knyga
    {
        public string Pavadinimas { get; private set; }
        public string  Autorius { get; private set; }
        public int Puslapiai { get; private set; }
        public string Zanras { get; private set; }
        public double Kaina { get; private set; }
        public int Kiekis { get; private set; }

        public Knyga(string pava, string auto, int pusl, string zan, double kai, int kiek)
        {
            Pavadinimas = pava;
            Autorius = auto;
            Puslapiai = pusl;
            Zanras = zan;
            Kaina = kai;
            Kiekis = kiek;
        }
        public void Isvedimas()
        {
            Console.WriteLine("Pavadinimas: " + Pavadinimas);
            Console.WriteLine("Autorius: " + Autorius);
            Console.WriteLine("Zanras: " + Zanras);
            Console.WriteLine("Pardavimas: {0} apyvartos", Pelnas());
        }
        public double Pelnas()
        {
            return Kiekis * Kaina;
        }


    }
}
