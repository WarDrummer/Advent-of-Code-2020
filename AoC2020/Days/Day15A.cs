
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day15A : IProblem
    {
        private readonly ParserType _parser;

        public Day15A() : this(new ParserType("day15.in"))
        {
        }

        private Day15A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}