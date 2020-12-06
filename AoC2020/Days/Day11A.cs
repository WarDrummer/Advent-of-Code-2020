
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day11A : IProblem
    {
        private readonly ParserType _parser;

        public Day11A() : this(new ParserType("day11.in"))
        {
        }

        private Day11A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}