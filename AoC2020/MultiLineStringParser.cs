using System.Collections.Generic;

namespace AoC2020
{
    public class MultiLineStringParser : InputParser<IEnumerable<string>>
    {
        public MultiLineStringParser(string inputFile) : base(inputFile) { }

        public override IEnumerable<string> GetData()
        {
            return GetInput();
        }
    }
}