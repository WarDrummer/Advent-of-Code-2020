
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day20B : IProblem
    {
        private readonly ParserType _parser;

        public Day20B() : this(new ParserType("day20.in"))
        {
        }

        private Day20B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}