using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Template.YearXXXX.Day20
{
    public class Day20B : ProblemWithInput
    {
        public Day20B() : this(string.Empty) { }
        public Day20B(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData().ToList();
            return "";
        }
    }
}