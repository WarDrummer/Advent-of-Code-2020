
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day10B : IProblem
    {
        private readonly ParserType _parser;

        public Day10B() : this(new ParserType("day08.in"))
        {
        }

        private Day10B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}