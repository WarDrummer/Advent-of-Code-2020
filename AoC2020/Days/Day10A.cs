
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day10A : IProblem
    {
        private readonly ParserType _parser;

        public Day10A() : this(new ParserType("day10.in"))
        {
        }

        private Day10A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}