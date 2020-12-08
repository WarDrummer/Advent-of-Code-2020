using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2015.Day02
{
    public class Day02A : ProblemWithInput
    {
        public Day02A() : this(string.Empty) { }
        public Day02A(string path) : base(path) { }
        
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