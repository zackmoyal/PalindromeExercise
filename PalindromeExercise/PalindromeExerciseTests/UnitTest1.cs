using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("kayak", true)]
        [InlineData("hello", false)]
        [InlineData("Zack", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsAPalindrome(string word, bool expected)
        {
            // Arrange
            var ws = new WordSmith();

            // Act
            var actual = ws.IsAPalindrome(word);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
