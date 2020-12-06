
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day08A : IProblem
    {
        private readonly ParserType _parser;

        public Day08A() : this(new ParserType("day08.in"))
        {
        }

        private Day08A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}