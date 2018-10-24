using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.informacija();
        }
        public void informacija()
        {
            var vardas = "Steponas";
            var pavarde = "Petrauskas";
            var amzius = 55;
            var profesija = "inzinierius";

            Console.WriteLine("{0}\n{1}\n{2}\n{3}", vardas, pavarde, amzius, profesija);
        }
    }
}
