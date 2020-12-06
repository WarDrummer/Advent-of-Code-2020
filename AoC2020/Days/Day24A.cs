
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day24A : IProblem
    {
        private readonly ParserType _parser;

        public Day24A() : this(new ParserType("day24.in"))
        {
        }

        private Day24A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}