using AdventOfCode.Problem;

namespace AdventOfCode.Template.YearXXXX.Day25
{
    public class Day25A : ProblemWithInput
    {
        public Day25A() : this(string.Empty) { }
        public Day25A(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData();
            return "";
        }
    }
}