
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day19B : IProblem
    {
        private readonly ParserType _parser;

        public Day19B() : this(new ParserType("day19.in"))
        {
        }

        private Day19B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}