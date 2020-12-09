using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day19
{
    public class Day19A : ProblemWithInput
    {
        public Day19A() : this(string.Empty) { }
        public Day19A(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData();
            return "";
        }
    }
}