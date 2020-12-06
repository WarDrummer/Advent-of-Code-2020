
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day22A : IProblem
    {
        private readonly ParserType _parser;

        public Day22A() : this(new ParserType("day22.in"))
        {
        }

        private Day22A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}