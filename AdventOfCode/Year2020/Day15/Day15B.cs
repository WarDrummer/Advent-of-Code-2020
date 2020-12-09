using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day15
{
    public class Day15B : ProblemWithInput
    {
        public Day15B() : this(string.Empty) { }
        public Day15B(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData().ToList();
            return "";
        }
    }
}