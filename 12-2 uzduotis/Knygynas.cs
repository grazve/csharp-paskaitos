using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_uzduotis
{
    class Knygynas
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Knyga> Knygos { get; private set; }

        public Knygynas(string pava, string adre, List<Knyga> kny)
        {
            Pavadinimas = pava;
            Adresas = adre;
            Knygos = kny;
        }
        public void Isvedimas()
        {
            Console.WriteLine("Knygyno pavadinimas: " + Pavadinimas);
            Console.WriteLine("Adresas: " + Adresas);
            foreach (var knyga in Knygos)
            {
                knyga.Isvedimas();

            }
            Console.WriteLine("Didziausia knyga: ");
            DidziausiaKnyga().Isvedimas();
        }
        public Knyga DidziausiaKnyga()
        {
            var didziausia = Knygos.First();
            foreach (var knyga in Knygos)
            {
                if (knyga.Puslapiai > didziausia.Puslapiai)
                {
                    didziausia = knyga;

                }

            }
            return didziausia;
        }
        public double BendraApyvarta()
        {
            var didziausia = Knygos.First();
            foreach (var knyga in Knygos)
            {
                if (knyga.Kaina > didziausia.Kaina)
                {
                    didziausia = knyga

                }

            }
    }
}
