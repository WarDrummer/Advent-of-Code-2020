using AdventOfCode.Year2020.Day07;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day07
    {
        [Theory]
        [InlineData("day07.example01.in", "4")]
        [InlineData("day07.in", "124")]
        public void PartA(string file, string expected)
        {
            var problem = new Day07A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData("day07.example02.in", "126")]
        [InlineData("day07.in", "34862")]
        public void PartB(string file, string expected)
        {
            var problem = new Day07B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}