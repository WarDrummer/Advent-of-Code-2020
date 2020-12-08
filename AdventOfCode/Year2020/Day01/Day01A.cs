using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day01
{
    public class Day01A : ProblemWithInput
    {
        public Day01A() : this(string.Empty) { }
        public Day01A(string path) : base(path) { }
        
        public override string Solve()
        {
            var input = ParserFactory.CreateMultiLineIntParser()
                .GetData()
                .ToArray();

            for (var x = 0; x < input.Length-1; x++)
            {
                for (var y = x+1; y < input.Length; y++)
                {
                    if (input[x] + input[y] == 2020)
                    {
                        return (input[x] * input[y]).ToString();
                    }
                }    
            }

            return "No Match";
        }
    }
}