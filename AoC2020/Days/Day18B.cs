
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day18B : IProblem
    {
        private readonly ParserType _parser;

        public Day18B() : this(new ParserType("day18.in"))
        {
        }

        private Day18B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}