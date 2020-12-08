using AdventOfCode.Year2020.Day06;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day06
    {
        [Theory]
        [InlineData("day06.example01.in", "11")]
        [InlineData("day06.in", "7283")]
        public void PartA(string file, string expected)
        {
            var problem = new Day06A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day06.example01.in", "6")]
        [InlineData("day06.in", "3520")]
        public void PartB(string file, string expected)
        {
            var problem = new Day06B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}