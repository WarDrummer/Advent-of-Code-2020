using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day22
{
    public class Day22B : ProblemWithInput
    {
        public Day22B() : this(string.Empty) { }
        public Day22B(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData().ToList();
            return "";
        }
    }
}