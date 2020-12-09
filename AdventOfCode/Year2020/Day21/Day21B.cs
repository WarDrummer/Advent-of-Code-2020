using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day21
{
    public class Day21B : ProblemWithInput
    {
        public Day21B() : this(string.Empty) { }
        public Day21B(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData().ToList();
            return "";
        }
    }
}