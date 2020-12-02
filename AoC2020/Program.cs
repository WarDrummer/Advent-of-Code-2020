using System;
using AoC2020.Days;

namespace AoC2020
{
    class Program
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

            Console.ReadKey();
        }
    }
    
    public static class StringExtensions
    {
        public static void ToConsole(this string s, string day = "")
        {
            Console.WriteLine($"{day} result: {s}".Trim());
            Console.WriteLine();
        }
    }
}