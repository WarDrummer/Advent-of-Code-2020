using AdventOfCode.Problem;

namespace AdventOfCode.Template.YearXXXX.Day12
{
    public class Day12A : ProblemWithInput
    {
        public Day12A() : this(string.Empty) { }
        public Day12A(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData();
            return "";
        }
    }
}