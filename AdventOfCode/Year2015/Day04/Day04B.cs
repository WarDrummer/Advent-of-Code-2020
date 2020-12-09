using System.Linq;
using AdventOfCode.Problem;
using AdventOfCode.Utilities;

namespace AdventOfCode.Year2015.Day04
{
    public class Day04B : ProblemWithInput
    {
        public Day04B() : this(string.Empty) { }
        public Day04B(string path) : base(path) { }
        
        public override string Solve()
        {
            var input = ParserFactory.CreateSingleLineStringParser().GetData();
            var number = 0;
            for (;;)
            {
                if (Md5Stringify.GetHexCharacters($"{input}{number}").Take(6).All(c => c == '0'))
                    return number.ToString();
                number++;
            }
        }
    }
}