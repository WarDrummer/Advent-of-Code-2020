using AdventOfCode.Parsers;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day07
{
    public class Day07B : ProblemWithInput<Day07B>
    {
        public Day07B() { }
        public Day07B(InputParserFactory<Day07B> inputParserFactory) 
            : base(inputParserFactory) { }
        
        public override string Solve()
        {
            var regulationLookup = BagRegulation.GetRegulationsLookup(ParserFactory.CreateMultiLineStringParser().GetData());
            return regulationLookup["shiny gold"].ContainedBagCount(regulationLookup).ToString();
        }
    }
}