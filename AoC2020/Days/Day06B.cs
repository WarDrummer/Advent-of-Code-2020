using System.Linq;

namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day06B : Day06A
    {
        public override string Solve()
        {
            var responses = GetGroupResponses();
            var consensusCounts = responses.Select(r => r.GetConsensusCount()); 
            return consensusCounts.Sum().ToString();
        }
    }
}