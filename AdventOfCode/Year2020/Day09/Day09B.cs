using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day09
{
    public class Day09B : ProblemWithInput
    {
        private readonly long _invalidNumber;
        public Day09B() : this(string.Empty, null) { }
        public Day09B(string path, long? invalidNumber) : base(path)
        {
            _invalidNumber = invalidNumber ?? 1398413738;
        }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser()
                .GetData()
                .Select(long.Parse)
                .ToList();
            
            var q = new Queue<long>();
            foreach (var number in data)
            {
                q.Enqueue(number);
                if (q.Count <= 1)
                {
                    continue;
                }

                var sum = q.Sum();
                if (sum == _invalidNumber)
                {
                    return (q.Min() + q.Max()).ToString();
                }
                    
                while (sum > _invalidNumber)
                {
                    q.Dequeue();
                    sum = q.Sum();
                    if (sum == _invalidNumber)
                    {
                        return (q.Min() + q.Max()).ToString();
                    }
                }
            }
            
            return "No Solution Found";
        }
    }
}