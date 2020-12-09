using AdventOfCode.Problem;

namespace AdventOfCode.Template.YearXXXX.Day20
{
    public class Day20A : ProblemWithInput
    {
        public Day20A() : this(string.Empty) { }
        public Day20A(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData();
            return "";
        }
    }
}