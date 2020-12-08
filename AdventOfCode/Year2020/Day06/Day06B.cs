using System.Linq;

namespace AdventOfCode.Year2020.Day06
{
    public class Day06B : Day06A
    {
        public Day06B() : this(string.Empty) { }
        public Day06B(string path) : base(path) { }
        
        public override string Solve()
        {
            var responses = GetGroupResponses();
            var consensusCounts = responses.Select(r => r.GetConsensusCount()); 
            return consensusCounts.Sum().ToString();
        }
    }
}