using AoC2020.Days;

namespace AoC2020
{
    static class Program
    {
        static void Main()
        {
            ProblemFactory.Create<Day1A>()
                .AppendTime()
                .Solve()
                .ToConsole("Day 1A");
            
            ProblemFactory.Create<Day1B>()
                .AppendTime()
                .Solve()
                .ToConsole("Day 1B");
            
            ProblemFactory.Create<Day2A>()
                .AppendTime()
                .Solve()
                .ToConsole("Day 2A");
            
            ProblemFactory.Create<Day2B>()
                .AppendTime()
                .Solve()
                .ToConsole("Day 2B");

            ProblemFactory.Create<Day3A>()
                .AppendTime()
                .Solve()
                .ToConsole("Day 3A");
            
            ProblemFactory.Create<Day3B>()
                .AppendTime()
                .Solve()
                .ToConsole("Day 3B");
            
            ProblemFactory.Create<Day4A>()
                .AppendTime()
                .Solve()
                .ToConsole("Day 4A");
            
            ProblemFactory.Create<Day4B>()
                .AppendTime()
                .Solve()
                .ToConsole("Day 4B");
                
            ProblemFactory.Create<Day5A>()
                .AppendTime()
                .Solve()
                .ToConsole("Day 5A");
            
            ProblemFactory.Create<Day5B>()
                .AppendTime()
                .Solve()
                .ToConsole("Day 5B");
        }
    }
}