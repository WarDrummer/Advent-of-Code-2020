using AdventOfCode.Year2020.Day13;
using Xunit;

namespace AdventOfCode.Tests.Template
{
    public class Day13
    {
        [Theory]
        [InlineData("day13.example01.in", "")]
        [InlineData("day13.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day13A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day13.example01.in", "")]
        [InlineData("day13.in", "")]
        public void PartB(string file, string expected)
        {
            var problem = new Day13B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}