using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hadani_cisel
{
    class Program
    {
        static string tipnuteCislo(int hledaneCislo, int tipnuteCislo)
        {
            if (hledaneCislo < tipnuteCislo)
            {
                return "Hledané číslo je menší.";
            }
            else if (hledaneCislo > tipnuteCislo)
            {
                return "Hledané číslo je větší.";
            } else
            {
                return "Nalezeno";
            }
           
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            bool hra = true;

            Console.WriteLine("-----Hra hledání čísla------");
            Console.WriteLine("Máš 10 pokusů na uhádnutí!");
            while (hra)
            {
                int hledaneCislo = random.Next(100);
                int pokusy = 0;
                while (pokusy < 10)
                {
                    Console.WriteLine("Zadej číslo: ");
                    int tip = 0;
                    try
                    {
                        tip = int.Parse(Console.ReadLine());
                        string vysledek = tipnuteCislo(hledaneCislo, tip);
                        Console.WriteLine(vysledek);
                        if (vysledek == "Nalezeno")
                        {
                            Console.WriteLine("Vyhráli jste!!! a Váš počet pokusů byl: " + pokusy);
                            break;
                        }
                        pokusy++;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Nezadali jste číslo!");
                    }
                }

                if (pokusy == 10)
                {
                    Console.WriteLine("Vyčerpali jste 10 pokusů a prohráli jste!!!");
                }
                Console.WriteLine("Chcete hrát znovu? Zadejte Ano pro novou hru nebo cokoliv jiného pro ukončení.");
                string novaHra = Console.ReadLine();
                if (novaHra.ToUpper() != "ANO")
                {
                    hra = false;
                }
            }
            Console.WriteLine("Konec hry.");
            Console.ReadKey();

        }
    }
 }
