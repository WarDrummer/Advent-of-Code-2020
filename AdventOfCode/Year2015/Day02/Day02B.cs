using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2015.Day02
{
    public class Day02B : ProblemWithInput
    {
        public Day02B() : this(string.Empty) { }
        public Day02B(string path) : base(path) { }
        
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