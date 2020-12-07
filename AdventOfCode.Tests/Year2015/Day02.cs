using AdventOfCode.Tests.Parsers;
using AdventOfCode.Year2015.Day02;
using Xunit;

namespace AdventOfCode.Tests.Year2015
{
    public class Day02
    {
        [Theory]
        [InlineData("day02.example01.in", "58")]
        [InlineData("day02.example02.in", "43")]
        public void PartA_Example(string file, string expected)
        {
            var problem = new Day02A(new ExampleInputParserFactory<Day02A>(file));
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void PartA()
        {
            var problem = new Day02A();
            var result = problem.Solve();
            Assert.Equal("1586300", result);
        }
        
        [Theory]
        [InlineData("day02.example01.in", "34")]
        [InlineData("day02.example02.in", "14")]
        public void PartB_Example(string file, string expected)
        {
            var problem = new Day02B(new ExampleInputParserFactory<Day02B>(file));
            var result = problem.Solve();
            Assert.Equal(expected, result);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void PartB()
        {
            var problem = new Day02B();
            var result = problem.Solve();
            Assert.Equal("3737498", result);
        }
    }
}