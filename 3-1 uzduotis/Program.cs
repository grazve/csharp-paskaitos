using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 10 - 5;
            var kvadratas = 5 * 5;

            Console.WriteLine(skaicius);
            Console.WriteLine(kvadratas);
            Console.WriteLine(Math.Pow(skaicius, 3));

            var pirmas = 2;
            var antras = 3;
            var trecias = 4;
            var suma = pirmas + antras + trecias;

            Console.WriteLine("{0} + {1} + {2} = {3}", pirmas, antras, trecias, suma);

            suma = pirmas * antras * trecias;

            Console.WriteLine("{0} * {1} * {2} = {3}", pirmas, antras, trecias, suma);


        }
    }
}
