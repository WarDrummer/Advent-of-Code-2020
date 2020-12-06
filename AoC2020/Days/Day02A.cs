using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class PasswordPolicyEnforcer
    {
        public int Min { get; }
        public int Max { get; }
        public char Pattern { get; }
        public string Password { get; }

        public PasswordPolicyEnforcer(int min, int max, string pattern, string password)
        {
            Min = min;
            Max = max;
            Pattern = pattern[0];
            Password = password;
        }

        public bool IsValid()
        {
            var counts = new int[256];
            foreach (var c in Password)
            {
                counts[c]++;
            }

            return counts[Pattern] >= Min && counts[Pattern] <= Max;
        }
    }
    
    public class Day02A : IProblem
    {
        protected readonly ParserType _parser;

        public Day02A() : this(new ParserType("day02.in")) { }

        private Day02A(ParserType parser) { _parser = parser; }

        public virtual string Solve()
        {
            var input = _parser
                .GetData()
                .Select(s => s.Split(new [] {"-", " ", ":"}, StringSplitOptions.RemoveEmptyEntries))
                .Select(parts => new PasswordPolicyEnforcer(
                    int.Parse(parts[0]),
                    int.Parse(parts[1]),
                    parts[2],
                    parts[3]));


            return input.Count(i => i.IsValid()).ToString();
        }
    }
}