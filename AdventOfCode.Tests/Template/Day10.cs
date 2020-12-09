using AdventOfCode.Year2020.Day10;
using Xunit;

namespace AdventOfCode.Tests.Template
{
    public class Day10
    {
        [Theory]
        [InlineData("day10.example01.in", "")]
        [InlineData("day10.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day10A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day10.example01.in", "")]
        [InlineData("day10.in", "")]
        public void PartB(string file, string expected)
        {
            var problem = new Day10B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}