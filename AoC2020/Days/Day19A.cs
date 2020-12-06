
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day19A : IProblem
    {
        private readonly ParserType _parser;

        public Day19A() : this(new ParserType("day19.in"))
        {
        }

        private Day19A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}