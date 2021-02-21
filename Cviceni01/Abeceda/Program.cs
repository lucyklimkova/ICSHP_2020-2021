using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abeceda
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Abeceda cyklem for:");
            for (int i = 65; i < 91; i++)
            {
                ch = (char) i;
                Console.WriteLine(ch);
            }

            Console.WriteLine("Abeceda cyklem while:");
            int cislo = 65;
            while (cislo < 91)
            {
                ch = (char)cislo;
                Console.WriteLine(ch);
                cislo++;
            }

            Console.WriteLine("Abeceda cyklem do while:");
            cislo = 65;
            do
            {
                ch = (char)cislo;
                Console.WriteLine(ch);
                cislo++;
            } while (cislo < 91);

            Console.ReadKey();
        }
    }
}
