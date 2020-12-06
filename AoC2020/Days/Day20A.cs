
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day20A : IProblem
    {
        private readonly ParserType _parser;

        public Day20A() : this(new ParserType("day20.in"))
        {
        }

        private Day20A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}