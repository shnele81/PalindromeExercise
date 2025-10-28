using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("radar", true)]
        [InlineData("kayak", true)]
        [InlineData("false", false)]
        [InlineData("together", false)]
        
        public void Test1(string word, bool expected)
        {
            var tester = new WordSmith();
            var actual = tester.IsPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
