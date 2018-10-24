using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); 
            var skaiciai1 = new[] { 1, 2, 3, 5 };
            var skaicius1 = skaiciai1[rand.Next(skaiciai1.Length)];
            Console.WriteLine(skaicius1);

            var skaiciai2 = new[] { 3, 5, 8, 9, 8 };
            var skaicius2 = skaiciai2[rand.Next(skaiciai2.Length)];
            Console.WriteLine(skaicius2);

            var skaiciai3 = new[] { 3, 2, 4, 6, 8 };
            var skaicius3 = skaiciai3[rand.Next(skaiciai3.Length)];
            Console.WriteLine(skaicius3);

            if (skaicius1 > skaicius2 && skaicius1 > skaicius3 )
            {
                Console.WriteLine(skaicius1 + " didziausias");
            }
            else if (skaicius2 > skaicius1 && skaicius2 > skaicius3)
            {
                Console.WriteLine(skaicius2 + " didziausias");
            }
            else if (skaicius3 > skaicius1 && skaicius3 > skaicius2 )
            {
                Console.WriteLine(skaicius3 + " didziausias");
            }

        }
    }
}
