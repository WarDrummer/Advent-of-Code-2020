using AdventOfCode.Problem;

namespace AdventOfCode.Year2015.Day01
{
    public class Day01B : ProblemWithInput
    {
        public Day01B() : this(string.Empty) { }
        public Day01B(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateSingleLineStringParser().GetData();
            var position = 1;
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

                if (floor == -1)
                {
                    return position.ToString();
                }

                position++;
            }
            return "Error";
        }
    }
}