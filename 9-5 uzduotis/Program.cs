using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] { 2, 1, 4, 5, 6, 1, 2, 3, 4, 8 };
            for (int i = 0; i < skaiciai.Length  ; i++)
            {
                Console.Write("[" + skaiciai[i] + "] ");

            }
        }
    }
}
