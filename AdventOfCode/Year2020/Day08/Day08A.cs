using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day08
{
    public class Day08A : ProblemWithInput
    {
        public Day08A() : this(string.Empty) { }
        public Day08A(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData();
            var computer = Computer.Load(data);
            
            while (!computer.HasNextInstructionBeenExecuted())
            {
                computer.Step();
            }
            
            return computer.Memory.Accumulator.ToString();
        }
    }
}