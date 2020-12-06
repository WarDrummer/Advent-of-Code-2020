using AdventOfCode.Parsers;

namespace AdventOfCode.Problem
{
    public class ProblemWithInput<T> : IProblem
    {
        protected InputParserFactory<T> ParserFactory => new InputParserFactory<T>();
        public virtual string Solve()
        {
            return "Not Solved";
        }
    }
}