using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fei
{
    namespace BaseLib
    {
        /// <summary>
        /// Library for reading int, double, char or string from console.
        /// </summary>
        public class Reading
        {
            /// <summary>
            /// Reads an integer.
            /// </summary>
            /// <param name="msg">The description.</param>
            /// <returns>The int input.</returns>
            /// <exception cref="ArgumentException">Thrown if the input is malformed.</exception>
            public static int ReadInt(string msg)
            {
                Console.Write($"{msg}: ");
                string str = Console.ReadLine();
                if (!int.TryParse(str, out int result))
                {
                    throw new ArgumentException($"Cannot read int from <{str}>.");
                }

                return result;
            }

            /// <summary>
            /// Reads a double.
            /// </summary>
            /// <param name="msg">The description.</param>
            /// <returns>The double input.</returns>
            /// <exception cref="ArgumentException">Thrown if the input is malformed.</exception>
            public static double ReadDouble(string msg)
            {
                Console.Write($"{msg}: ");
                string str = Console.ReadLine();
                if (!double.TryParse(str, out double result))
                {
                    throw new ArgumentException($"Cannot read double from <{str}>.");
                }

                return result;
            }

            /// <summary>
            /// Reads an string,
            /// </summary>
            /// <param name="msg">The description.</param>
            /// <returns>The string input.</returns>
            /// <exception cref="ArgumentException">Thrown if the input is malformed.</exception>
            public static string ReadString(string msg)
            {
                Console.Write($"{msg}: ");
                string str = Console.ReadLine();
                if (str.Length == 0)
                {
                    throw new ArgumentException($"Entered string is empty.");
                }
                return str;
            }

            /// <summary>
            /// Reads an char.
            /// </summary>
            /// <param name="msg">The description.</param>
            /// <returns>The char input.</returns>
            /// <exception cref="ArgumentException">Thrown if the input is malformed.</exception>
            public static char ReadChar(string msg)
            {
                Console.Write($"{msg}: ");
                string str = Console.ReadLine();
                if (!char.TryParse(str, out char result))
                {
                    throw new ArgumentException($"Cannot read char from <{str}>.");
                }

                return result;
            }

        }
    }
}

