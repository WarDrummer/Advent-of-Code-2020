using AdventOfCode.Year2020.Day17;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day17
    {
        [Theory]
        [InlineData("day17.example01.in", "")]
        [InlineData("day17.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day17A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day17.example01.in", "")]
        [InlineData("day17.in", "")]
        public void PartB(string file, string expected)
        {
            var problem = new Day17B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}