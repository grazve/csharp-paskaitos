using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.skaiciavimas(5, 6);
        }
        public void skaiciavimas(int a, int b)
        {
            sudetis(a, b);
            atimtis(a, b);
            daugyba(a, b);
            dalyba(a, b);

            Console.WriteLine();
        }
        public void sudetis(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        public void atimtis(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        public void daugyba(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        public void dalyba(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }
    }
}
