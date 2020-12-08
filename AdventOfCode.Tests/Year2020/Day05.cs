using AdventOfCode.Year2020.Day05;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day05
    {
        [Theory]
        [InlineData("day05.example01.in", "820")]
        [InlineData("day05.in", "922")]
        public void PartA(string file, string expected)
        {
            var problem = new Day05A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day05.in", "747")]
        public void PartB(string file, string expected)
        {
            var problem = new Day05B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}