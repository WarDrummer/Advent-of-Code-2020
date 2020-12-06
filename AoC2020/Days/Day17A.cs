
namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day17A : IProblem
    {
        private readonly ParserType _parser;

        public Day17A() : this(new ParserType("day17.in"))
        {
        }

        private Day17A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}