
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day13A : IProblem
    {
        private readonly ParserType _parser;

        public Day13A() : this(new ParserType("day13.in"))
        {
        }

        private Day13A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}