using System;
using AoC2020.Days;

namespace AoC2020
{
    static class Program
    {
        static void Main(string[] args)
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

            Console.ReadKey();
        }
    }
}