using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ivesti reziu pradzia:");
            var pradzia = Convert.ToInt32(Console.ReadLine());
            Console.Write("ivesti reziu pabaiga:");
            var pabaiga = Convert.ToInt32(Console.ReadLine());

            if (pradzia < pabaiga)
            {
                for (int i = pradzia; i < pabaiga; i++)
                {
                    Console.WriteLine(i + " " + i * i);

                }

            }

        }
    }
}
