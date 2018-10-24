using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius");
            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            var skaicius3 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 == skaicius2)
            {
                Console.WriteLine("lygus");
            }
            if (skaicius2 == skaicius3)
            {
                Console.WriteLine("lygus");
     
            }

        }
    }
}
