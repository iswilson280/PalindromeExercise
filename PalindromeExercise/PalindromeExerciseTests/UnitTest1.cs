using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("hector", false)]

        public void IsPalidromeTest(string someWord, bool expected)
        {
            //Arrange - prep
            var instance = new WordSmith();

            //Act- call method
            var actual = instance.IsPalidrome(someWord);
            //Assert- compare
            Assert.Equal(expected, actual);
        }

    }
}
