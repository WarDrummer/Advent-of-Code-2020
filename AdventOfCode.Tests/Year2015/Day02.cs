using AdventOfCode.Year2015.Day02;
using Xunit;

namespace AdventOfCode.Tests.Year2015
{
    public class Day02
    {
        [Theory]
        [InlineData("day02.example01.in", "58")]
        [InlineData("day02.example02.in", "43")]
        [InlineData("day02.in", "1586300")]
        public void PartA(string file, string expected)
        {
            var problem = new Day02A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("day02.example01.in", "34")]
        [InlineData("day02.example02.in", "14")]
        [InlineData("day02.in", "3737498")]
        public void PartB(string file, string expected)
        {
            var problem = new Day02B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}