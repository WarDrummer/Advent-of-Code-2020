using AdventOfCode.Year2015.Day04;
using Xunit;

namespace AdventOfCode.Tests.Year2015
{
    public class Day04
    {
        [Theory]
        [InlineData("day04.example01.in", "609043")]
        [InlineData("day04.example02.in", "1048970")]
        [InlineData("day04.in", "346386")]
        public void PartA(string file, string expected)
        {
            var problem = new Day04A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("day04.in", "9958218")]
        public void PartB(string file, string expected)
        {
            var problem = new Day04B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}