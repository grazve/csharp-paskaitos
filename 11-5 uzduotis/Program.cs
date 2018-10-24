using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.zodis("--pomidoras--");
            program.zodis("--kriause--");
            program.zodis("--obuolys--");
            program.zodis("--slyva--");
        }
        public void zodis(string vaisius)
        {
            Console.WriteLine(vaisius);
        }

    }
}
