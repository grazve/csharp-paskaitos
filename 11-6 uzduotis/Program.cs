using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var vardas = "Steponas";
            var pavarde = "Petrauskas";
            var amzius = 55;
            var profesija = "inzinierius";
            program.informacija(vardas, pavarde, amzius, profesija);
        }
        public void informacija(string v, string p, int a, string pro)
        {
            Console.WriteLine("{0} {1} {2} {3}", v, p, a, pro);
        }
    }
}
