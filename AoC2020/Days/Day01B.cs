using System.Linq;

namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day01B : IProblem
    {
        protected readonly ParserType _parser;

        public Day01B() : this(new ParserType("day01.in")) { }

        private Day01B(ParserType parser) { _parser = parser; }

        public virtual string Solve()
        {
            var input = _parser
                .GetData()
                .Select(int.Parse)
                .ToArray();

            for (var x = 0; x < input.Length-2; x++)
            {
                for (var y = x + 1; y < input.Length; y++)
                {
                    for (var z = y + 1; z < input.Length; z++)
                    {
                        if (input[x] + input[y] + input[z] == 2020)
                        {
                            return (input[x] * input[y] * input[z]).ToString();
                        }
                    }
                }    
            }

            return "No Match";
        }
    }
}