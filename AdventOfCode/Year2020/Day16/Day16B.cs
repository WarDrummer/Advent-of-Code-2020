using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day16
{
    public class Day16B : ProblemWithInput
    {
        public Day16B() : this(string.Empty) { }
        public Day16B(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData().ToList();
            return "";
        }
    }
}