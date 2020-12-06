using System.Collections.Generic;
using System.Linq;

namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;

    public class Day6A : IProblem
    {
        private readonly ParserType _parser;

        public Day6A() : this(new ParserType("day06.in"))
        {
        }

        private Day6A(ParserType parser)
        {
            _parser = parser;
        }

        public virtual string Solve()
        {
            var responses = GetGroupResponses();
            var uniqueCounts = responses.Select(r => r.GetUniqueResponseCount()); 
            return uniqueCounts.Sum().ToString();
        }

        protected List<GroupResponses> GetGroupResponses()
        {
            var lines = _parser.GetData();

            var current = new GroupResponses();

            var responses = new List<GroupResponses>();
            responses.Add(current);

            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    current = new GroupResponses();
                    responses.Add(current);
                    continue;
                }

                current.AddResponses(line);
            }

            return responses;
        }
    }

    public class GroupResponses
    {
        private readonly Dictionary<char, int> _responses = new Dictionary<char, int>();
        private int _numberOfResponders;
        
        public void AddResponses(string responses)
        {
            _numberOfResponders++;
            foreach (var response in responses)
            {
                if (!_responses.ContainsKey(response))
                {
                    _responses[response] = 0;
                }

                _responses[response]++;
            }
        }

        public int GetUniqueResponseCount()
        {
            return _responses.Keys.Count;
        }
        
        public int GetConsensusCount()
        {
            return _responses.Count(kvp => kvp.Value == _numberOfResponders);
        }
    }
}