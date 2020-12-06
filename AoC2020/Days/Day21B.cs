
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day21B : IProblem
    {
        private readonly ParserType _parser;

        public Day21B() : this(new ParserType("day21.in"))
        {
        }

        private Day21B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}