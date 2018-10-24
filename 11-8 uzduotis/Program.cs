using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var rand = new Random();
            var skaiciai = p.generuotiskaicius(rand);

        }
        public List<int> generuotiskaicius(Random rand)
        {
            var skaiciai = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                skaiciai.Add(rand.Next(100));

            }

            return skaiciai;

        }
        public void isvedimas(List<int> skaiciai)
        {
    }
}
