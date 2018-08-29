using System;
using Xunit;

using ClassLibrary.ExtensionMethods;

namespace UnitTests.ProjectEuler
{
    public static class LargestPalindromeProduct
    {
        [Fact]
        public static void TestExample()
        {
            int smallestNumber = 10;
            int largestNumber  = 99;
            int expectedValue = 9009;

            int LargestPalindromeProduct(int start, int end)
            {
                int largestPalindromeProduct = 0;

                for (int i = start; i <= end; i++)
                {
                    for (int j = start; j <= end; j++)
                    {
                        int product = i * j;
                        if (product.ReverseNumber() == product)
                            if (product > largestPalindromeProduct)
                                largestPalindromeProduct = product; 
                    }
                }

                return largestPalindromeProduct;
            }

            Assert.Equal(expectedValue, LargestPalindromeProduct(smallestNumber, largestNumber));

            smallestNumber = 100;
            largestNumber  = 999;
            expectedValue  = 906609;

            Assert.Equal(expectedValue, LargestPalindromeProduct(smallestNumber, largestNumber));
        }
    }
}