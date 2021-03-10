using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fei
{
    namespace BaseLib
    {
        /// <summary>
        /// Basic math convertor library:
        /// decimal -> binary
        /// binary -> decimal
        /// decimal -> roman
        /// roman -> decimal 
        /// </summary>
        public class MathConvertor
        {
            /// <summary>
            /// Converts Int to binary number in string format.
            /// </summary>
            /// <param name="intNumber">Int number</param>
            /// <returns>New string</returns>
            public static string ConvertIntToBinaryNumberString(int intNumber)
            {
                return Convert.ToString(intNumber, 2);
            }

            /// <summary>
            /// Converts binary number in string format to Int.
            /// </summary>
            /// <param name="binaryNumber">Binary number</param>
            /// <returns>Int number</returns>
            public static int ConvertBinaryStringToInt(string binaryNumber)
            {
                return Convert.ToInt32(binaryNumber, 2);
            }

            /// <summary>
            /// Converts Int Number in range from 1 to 3999 to roman num string.
            /// </summary>
            /// <param name="intNumber">Int number</param>
            /// <returns>New string</returns>
            /// <exception cref="ArgumentOutOfRangeException">Exception</exception>
            public static string ConvertIntToRomanNumberString(int intNumber)
            {
                if (intNumber <= 0 || intNumber > 4000)
                {
                    throw new ArgumentOutOfRangeException(nameof(intNumber));
                }

                int[] decimalValue = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
                string[] romanNum = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
                var temp = intNumber;
                var stringBuilder = new StringBuilder();

                for (var i = 0; i < decimalValue.Length; i = i + 1)
                {
                    while (decimalValue[i] <= temp)
                    {
                        stringBuilder.Append(romanNum[i]);
                        temp -= decimalValue[i];
                    }
                }

                return stringBuilder.ToString();
            }

            private static Dictionary<char, int> RomanNumbers = new Dictionary<char, int>() {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            /// <summary>
            /// Converts roman num string in range from I to MMMM to Int.
            /// </summary>
            /// <param name="roman">Roman num</param>
            /// <returns>Int number</returns>
            public static int ConvertRomanNumStringToInt(string roman)
            {
                if (!new Regex("^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$").IsMatch(roman))
                {
                    throw new ArgumentException("This string is not a valid roman number or is out of range.");
                }

                roman = roman.ToUpper();
                var number = 0;
                for (var i = 0; i < roman.Length; i++)
                {
                    if (i + 1 < roman.Length && RomanNumbers[roman[i]] < RomanNumbers[roman[i + 1]])
                    {
                        number -= RomanNumbers[roman[i]];
                    }
                    else
                    {
                        number += RomanNumbers[roman[i]];
                    }
                }

                return number;
            }
        }
    }
}