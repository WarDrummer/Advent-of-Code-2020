using AdventOfCode.Year2020.Day11;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day11
    {
        [Theory]
        [InlineData("day11.example01.in", "")]
        [InlineData("day11.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day11A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day11.example01.in", "")]
        [InlineData("day11.in", "")]
        public void PartB(string file, string expected)
        {
            var problem = new Day11B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}