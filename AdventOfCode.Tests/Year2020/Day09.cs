using AdventOfCode.Year2020.Day09;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day09
    {
        [Theory]
        [InlineData("day09.example01.in", "")]
        [InlineData("day09.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day09A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day09.example01.in", "")]
        [InlineData("day09.in", "")]
        public void PartB(string file, string expected)
        {
            var problem = new Day09B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}