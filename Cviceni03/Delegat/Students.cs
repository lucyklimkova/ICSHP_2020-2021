using System;

namespace Delegat
{
    public class Students
    {
        public delegate bool CompareCisloDelegate(int prvni, int druhy);
        public delegate bool CompareJmenoDelegate(string prvni, string druhy);
        public delegate bool CompareFakultaDelegate(Fakulta prvni, Fakulta druhy);

        Student[] poleStudentu;

        private void printMenu()
        {
            Console.WriteLine("----Menu----\n"
                              + "1) Načtení studentů z klávesnice\n"
                              + "2) Výpis studentů na obrazovku\n"
                              + "3) Seřazení studentů podle čísla\n"
                              + "4) Seřazení studentů podle jména\n"
                              + "5) Seřazení studentů podle fakulty\n"
                              + "6) Vypiš menu\n"
                              + "0) Konec programu\n");
        }


        public void menu()
        {
           poleStudentu = new Student[0];
            printMenu();
            while (true)
            {
                string str = Console.ReadLine();
                int.TryParse(str, out int selectedMenu);

                try { 
                    switch (selectedMenu)
                    {
                        case 1:
                            poleStudentu = CreateNewArray();
                            break;
                        case 2:
                            PrintArray(poleStudentu);
                            break;
                        case 3:
                            SortArrayByCislo(WhichNumberIsHigher);
                            break;
                        case 4:
                            SortArrayByJmeno(WhichStringIsFirst);
                            break;
                        case 5:
                            SortArrayByFakulta(WhichFacultyIsFirst);
                            break;
                        case 6:
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
                    Console.WriteLine("Číslo mimo rozsah " + e.Message);
                }
            }
        }
        private Student[] CreateNewArray()
        {
            Console.WriteLine("Zadejte kolik studentů chcete načítat: ");
            string str = Console.ReadLine();
            int.TryParse(str, out int size);
            Student[] array = new Student[size];

            string jmeno;
            string temp;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Zadejte jméno: ");
                jmeno = Console.ReadLine();
                Console.WriteLine("Zadejte číslo: ");
                temp = Console.ReadLine();
                int.TryParse(temp, out int cislo);
                Console.WriteLine("Zadejte fakultu: ");
                Fakulta.TryParse(Console.ReadLine(), out Fakulta fakulta);
                array[i] = new Student(jmeno, cislo, fakulta);
            }
            return array;
        }

        private void PrintArray(Student[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Pole je prázdné!");
                return;
            }


            for (int i = 0; i < array.Length; i++)
            {
                    Console.Write(array[i].ToString());

            }
            Console.WriteLine();
        }

        private void SortArrayByFakulta(CompareFakultaDelegate compareFacultyDelegate)
        {
            Student temp;
            for (int write = 0; write < poleStudentu.Length; write++)
            {
                for (int sort = 0; sort < poleStudentu.Length - 1; sort++)
                {
                    if (compareFacultyDelegate(poleStudentu[sort].Fakulta, poleStudentu[sort + 1].Fakulta))
                    {
                        temp = poleStudentu[sort + 1];
                        poleStudentu[sort + 1] = poleStudentu[sort];
                        poleStudentu[sort] = temp;
                    }
                }
            }
            Console.WriteLine("Seřazeni podle fakult bylo úspěšné!");
        }

        public bool WhichFacultyIsFirst(Fakulta prvni, Fakulta druhy)
        {
            if (prvni < druhy)
            {
                return false;
            }
            return true;
        }

        private void SortArrayByJmeno(CompareJmenoDelegate compareNameDelegate)
        {
            Student temp;
            for (int write = 0; write < poleStudentu.Length; write++)
            {
                for (int sort = 0; sort < poleStudentu.Length - 1; sort++)
                {
                    if (compareNameDelegate(poleStudentu[sort].Jmeno.ToString(),
                        poleStudentu[sort + 1].Jmeno.ToString()))
                    {
                        temp = poleStudentu[sort + 1];
                        poleStudentu[sort + 1] = poleStudentu[sort];
                        poleStudentu[sort] = temp;
                    }
                }
            }
            Console.WriteLine("Seřazeni podle jmen bylo úspěšné!");
        }
        public bool WhichStringIsFirst(string prvni, string druhy)
        {
            int temp = string.Compare(prvni, druhy);
            if (temp < 0)
            {
                return false;
            }
            else 
            { 
                return true; 
            }
        }


        private void SortArrayByCislo(CompareCisloDelegate compareNumDelegate)
        {
            Student temp;
            for (int write = 0; write < poleStudentu.Length; write++)
            {
                for (int sort = 0; sort < poleStudentu.Length - 1; sort++)
                {
                    if (compareNumDelegate(int.Parse(poleStudentu[sort].Cislo.ToString()),
                        int.Parse(poleStudentu[sort + 1].Cislo.ToString())))
                    {
                        temp = poleStudentu[sort + 1];
                        poleStudentu[sort + 1] = poleStudentu[sort];
                        poleStudentu[sort] = temp;
                    }
                }
            }
            Console.WriteLine("Seřazeni podle čísel bylo úspěšné!");
        }

        public bool WhichNumberIsHigher(int prvni, int druhy)
        {
            if (prvni > druhy) 
            {    
                return true; 
            }
            else 
            {
                return false; 
            }
        }

    }
}
