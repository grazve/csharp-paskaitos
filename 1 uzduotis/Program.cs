using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperaturos = new List<int>();

            Console.WriteLine("Kiek dienu temperaturu norite ivesti");

            var norimaskiekis = Convert.ToInt32(Console.ReadLine());
            var temperatura = new int[norimaskiekis];

            for (int i = 0; i < temperatura.Length; i++)
            {
                Console.Write("Iveskite {0}-osios dienos temperatura: ", i+1);
                temperatura[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Jusu ivestos temperaturos: ");
            foreach (var skaicius in temperatura)
            {
                Console.Write(skaicius + ", ");
            }
            var suma = 0;

            foreach (var sm in temperatura)
            {
                suma += sm;
            }

            var vidurkis = (double)suma / temperatura.Length;
            
            Console.WriteLine("Ivestu temperaturu vidurkis: " + vidurkis);

            var min = temperatura[0];
            
            foreach (var maziausia in temperatura)
            {
                if (maziausia < min)
                {
                    min = maziausia;
                } 
            }
            Console.WriteLine("Zemiausia temperatura: " + min);

            var max = temperatura[0];

            foreach (var didziausia in temperatura)
            {
                if (didziausia > max)
                {
                    max = didziausia;
                }
            }
            Console.WriteLine("{0} diena buvo didziausia temperatura kuri sieke " + max + " laipsnius");





        }
    }

}
