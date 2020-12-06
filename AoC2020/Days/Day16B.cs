
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day16B : IProblem
    {
        private readonly ParserType _parser;

        public Day16B() : this(new ParserType("day16.in"))
        {
        }

        private Day16B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}