using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            double pirmas = 4;
            var antras = 6;
            var suma = pirmas + antras;

            Console.WriteLine("{0} + {1} = {2}", pirmas, antras, suma);

            suma = pirmas - antras;

            Console.WriteLine("{0} - {1} = {2}", pirmas, antras, suma);

            suma = pirmas / antras;

            Console.WriteLine("{0} / {1} = {2}", pirmas, antras, suma);

            var skaiciavimas1 = -1 + 4 * 6;
            var skaiciavimas2 = (35 + 5) % 7;

            Console.WriteLine(skaiciavimas1);
            Console.WriteLine(skaiciavimas2);
        }
    }
}
