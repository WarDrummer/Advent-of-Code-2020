
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day14B : IProblem
    {
        private readonly ParserType _parser;

        public Day14B() : this(new ParserType("day14.in"))
        {
        }

        private Day14B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}