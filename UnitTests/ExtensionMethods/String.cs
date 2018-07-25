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
            
            Assert.Equal(true, isTrue1.IsPalindrome());
            Assert.Equal(true, isTrue2.IsPalindrome());

            const string isFalse1 = "";
            
            Assert.Equal(false, isFalse1.IsPalindrome());
        }
    }
}