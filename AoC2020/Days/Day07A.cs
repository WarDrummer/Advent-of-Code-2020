namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day07A : IProblem
    {
        private readonly ParserType _parser;

        public Day07A() : this(new ParserType("day07.in"))
        {
        }

        private Day07A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}