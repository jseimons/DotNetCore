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

            Assert.Equal(true, 
                testCase1Input.Factorial() == testCase1ExpectedResult);

            const int testCase2Input            = 1;
            const long testCase2ExpectedResult  = 1;

            Assert.Equal(true, 
                testCase2Input.Factorial() == testCase2ExpectedResult);
            
            const int testCase3Input            = 6;
            const long testCase3ExpectedResult  = 720;

            Assert.Equal(true, 
                testCase3Input.Factorial() == testCase3ExpectedResult);

            const int testCase4Input            = 10;
            const long testCase4ExpectedResult  = 3_628_800;

            Assert.Equal(true, 
                testCase4Input.Factorial() == testCase4ExpectedResult);
        }
    }
}