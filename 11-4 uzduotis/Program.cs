using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.Lentele();
        }
        public void Lentele()
        {
            
            
            {
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 0; j <= 5; j++)
                    {
                        Console.Write("{0,3}", i + j);

                    }
                    Console.WriteLine();

                }
            }
        }
    }
}
