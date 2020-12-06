
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day22B : IProblem
    {
        private readonly ParserType _parser;

        public Day22B() : this(new ParserType("day22.in"))
        {
        }

        private Day22B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}