using AdventOfCode.Year2020.Day18;
using Xunit;

namespace AdventOfCode.Tests.Template
{
    public class Day18
    {
        [Theory]
        [InlineData("day18.example01.in", "")]
        [InlineData("day18.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day18A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day18.example01.in", "")]
        [InlineData("day18.in", "")]
        public void PartB(string file, string expected)
        {
            var problem = new Day18B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}