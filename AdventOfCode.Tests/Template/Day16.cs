using AdventOfCode.Year2020.Day16;
using Xunit;

namespace AdventOfCode.Tests.Template
{
    public class Day16
    {
        [Theory]
        [InlineData("day16.example01.in", "")]
        [InlineData("day16.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day16A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day16.example01.in", "")]
        [InlineData("day16.in", "")]
        public void PartB(string file, string expected)
        {
            var problem = new Day16B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}