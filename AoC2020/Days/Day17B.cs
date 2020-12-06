
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day17B : IProblem
    {
        private readonly ParserType _parser;

        public Day17B() : this(new ParserType("day17.in"))
        {
        }

        private Day17B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}