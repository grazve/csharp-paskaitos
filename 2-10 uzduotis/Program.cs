using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var Name = "Tomas";
            var Age = 30;

            Console.WriteLine("Vardas: {0}", Name);
            Console.WriteLine("Amzius: {0}", Age);

            Name = "liepa";
            var Height = "7 metru";
            var Thickness = "145mm";

            Console.WriteLine("Medis yra{1}aukscio ir {2} storio", Name, Height, Thickness);

            var Number = 25;

            Console.Write("{0}{0}{0}{0}{0}", Number);
        }
    }
}
