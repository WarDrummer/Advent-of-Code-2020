
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day15B : IProblem
    {
        private readonly ParserType _parser;

        public Day15B() : this(new ParserType("day15.in"))
        {
        }

        private Day15B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}