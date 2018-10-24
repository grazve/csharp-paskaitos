using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laipsniai Celsijaus");
            var C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Laipsniai Kelvinais");
            var K = C + 273.15;
            Console.WriteLine(K);
            Console.WriteLine("Laipsniai Farengeitais");
            var F = C * (9.0 / 5) + 32;
            Console.WriteLine(F);


            

        }
    }
}
