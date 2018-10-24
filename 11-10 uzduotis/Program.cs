using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var rand = new Random();
            Console.WriteLine(program.skaiciai(rand, 0, 100));
        }
        public int skaiciai(Random rand, int nuo, int iki)
        {
            return rand.Next(nuo, iki);
        }
    }
}
