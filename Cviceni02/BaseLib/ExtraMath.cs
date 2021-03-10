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
        /// Math library that solves quadratic equations and gets random double fron a range.
        /// </summary>
        public static class ExtraMath
        {
            private static readonly Random Random = new Random();

            /// <summary>
            /// Solve quadratic equation.
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <param name="c"></param>
            /// <returns>
            /// <param name="x1"></param>
            /// <param name="x2"></param>
            /// </returns>
            /// <exception cref="ArgumentException"></exception>
            public static bool SolveQuadraticEquation(double a, double b, double c, out double? x1, out double? x2)
            {
                if (a == 0)
                {
                    throw new ArgumentException($"Argument {nameof(a)} cannot be equal to 0.");
                }

                var d = b * b - 4 * a * c;
                if (d == 0)
                {
                    x1 = -b / (2.0 * a);
                    x2 = x1;
                    return true;
                }
                else if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    return true;
                }

                x1 = null;
                x2 = null;
                return false;
            }

            /// <summary>
            /// Get random double from a range.
            /// </summary>
            /// <param name="min"></param>
            /// <param name="max"></param>
            /// <returns>Double number.</returns>
            /// <exception cref="ArgumentOutOfRangeException"></exception>
            public static double RandomDoubleFromRange(double min, double max)
            {
                if (min > max)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(min)} is greater than {nameof(max)}");
                }

                return Random.NextDouble() * (max - min) + min;
            }
        }
    }
}