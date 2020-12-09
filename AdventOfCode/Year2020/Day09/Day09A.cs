using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day09
{
    public class Day09A : ProblemWithInput
    {
        private readonly XmasValidator _validator;
        public Day09A() : this(string.Empty, null) { }

        public Day09A(string path, XmasValidator validator) : base(path)
        {
            _validator = validator ?? new XmasValidator();
        }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser()
                .GetData()
                .Select(long.Parse)
                .ToList();
            
            return _validator.FindFirstFailure(data).ToString();
        }
    }
}