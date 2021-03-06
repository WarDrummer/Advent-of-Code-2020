using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day23
{
    public class Day23A : ProblemWithInput
    {
        public Day23A() : this(string.Empty) { }
        public Day23A(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData();
            return "";
        }
    }
}