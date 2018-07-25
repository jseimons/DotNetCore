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
    }
}