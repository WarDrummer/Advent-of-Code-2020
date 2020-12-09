using AdventOfCode.Year2020.Day25;
using Xunit;

namespace AdventOfCode.Tests.Template
{
    public class Day25
    {
        [Theory]
        [InlineData("day25.example01.in", "")]
        [InlineData("day25.in", "")]
        public void PartA(string file, string expected)
        {
            var problem = new Day25A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}