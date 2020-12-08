using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day07
{
    public class Day07A : ProblemWithInput
    {
        public Day07A() : this(string.Empty) { }
        public Day07A(string path) : base(path) { }
        
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