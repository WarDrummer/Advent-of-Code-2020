using AdventOfCode.Problem;

namespace AdventOfCode.Template.YearXXXX.Day24
{
    public class Day24A : ProblemWithInput
    {
        public Day24A() : this(string.Empty) { }
        public Day24A(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData();
            return "";
        }
    }
}