using AdventOfCode.Year2020.Day15;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day15
    {
        [Theory]
        [InlineData("day15.example01.in", "")]
        [InlineData("day15.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day15A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day15.example01.in", "")]
        [InlineData("day15.in", "")]
        public void PartB(string file, string expected)
        {
            var problem = new Day15B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}