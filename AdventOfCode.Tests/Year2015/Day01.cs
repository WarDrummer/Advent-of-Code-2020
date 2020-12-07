using AdventOfCode.Tests.Parsers;
using AdventOfCode.Year2015.Day01;
using Xunit;

namespace AdventOfCode.Tests.Year2015
{
    public class Day01
    {
        [Theory]
        [InlineData("day01.example01.in", "0")]
        [InlineData("day01.example02.in", "0")]
        [InlineData("day01.example03.in", "3")]
        [InlineData("day01.example04.in", "3")]
        [InlineData("day01.example05.in", "3")]
        [InlineData("day01.example06.in", "-1")]
        [InlineData("day01.example07.in", "-1")]
        [InlineData("day01.example08.in", "-3")]
        [InlineData("day01.example09.in", "-3")]
        public void PartA_Example(string file, string expected)
        {
            var problem = new Day01A(new ExampleInputParserFactory<Day01A>(file));
            var result = problem.Solve();
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void PartA()
        {
            var problem = new Day01A();
            var result = problem.Solve();
            Assert.Equal("280", result);
        }
        
        [Theory]
        [InlineData("day01.example10.in", "1")]
        [InlineData("day01.example11.in", "5")]
        public void PartB_Example(string file, string expected)
        {
            var problem = new Day01B(new ExampleInputParserFactory<Day01B>(file));
            var result = problem.Solve();
            Assert.Equal(expected, result);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void PartB()
        {
            var problem = new Day01B();
            var result = problem.Solve();
            Assert.Equal("1797", result);
        }
    }
}