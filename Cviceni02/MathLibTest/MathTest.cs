using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fei.BaseLib;

namespace MathLibTest
{
    class MathTest
    {
        static void Main(string[] args)
        {

            string str = MathConvertor.ConvertIntToRomanNumberString(5);
            Console.WriteLine(str);
            // MathConvertor.ConvertRomanNumStringToInt("IIL");
            int num = MathConvertor.ConvertRomanNumStringToInt("V");
            Console.WriteLine(num);
            if (ExtraMath.SolveQuadraticEquation(1, 2, 1, out var x1, out var x2))
            {
                Console.WriteLine("True");
            } else
            {
                Console.WriteLine("False");

            }
            //ExtraMath.SolveQuadraticEquation(-1, 2, -2, out var x1, out var x2);
            double cislo = ExtraMath.RandomDoubleFromRange(15, 20);
            Console.WriteLine(cislo);
            Console.ReadKey();

        }
    }
}
