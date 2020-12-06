
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day09A : IProblem
    {
        private readonly ParserType _parser;

        public Day09A() : this(new ParserType("day09.in"))
        {
        }

        private Day09A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}