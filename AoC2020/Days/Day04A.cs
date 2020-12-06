using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;
    
    public class Day04A : IProblem
    {
        protected readonly ParserType _parser;

        public Day04A() : this(new ParserType("day04.in")) { }

        private Day04A(ParserType parser) { _parser = parser; }

        public virtual string Solve()
        {
            var passports = GetPassports();
            var validCount = 0;
            foreach (var passport in passports)
            {
                if (IsValidPassport(passport))
                {
                    validCount++;
                }            
            }
            return validCount.ToString();
        }

        protected virtual bool IsValidPassport(IDictionary<string, string> passport)
        {
            return passport.ContainsKey("byr") &&
                   passport.ContainsKey("iyr") &&
                   passport.ContainsKey("eyr") &&
                   passport.ContainsKey("hgt") &&
                   passport.ContainsKey("hcl") &&
                   passport.ContainsKey("ecl") &&
                   passport.ContainsKey("pid");
        }

        private IList<Dictionary<string, string>> GetPassports()
        {
            var lines = _parser.GetData();

            var data = new List<Dictionary<string, string>>();
            data.Add(new Dictionary<string, string>());
            var current = data.Last();

            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    data.Add(new Dictionary<string, string>());
                    current = data.Last();
                    continue;
                }

                var parts = line.Split(new[] {" ", ":"}, StringSplitOptions.RemoveEmptyEntries);
                for (var i = 0; i < parts.Length; i += 2)
                {
                    current[parts[i]] = parts[i+1];
                }
            }
            
            return data;
        }
    }
}