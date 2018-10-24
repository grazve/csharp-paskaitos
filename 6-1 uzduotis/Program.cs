using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            switch (skaicius)
            {
                case 1:
                    Console.WriteLine("vanduo");
                    break;
                case 2:
                    Console.WriteLine("limonadas");
                    break;
                case 3:
                    Console.WriteLine("arbata");
                    break;
                case 4:
                    Console.WriteLine("kava");
                    break;
                default:
                    Console.WriteLine("pasirinkimas neegzistuoja");
                    break;
                
                
            }
         
        }
    }
}
