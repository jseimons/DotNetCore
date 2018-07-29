using System;
using Xunit;

using ClassLibrary.ProjectEuler;

namespace UnitTests.ProjectEuler
{
    public static class SmallestMultiple
    {
        [Fact]
        public static void TestExample()
        {
            const uint min = 1;
            const uint max = 10;
            const long expectedResult = 2_520;

            Assert.True(
                ClassLibrary.ProjectEuler.SmallestMultiple.Get(min, max) == expectedResult);

        }

        [Fact]    
        public static void TestProblem()
        {
            const uint min = 1;
            const uint max = 20;
            const long expectedResult = 23_279_2560;

            Assert.True(
                ClassLibrary.ProjectEuler.SmallestMultiple.Get(min, max) == expectedResult);
        }
    }
}