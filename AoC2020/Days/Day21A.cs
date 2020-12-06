
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day21A : IProblem
    {
        private readonly ParserType _parser;

        public Day21A() : this(new ParserType("day21.in"))
        {
        }

        private Day21A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}