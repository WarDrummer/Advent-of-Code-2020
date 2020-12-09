using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day18
{
    public class Day18B : ProblemWithInput
    {
        public Day18B() : this(string.Empty) { }
        public Day18B(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData().ToList();
            return "";
        }
    }
}