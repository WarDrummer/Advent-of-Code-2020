using AdventOfCode.Year2020.Day20;
using Xunit;

namespace AdventOfCode.Tests.Template
{
    public class Day20
    {
        [Theory]
        [InlineData("day20.example01.in", "")]
        [InlineData("day20.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day20A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day20.example01.in", "")]
        [InlineData("day20.in", "")]
        public void PartB(string file, string expected)
        {
            var problem = new Day20B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}