
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day16A : IProblem
    {
        private readonly ParserType _parser;

        public Day16A() : this(new ParserType("day16.in"))
        {
        }

        private Day16A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}