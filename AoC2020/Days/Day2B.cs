using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class PasswordPolicyEnforcerEx
    {
        private int Min { get; }
        private int Max { get; }
        private char Pattern { get; }
        private string Password { get; }

        public PasswordPolicyEnforcerEx(int min, int max, string pattern, string password)
        {
            Min = min;
            Max = max;
            Pattern = pattern[0];
            Password = password;
        }

        public bool IsValid()
        {
            var count = 0;
            if (Password[Min - 1] == Pattern)
            {
                count++;
            }

            if (Password[Max - 1] == Pattern)
            {
                count++;
            }

            return count == 1;
        }
    }
    
    public class Day2B : IProblem
    {
        protected readonly ParserType _parser;

        public Day2B() : this(new ParserType("day02.in")) { }

        private Day2B(ParserType parser) { _parser = parser; }

        public virtual string Solve()
        {
            var input = _parser
                .GetData()
                .Select(s => s.Split(new [] {"-", " ", ":"}, StringSplitOptions.RemoveEmptyEntries))
                .Select(parts => new PasswordPolicyEnforcerEx(
                    int.Parse(parts[0]),
                    int.Parse(parts[1]),
                    parts[2],
                    parts[3]));

            return input.Count(i => i.IsValid()).ToString();
        }
    }
}