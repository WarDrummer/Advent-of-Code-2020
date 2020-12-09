using AdventOfCode.Year2020.Day14;
using Xunit;

namespace AdventOfCode.Tests.Template
{
    public class Day14
    {
        [Theory]
        [InlineData("day14.example01.in", "")]
        [InlineData("day14.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day14A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day14.example01.in", "")]
        [InlineData("day14.in", "")]
        public void PartB(string file, string expected)
        {
            var problem = new Day14B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}