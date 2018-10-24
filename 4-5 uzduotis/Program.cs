using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var marke1 = "pirm";
            var modelis1 = "asdf";
            var gamybosmetai1 = 2005;
            var darbturis1 = 1.6;
            var rida1 = 197240;
            var technapziura1 = "false"; 

            Console.WriteLine("+-------+--------+----------------+-----------+------+---------------+");
            Console.WriteLine("|Marke  |Modelis |Gamybos metai   |Darb. turis|Rida  |Techn. apziura |");
            Console.WriteLine("+-------+--------+----------------+-----------+------+---------------+");
            Console.WriteLine("|{0}    |{1}     |{2}             |{3}        |{4}   |{5}            |", marke1, modelis1, gamybosmetai1, darbturis1, rida1, technapziura1);

        }
    }
}
