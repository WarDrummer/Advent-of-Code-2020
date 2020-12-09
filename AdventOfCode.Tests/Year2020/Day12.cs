using AdventOfCode.Year2020.Day12;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day12
    {
        [Theory]
        [InlineData("day12.example01.in", "")]
        [InlineData("day12.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day12A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day12.example01.in", "")]
        [InlineData("day12.in", "")]
        public void PartB(string file, string expected)
        {
            var problem = new Day12B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}