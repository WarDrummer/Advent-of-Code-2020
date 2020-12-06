
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day13B : IProblem
    {
        private readonly ParserType _parser;

        public Day13B() : this(new ParserType("day13.in"))
        {
        }

        private Day13B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}