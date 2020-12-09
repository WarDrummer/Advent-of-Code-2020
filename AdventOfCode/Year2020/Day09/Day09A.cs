using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day09
{
    public class Day09A : ProblemWithInput
    {
        public Day09A() : this(string.Empty) { }
        public Day09A(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData();
            return "";
        }
    }
}