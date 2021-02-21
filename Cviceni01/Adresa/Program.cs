using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("První způsob:");
            Console.Write("Josef Novák \nJindřišská 16 \n111 50, Praha 1 \n");

            Console.WriteLine("Druhý způsob:");
            Console.WriteLine("Josef Novák");
            Console.WriteLine("Jindřišská 16");
            Console.WriteLine("111 50, Praha 1");


            Console.WriteLine("Třetí způsob: ");
            string[] @adresa = { "Josef Novák", "Jindřišská 16", "111 50, Praha 1" };
            for (int i = 0; i < @adresa.Length; i++)
            {
                Console.WriteLine(adresa[i]);
            }
            Console.ReadKey();
        }
    }
}
