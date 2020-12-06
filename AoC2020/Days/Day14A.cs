
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day14A : IProblem
    {
        private readonly ParserType _parser;

        public Day14A() : this(new ParserType("day14.in"))
        {
        }

        private Day14A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}