using AdventOfCode.Year2020.Day21;
using Xunit;

namespace AdventOfCode.Tests.Template
{
    public class Day21
    {
        [Theory]
        [InlineData("day21.example01.in", "")]
        [InlineData("day21.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day21A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day21.example01.in", "")]
        [InlineData("day21.in", "")]
        public void PartB(string file, string expected)
        {
            var problem = new Day21B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}