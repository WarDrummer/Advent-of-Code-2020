
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day24B : IProblem
    {
        private readonly ParserType _parser;

        public Day24B() : this(new ParserType("day24.in"))
        {
        }

        private Day24B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}