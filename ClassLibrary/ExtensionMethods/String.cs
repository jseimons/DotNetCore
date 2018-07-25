using System;
using System.Text;

namespace ClassLibrary.ExtensionMethods
{
    public static class String
    {
        public static bool IsPalindrome(this string str)
        {
            if (str is null)
                throw new ArgumentNullException(nameof(str));
            if (str.Length == 0)
                return false;

            // Naive implementation
            // TODO: Optimize
            var sb = new StringBuilder(str.Length);
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return str == sb.ToString();
        }
    }
}