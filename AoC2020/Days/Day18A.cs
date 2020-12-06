
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day18A : IProblem
    {
        private readonly ParserType _parser;

        public Day18A() : this(new ParserType("day18.in"))
        {
        }

        private Day18A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}