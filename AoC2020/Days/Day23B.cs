
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day23B : IProblem
    {
        private readonly ParserType _parser;

        public Day23B() : this(new ParserType("day23.in"))
        {
        }

        private Day23B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}