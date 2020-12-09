using AdventOfCode.Problem;

namespace AdventOfCode.Template.YearXXXX.Day21
{
    public class Day21A : ProblemWithInput
    {
        public Day21A() : this(string.Empty) { }
        public Day21A(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData();
            return "";
        }
    }
}