namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day07B : IProblem
    {
        private readonly ParserType _parser;

        public Day07B() : this(new ParserType("day07.in"))
        {
        }

        private Day07B(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            return "Unsolved";
        }
    }
}