using System.Linq;
using AdventOfCode.Parsers;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2015.Day02
{
    public class Day02A : ProblemWithInput<Day02A>
    {
        public Day02A() { }
        public Day02A(InputParserFactory<Day02A> inputParserFactory) 
            : base(inputParserFactory) { }
        
        public override string Solve()
        {
            var wrapping = ParserFactory.CreateMultiLineStringParser()
                .GetData()
                .Select(line => new PresentWrapping(line))
                .ToArray();

            return wrapping.Sum(w => w.RequiredPaper).ToString();
        }
    }
}