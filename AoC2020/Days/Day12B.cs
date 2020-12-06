
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day12B : IProblem
    {
        private readonly ParserType _parser;

        public Day12B() : this(new ParserType("day12.in"))
        {
        }

        private Day12B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}