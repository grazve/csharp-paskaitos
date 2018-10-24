using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Pasisveikinimas();

        }
        public void Pasisveikinimas()
        {
            Console.WriteLine("iveskite varda");
            var vardas = Console.ReadLine();
            Console.WriteLine("Labas " + vardas);
        }
    }
}
