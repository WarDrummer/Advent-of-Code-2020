using System.Linq;
using AdventOfCode.Problem;
using AdventOfCode.Utilities;

namespace AdventOfCode.Year2015.Day04
{
    public class Day04A : ProblemWithInput
    {
        public Day04A() : this(string.Empty) { }
        public Day04A(string path) : base(path) { }
        
        public override string Solve()
        {
            var input = ParserFactory.CreateSingleLineStringParser().GetData();
            var number = 0;
            for (;;)
            {
                if (Md5Stringify.GetHexCharacters($"{input}{number}").Take(5).All(c => c == '0'))
                    return number.ToString();
                number++;
            }
        }
    }
}