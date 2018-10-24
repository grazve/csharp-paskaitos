using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite amziu");
            var amzius = Convert.ToInt32(Console.ReadLine());
            if (amzius >= 18)
            {
                Console.WriteLine("jus galite balsuoti");
            }
            if (amzius < 18)
            {
                Console.WriteLine("jus negalite balsuoti");
            }
        }
    }
}
