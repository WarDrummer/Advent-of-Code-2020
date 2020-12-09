using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day22
{
    public class Day22A : ProblemWithInput
    {
        public Day22A() : this(string.Empty) { }
        public Day22A(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData();
            return "";
        }
    }
}