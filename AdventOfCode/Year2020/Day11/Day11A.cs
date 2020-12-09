using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day11
{
    public class Day11A : ProblemWithInput
    {
        public Day11A() : this(string.Empty) { }
        public Day11A(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData();
            return "";
        }
    }
}