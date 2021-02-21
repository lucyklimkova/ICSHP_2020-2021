using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodneCislo
{
    class Program
    {
        static void zjistiPohlavi(string rodneCislo)
        {
            
            if (!jeRCValidni(rodneCislo)) {
                Console.WriteLine("Zadali jste špatný formát rodného čísla!");
                return;
            }
            
            
            int cislo = int.Parse(rodneCislo.Substring(2, 2));
            if ((cislo - 50) > 0 && (cislo - 50) <= 12)
            {
                Console.WriteLine("Žena");
            }
            else
            {
                Console.WriteLine("Muž");
            }
        }

        static bool jeRCValidni(string rodneCislo)
        {

            if (rodneCislo.Length == 11 && rodneCislo[6] == '/')
            {
                ulong rC = UInt64.Parse(string.Concat(rodneCislo.Substring(0, 6), rodneCislo.Substring(7, 4)));
                if  ((rC % 11) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            } else
            {
                return false;
            }

        }
        static void Main(string[] args)
        {
            //string cislo = "975703/6245";

            var vstup= " ";
            Console.WriteLine("Program na kontrolu rodného čísla. Pro ukončení zadej 0.");
            while (true)
            {
                Console.Write("Zadej své rodné číslo: ");
                vstup = Console.ReadLine();
                if (vstup == "0")
                {
                    break;
                }
                Program.zjistiPohlavi(vstup);
            }
            Console.ReadKey();

        }
    }
}
