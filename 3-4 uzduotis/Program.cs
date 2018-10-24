using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 58;
            var suma = skaicius / 10;
            var suma1 = skaicius % 10;
            

             Console.WriteLine(suma + suma1);

            var vienas = 1;
            var penki = 5;
         

            Console.WriteLine("{1} * {0} = {2}", vienas++, penki, vienas++ * penki);
            Console.WriteLine("{1} * {0} = {2}", vienas++, penki, vienas++ * penki);
            Console.WriteLine("{1} * {0} = {2}", vienas++, penki, vienas++ * penki);
     
        }

    }
}

