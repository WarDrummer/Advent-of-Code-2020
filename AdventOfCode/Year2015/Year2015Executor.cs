using AdventOfCode.Problem;
using AdventOfCode.Year2015.Day01;
using AdventOfCode.Year2015.Day02;
using AdventOfCode.Year2015.Day03;
using AdventOfCode.Year2015.Day04;

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
            
            ProblemFactory.Execute<Day03A>();
            ProblemFactory.Execute<Day03B>();
            
            ProblemFactory.Execute<Day04A>();
            ProblemFactory.Execute<Day04B>();
        }
    }
}