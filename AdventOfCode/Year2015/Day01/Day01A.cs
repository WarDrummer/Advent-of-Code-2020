using AdventOfCode.Parsers;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2015.Day01
{
    public class Day01A : ProblemWithInput<Day01A>
    {
        public Day01A() { }
        public Day01A(InputParserFactory<Day01A> inputParserFactory) 
            : base(inputParserFactory) { }
        
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