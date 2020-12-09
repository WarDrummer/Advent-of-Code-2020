using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day12
{
    public class Day12B : ProblemWithInput
    {
        public Day12B() : this(string.Empty) { }
        public Day12B(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData().ToList();
            return "";
        }
    }
}