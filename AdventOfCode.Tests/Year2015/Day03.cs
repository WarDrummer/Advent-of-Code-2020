using AdventOfCode.Year2015.Day03;
using Xunit;

namespace AdventOfCode.Tests.Year2015
{
    public class Day03
    {
        [Theory]
        [InlineData("day03.example01.in", "2")]
        [InlineData("day03.example02.in", "4")]
        [InlineData("day03.example03.in", "2")]
        [InlineData("day03.in", "2081")]
        public void PartA(string file, string expected)
        {
            var problem = new Day03A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("day03.example04.in", "3")]
        [InlineData("day03.example02.in", "3")]
        [InlineData("day03.example03.in", "11")]
        [InlineData("day03.in", "2341")]
        public void PartB(string file, string expected)
        {
            var problem = new Day03B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}