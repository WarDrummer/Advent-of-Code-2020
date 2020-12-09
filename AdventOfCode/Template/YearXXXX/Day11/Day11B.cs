using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Template.YearXXXX.Day11
{
    public class Day11B : ProblemWithInput
    {
        public Day11B() : this(string.Empty) { }
        public Day11B(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData().ToList();
            return "";
        }
    }
}