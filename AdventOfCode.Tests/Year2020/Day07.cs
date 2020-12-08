using AdventOfCode.Tests.Parsers;
using AdventOfCode.Year2020.Day07;
using Xunit;

namespace AdventOfCode.Tests.Year2020
{
    public class Day07
    {
        [Fact]
        public void PartA_Example()
        {
            var problem = new Day07A(new ExampleInputParserFactory<Day07A>("day07.example01.in"));
            var result = problem.Solve();
            Assert.Equal("4", result);
        }
        
        [Fact]
        public void PartA()
        {
            var problem = new Day07A();
            var result = problem.Solve();
            Assert.Equal("124", result);
        }
        
        [Fact]
        public void PartB_Example()
        {
            var problem = new Day07B(new ExampleInputParserFactory<Day07B>("day07.example02.in"));
            var result = problem.Solve();
            Assert.Equal("126", result);
        }
        
        [Fact]
        public void PartB()
        {
            var problem = new Day07B();
            var result = problem.Solve();
            Assert.Equal("34862", result);
        }
    }
}