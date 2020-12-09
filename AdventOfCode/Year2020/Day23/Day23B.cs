using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day23
{
    public class Day23B : ProblemWithInput
    {
        public Day23B() : this(string.Empty) { }
        public Day23B(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData().ToList();
            return "";
        }
    }
}