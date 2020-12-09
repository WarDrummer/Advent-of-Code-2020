using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Template.YearXXXX.Day14
{
    public class Day14B : ProblemWithInput
    {
        public Day14B() : this(string.Empty) { }
        public Day14B(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData().ToList();
            return "";
        }
    }
}