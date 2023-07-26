using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("hector", false)]

        public static void IsAPalindrome_ShouldReturnCorrectResult(string input, bool expectedResult)
        {
            // Arrange & Act
            bool result = PalidromeChecker.IsAPalindrome(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }

    }
}
