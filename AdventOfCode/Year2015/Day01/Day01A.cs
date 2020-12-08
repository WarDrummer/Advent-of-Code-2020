using AdventOfCode.Problem;

namespace AdventOfCode.Year2015.Day01
{
    public class Day01A : ProblemWithInput
    {
        public Day01A() : this(string.Empty) { }
        public Day01A(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateSingleLineStringParser().GetData();
            var floor = 0;
            foreach (var c in data)
            {
                if (c == ')')
                {
                    floor--;
                } 
                else if (c == '(')
                {
                    floor++;
                }
            }
            return floor.ToString();
        }
    }
}