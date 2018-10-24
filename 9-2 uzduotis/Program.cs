using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var vardai = new[] { "grazvyda","vytautas", "vaida", "milda", "steponas", "paulius" };
            Console.WriteLine(vardai[rand.Next(vardai.Length)]);
            
        }
    }
}
