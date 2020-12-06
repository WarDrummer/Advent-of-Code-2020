
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day23A : IProblem
    {
        private readonly ParserType _parser;

        public Day23A() : this(new ParserType("day23.in"))
        {
        }

        private Day23A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}