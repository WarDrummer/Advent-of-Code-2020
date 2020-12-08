using AdventOfCode.Year2020.Day01;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day01
    {
        [Theory]
        [InlineData("day01.example01.in", "514579")]
        [InlineData("day01.in", "910539")]
        public void PartA(string file, string expected)
        {
            var problem = new Day01A(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("day01.example01.in", "241861950")]
        [InlineData("day01.in", "116724144")]
        public void PartB(string file, string expected)
        {
            var problem = new Day01B(file);
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
    }
}