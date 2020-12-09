using System.Collections.Generic;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2015.Day03
{
    public class Day03B : ProblemWithInput
    {
        public Day03B() : this(string.Empty) { }
        public Day03B(string path) : base(path) { }
        
        public override string Solve()
        {
            var directions = ParserFactory.CreateSingleLineStringParser().GetData();
            var visited = new HashSet<string>();
            var trackers = new[]
            {
                new DeliveryTracker(visited),
                new DeliveryTracker(visited)
            };

            var tracker = 0;
            foreach (var direction in directions)
            {
                trackers[tracker%2].Move(direction);
                tracker++;
            }
            
            return visited.Count.ToString();
        }
    }
}