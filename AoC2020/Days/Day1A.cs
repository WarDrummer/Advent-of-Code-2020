using System.Linq;

namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day1A : IProblem
    {
        protected readonly ParserType _parser;

        public Day1A() : this(new ParserType("day01.in")) { }

        private Day1A(ParserType parser) { _parser = parser; }

        public virtual string Solve()
        {
            var input = _parser
                .GetData()
                .Select(int.Parse)
                .ToArray();

            for (var x = 0; x < input.Length-1; x++)
            {
                for (var y = x+1; y < input.Length; y++)
                {
                    if (input[x] + input[y] == 2020)
                    {
                        return (input[x] * input[y]).ToString();
                    }
                }    
            }

            return "No Match";
        }
    }
}