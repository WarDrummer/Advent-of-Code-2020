
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day12A : IProblem
    {
        private readonly ParserType _parser;

        public Day12A() : this(new ParserType("day12.in"))
        {
        }

        private Day12A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}