using AdventOfCode.Year2020.Day22;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day22
    {
        [Theory]
        [InlineData("day22.example01.in", "")]
        [InlineData("day22.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day22A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day22.example01.in", "")]
        [InlineData("day22.in", "")]
        public void PartB(string file, string expected)
        {
            var problem = new Day22B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}