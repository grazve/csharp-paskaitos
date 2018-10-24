using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var knygynas = new Knygynas("Pegasas", "Akropolis", new List<Knyga>
            {
                new Knyga("Haris Poteris", "Rawling", 500, "vaikiska", 12.32, 30),
                new Knyga("hgfgh", "hgfhfhg", 200, "gfghf", 14.50, 45),
                new Knyga("hfyfy", "hfhgfgv", 205, "bhvhgf", 12.03, 15),
            });

            knygynas.Isvedimas();

        }
    }
}
