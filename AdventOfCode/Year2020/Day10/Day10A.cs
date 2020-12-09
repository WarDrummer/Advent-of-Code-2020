using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day10
{
    public class Day10A : ProblemWithInput
    {
        public Day10A() : this(string.Empty) { }
        public Day10A(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData();
            return "";
        }
    }
}