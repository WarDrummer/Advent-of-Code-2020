
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day25A : IProblem
    {
        private readonly ParserType _parser;

        public Day25A() : this(new ParserType("day25.in"))
        {
        }

        private Day25A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}