using AdventOfCode.Year2020.Day19;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day19
    {
        [Theory]
        [InlineData("day19.example01.in", "")]
        [InlineData("day19.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day19A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day19.example01.in", "")]
        [InlineData("day19.in", "")]
        public void PartB(string file, string expected)
        {
            var problem = new Day19B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}