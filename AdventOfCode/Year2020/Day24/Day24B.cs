using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day24
{
    public class Day24B : ProblemWithInput
    {
        public Day24B() : this(string.Empty) { }
        public Day24B(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData().ToList();
            return "";
        }
    }
}