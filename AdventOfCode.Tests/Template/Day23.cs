using AdventOfCode.Year2020.Day23;
using Xunit;

namespace AdventOfCode.Tests.Template
{
    public class Day23
    {
        [Theory]
        [InlineData("day23.example01.in", "")]
        [InlineData("day23.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day23A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day23.example01.in", "")]
        [InlineData("day23.in", "")]
        public void PartB(string file, string expected)
        {
            var problem = new Day23B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}