using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Parsers
{
    public class MultiLineIntParser : InputParser<IEnumerable<int>>
    {
        public MultiLineIntParser(string filePath) : base(filePath) { }

        public override IEnumerable<int> GetData()
        {
            return GetInput().Select(int.Parse);
        }
    }
}