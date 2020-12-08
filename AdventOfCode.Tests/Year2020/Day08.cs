using AdventOfCode.Year2020.Day08;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day08
    {
        [Theory]
        [InlineData("day08.example01.in", "5")]
        [InlineData("day08.in", "1420")]
        public void PartA(string file, string expected)
        {
            var problem = new Day08A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day08.example01.in", "8")]
        [InlineData("day08.in", "1245")]
        public void PartB(string file, string expected)
        {
            var problem = new Day08B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}