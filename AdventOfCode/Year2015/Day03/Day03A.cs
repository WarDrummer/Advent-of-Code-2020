using System.Collections.Generic;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2015.Day03
{
    public class Day03A : ProblemWithInput
    {
        public Day03A() : this(string.Empty) { }
        public Day03A(string path) : base(path) { }
        
        public override string Solve()
        {
            var directions = ParserFactory.CreateSingleLineStringParser().GetData();
            var visited = new HashSet<string>();
            var tracker = new DeliveryTracker(visited);
            foreach (var direction in directions)
            {
                tracker.Move(direction);
            }
            return visited.Count.ToString();
        }
    }
}