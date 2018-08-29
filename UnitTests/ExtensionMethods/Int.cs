using System;
using Xunit;

using ClassLibrary.ExtensionMethods;

namespace UnitTests.ExtensionMethods
{
    public static class Int
    {
        [Fact]
        public static void Factorial()
        {
            const int testCase1Input            = 0;
            const long testCase1ExpectedResult  = 1;

            Assert.True( 
                testCase1Input.Factorial() == testCase1ExpectedResult);

            const int testCase2Input            = 1;
            const long testCase2ExpectedResult  = 1;

            Assert.True( 
                testCase2Input.Factorial() == testCase2ExpectedResult);
            
            const int testCase3Input            = 6;
            const long testCase3ExpectedResult  = 720;

            Assert.True( 
                testCase3Input.Factorial() == testCase3ExpectedResult);

            const int testCase4Input            = 10;
            const long testCase4ExpectedResult  = 3_628_800;

            Assert.True( 
                testCase4Input.Factorial() == testCase4ExpectedResult);
        }

        [Fact]
        public static void ReverseNumber()
        {
            // A palindromic number reads the same both ways. 
            // ... The largest palindrome made from the product of 
            // ... two 2-digit numbers is 9009 = 91 × 99.

            const int minValueTwoDigits      = 10;
            const int maxValueTwoDigits      = 99;
            const int expectedValueTwoDigits = 9009;

            int largestPalindrome = 0;
            for (int i = minValueTwoDigits; i <= maxValueTwoDigits; i++)
            {
                for (int j = minValueTwoDigits; j <= maxValueTwoDigits; j++)
                {
                    int product = i * j;
                    if (product.ReverseNumber() == product)
                    {
                        if (product > largestPalindrome)
                            largestPalindrome = product; 
                    }
                }
            }

            Assert.True(largestPalindrome == expectedValueTwoDigits);
        }
    }
}