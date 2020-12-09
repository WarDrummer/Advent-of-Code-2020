using AdventOfCode.Year2020.Day24;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day24
    {
        [Theory]
        [InlineData("day24.example01.in", "")]
        [InlineData("day24.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day24A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day24.example01.in", "")]
        [InlineData("day24.in", "")]
        public void PartB(string file, string expected)
        {
            var problem = new Day24B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}