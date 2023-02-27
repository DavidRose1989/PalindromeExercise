using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("rotator", true)]
        [InlineData("wow", true)]
        [InlineData("noon", true)]
        [InlineData("deifeid", true)]
        [InlineData("people", false)]
        [InlineData("like", false)]
        [InlineData("usain", false)]
        public void PTest(string word, bool expected)
        {

            //Arrange 

            var tester = new WordSmith();

            //Act 
            var actual = WordSmith.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
