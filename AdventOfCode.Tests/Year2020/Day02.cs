using AdventOfCode.Year2020.Day02;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day02
    {
        [Theory]
        [InlineData("day02.example01.in", "2")]
        [InlineData("day02.in", "447")]
        public void PartA(string file, string expected)
        {
            var problem = new Day02A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day02.example01.in", "1")]
        [InlineData("day02.in", "249")]
        public void PartB(string file, string expected)
        {
            var problem = new Day02B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}