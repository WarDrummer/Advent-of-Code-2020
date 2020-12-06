namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day08B : IProblem
    {
        private readonly ParserType _parser;

        public Day08B() : this(new ParserType("day08.in"))
        {
        }

        private Day08B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}