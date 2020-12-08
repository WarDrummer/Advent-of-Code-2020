using AdventOfCode.Year2020.Day03;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day03
    {
        [Theory]
        [InlineData("day03.example01.in", "7")]
        [InlineData("day03.in", "262")]
        public void PartA(string file, string expected)
        {
            var problem = new Day03A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day03.example01.in", "336")]
        [InlineData("day03.in", "2698900776")]
        public void PartB(string file, string expected)
        {
            var problem = new Day03B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}