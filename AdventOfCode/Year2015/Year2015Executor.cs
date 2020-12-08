using AdventOfCode.Problem;
using AdventOfCode.Year2015.Day01;
using AdventOfCode.Year2015.Day02;

namespace AdventOfCode.Year2015
{
    public class Year2015Executor : IYearExecutor
    {
        public void Execute()
        {
            ProblemFactory.Execute<Day01A>();
            ProblemFactory.Execute<Day01B>();
            
            ProblemFactory.Execute<Day02A>();
            ProblemFactory.Execute<Day02B>();
        }
    }
}