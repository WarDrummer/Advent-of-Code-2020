using AdventOfCode.Year2020.Day09;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day09
    {
        [Theory]
        [InlineData("day09.example01.in", 5, "127")]
        [InlineData("day09.in", 25, "1398413738")]
        public void PartA(string file, int preambleSize, string expected)
        {
            var problem = new Day09A(file, new XmasValidator(preambleSize));
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day09.example01.in", 127, "62")]
        [InlineData("day09.in", 1398413738, "169521051")]
        public void PartB(string file, long invalidNumber, string expected)
        {
            var problem = new Day09B(file, invalidNumber);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}