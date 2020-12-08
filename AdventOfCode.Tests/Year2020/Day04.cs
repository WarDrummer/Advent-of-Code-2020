using AdventOfCode.Year2020.Day04;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day04
    {
        [Theory]
        [InlineData("day04.example01.in", "2")]
        [InlineData("day04.in", "170")]
        public void PartA(string file, string expected)
        {
            var problem = new Day04A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day04.example02.in", "0")]
        [InlineData("day04.example03.in", "4")]
        [InlineData("day04.in", "103")]
        public void PartB(string file, string expected)
        {
            var problem = new Day04B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}