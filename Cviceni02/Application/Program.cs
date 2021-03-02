using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fei.BaseLib;

namespace Application
{
    class Program
    {
        private static void printMenu()
        {
            Console.WriteLine("----Menu----\n"
                              + "1. Zadaní prvků pole z klávesnice\n"
                              + "2. Výpis pole na obrazovku\n"
                              + "3. Utřídění pole vzestupně\n"
                              + "4. Utřídění pole sestupně\n"
                              + "5. Hledání minimálního prvku\n"
                              + "6. Hledání prvního výskytu zadaného čísla\n"
                              + "7. Hledání posledního výskytu zadaného čísla\n"
                              + "8. Vytisknutí menu\n"
                              + "0. Konec programu\n");
        }

        static void Main(string[] args) 
        { 
        
            int[] newArray = new int[0];
            printMenu();
            while (true)
            {
                try
                {
                    int selectedMenu = Reading.ReadInt("Zadejte číslo z menu");
                    switch (selectedMenu)
                    {
                        case 1:
                            newArray = createNewArray();
                            break;
                        case 2:
                            printArray(newArray);
                            break;
                        case 3:
                            sortArrayAscending(newArray);
                            break;
                        case 4:
                            sortArrayDescending(newArray);
                            break;
                        case 5:
                            findMinInArray(newArray);
                            break;
                        case 6:
                            findFirst(newArray);
                            break;
                        case 7:
                            findLast(newArray);
                            break;
                        case 8:
                            printMenu();
                            break;
                        case 0:
                            Console.WriteLine("Ukončuji program!");
                            return;
                        default:
                            Console.WriteLine("Neznámý příkaz!");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error - " + e.Message); 
                }
            }
        }


        private static int[] createNewArray()
        {
            int size = Reading.ReadInt("Zadej velikost pole");
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Reading.ReadInt("Zadej " + (i + 1) + ". prvek pole");
            }
            return arr;
        }

        private static void printArray(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Pole je prázdné!");
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if(i == (array.Length-1))
                {
                    Console.Write(array[i]);
                } else
                {
                    Console.Write(array[i] + ", ");
                }     

            }
            Console.WriteLine();
        }


        private static void sortArrayAscending(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Pole je prázdné!");
                return;
            }

            if (array.Length > 2)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    bool swapped = false;
                    for (int j = i; j < array.Length - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int tmp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = tmp;
                            swapped = true;
                        }
                    }
                    for (int j = array.Length - 2 - i; j > i; j--)
                    {
                        if (array[j] < array[j - 1])
                        {
                            int tmp = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = tmp;
                            swapped = true;
                        }
                    }
                    if (!swapped) break;
                }
            }
            Console.WriteLine("Pole bylo seřazeno vzestupně!");
        }

        private static void sortArrayDescending(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Pole je prázdné!");
                return;
            }

            if (array.Length > 2)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    bool swapped = false;
                    for (int j = i; j < array.Length - i - 1; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            int tmp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = tmp;
                            swapped = true;
                        }
                    }
                    for (int j = array.Length - 2 - i; j > i; j--)
                    {
                        if (array[j] > array[j - 1])
                        {
                            int tmp = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = tmp;
                            swapped = true;
                        }
                    }
                    if (!swapped) break;
                }
            }
            Console.WriteLine("Pole bylo seřazeno sestupně!");
        }

        private static void findMinInArray(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Pole je prázdné!");
                return;
            }

            int min = Int32.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Nejmenší hodnota v poli je: " + min);
        }

        private static void findFirst(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Pole je prázdné!");
                return;
            }

            int hledaneCislo = Reading.ReadInt("Zadej číslo, které chceš vyhledat");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(hledaneCislo))
                {
                    Console.WriteLine($"První výskyt čísla <{hledaneCislo}> je na indexu  <{i}>.");
                    return;
                }
            }

            Console.WriteLine($"Číslo <{hledaneCislo}> nebylo nalezeno!");
        }

        private static void findLast(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Pole je prázdné!");
                return;
            }

            int hledaneCislo = Reading.ReadInt("Zadej číslo, které chceš vyhledat");
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i].Equals(hledaneCislo))
                {
                    Console.WriteLine($"Poslední výskyt čísla <{hledaneCislo}> je na indexu <{i}>.");
                    return;
                }
            }

            Console.WriteLine($"Číslo <{hledaneCislo}> nebylo nalezeno!");
        }


    }
}
