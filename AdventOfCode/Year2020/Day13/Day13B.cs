using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day13
{
    public class Day13B : ProblemWithInput
    {
        public Day13B() : this(string.Empty) { }
        public Day13B(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData().ToList();
            return "";
        }
    }
}