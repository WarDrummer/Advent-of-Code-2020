
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day11B : IProblem
    {
        private readonly ParserType _parser;

        public Day11B() : this(new ParserType("day11.in"))
        {
        }

        private Day11B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}