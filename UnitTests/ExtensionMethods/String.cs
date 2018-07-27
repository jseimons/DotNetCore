using System;
using Xunit;

using ClassLibrary.ExtensionMethods;

namespace UnitTests.ExtensionMethods
{
    public static class String
    {
        [Fact]
        public static void IsPalindrome()
        {
            const string isTrue1 = "abba";
            const string isTrue2 = "abaaba";
            
            Assert.True(isTrue1.IsPalindrome());
            Assert.True(isTrue2.IsPalindrome());

            const string isFalse1 = "";
            
            Assert.False(isFalse1.IsPalindrome());
        }
    }
}