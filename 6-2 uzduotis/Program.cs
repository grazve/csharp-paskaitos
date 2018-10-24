using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius");
            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            var skaicius3 = Convert.ToInt32(Console.ReadLine());

            switch (skaicius1)
            {
                case 1:
                    Console.WriteLine("{0} + {1} + {2} = {3}", skaicius1, skaicius2, skaicius3, skaicius1 + skaicius2 + skaicius3);
                    break;
            }
        }
    }
}
