using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day05
{
    public class Day05A : ProblemWithInput
    {
        public Day05A() : this(string.Empty) { }
        public Day05A(string path) : base(path) { }
        
        public override string Solve()
        {
            var passes = GetBoardingPasses();
            return passes.Max(p => p.SeatId).ToString();
        }

        protected IEnumerable<BoardingPass> GetBoardingPasses()
        {
            return ParserFactory.CreateMultiLineStringParser()
                .GetData()
                .Select(seat => new BoardingPass(seat));
        }
    }
}