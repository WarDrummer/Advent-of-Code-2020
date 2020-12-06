
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day09B : IProblem
    {
        private readonly ParserType _parser;

        public Day09B() : this(new ParserType("day09.in"))
        {
        }

        private Day09B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}