using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day07
{
    public class Day07B : ProblemWithInput
    {
        public Day07B() : this(string.Empty) { }
        public Day07B(string path) : base(path) { }
        
        public override string Solve()
        {
            var regulationLookup = BagRegulation.GetRegulationsLookup(ParserFactory.CreateMultiLineStringParser().GetData());
            return regulationLookup["shiny gold"].ContainedBagCount(regulationLookup).ToString();
        }
    }
}