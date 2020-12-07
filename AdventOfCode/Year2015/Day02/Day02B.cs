using System.Linq;
using AdventOfCode.Parsers;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2015.Day02
{
    public class Day02B : ProblemWithInput<Day02B>
    {
        public Day02B() { }
        public Day02B(InputParserFactory<Day02B> inputParserFactory) 
            : base(inputParserFactory) { }
        
        public override string Solve()
        {
            var wrapping = ParserFactory.CreateMultiLineStringParser()
                .GetData()
                .Select(line => new Ribbon(line))
                .ToArray();

            return wrapping.Sum(w => w.RequiredRibbon).ToString();
        }
    }
}