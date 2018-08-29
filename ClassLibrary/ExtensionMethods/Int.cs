using System;

namespace ClassLibrary.ExtensionMethods
{
    public static class Int
    {
        public static long Factorial(this int i)
        {
            if (i < 0) throw new ArgumentOutOfRangeException(nameof(i));

            if (i == 0 || i == 1) return 1;

            return i * Factorial(i - 1);
        }

        /// <summary>
        /// Returns the number passed with its digits in reverse order. Example: int 123 returns int 321
        /// </summary>
        public static int ReverseNumber(this int i)
        {
            int output = 0;

            while (i > 0)
            {
                output *= 10;
                output += i % 10;
                i      /= 10;
            }
            
            return output;
        }

        public static int SumSquares(this int x, int y)
        {
            int sumSquares = 0;
            for (int i = x; i <= y; i++)
            {
                sumSquares += i * i;
            }
            return sumSquares;
        }

        public static int SquareSum(this int x, int y)
        {
            int squareSum = 0;
            for (int i = x; i <= y; i++)
            {
                squareSum += i;
            }
            return squareSum * squareSum;
        }
    }
}