using System.Linq;
using AdventOfCode.Parsers;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day07
{
    public class Day07A : ProblemWithInput<Day07A>
    {
        public Day07A() { }
        public Day07A(InputParserFactory<Day07A> inputParserFactory) 
            : base(inputParserFactory) { }
        
        public override string Solve()
        {
            var bagRegulations = BagRegulation
                .GetBagRegulations(ParserFactory.CreateMultiLineStringParser().GetData())
                .ToArray();
            
            var regulationLookup = BagRegulation.GetRegulationsLookup(bagRegulations);

            return bagRegulations
                .Count(r => r.CanContainBag("shiny gold", regulationLookup))
                .ToString();
        }
    }
}