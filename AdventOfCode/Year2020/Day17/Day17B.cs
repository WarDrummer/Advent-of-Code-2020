using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day17
{
    public class Day17B : ProblemWithInput
    {
        public Day17B() : this(string.Empty) { }
        public Day17B(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData().ToList();
            return "";
        }
    }
}