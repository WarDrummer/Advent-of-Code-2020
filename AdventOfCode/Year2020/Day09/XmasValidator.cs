using System.Collections.Generic;

namespace AdventOfCode.Year2020.Day09
{
    public class XmasValidator
    {
        private readonly int _preambleSize;

        public XmasValidator(int preambleSize = 25)
        {
            _preambleSize = preambleSize;
        }

        public long FindFirstFailure(IList<long> numbers)
        {
            var q = new Queue<long>(_preambleSize);
            for (var i = 0; i < _preambleSize; i++)
            {
                q.Enqueue(numbers[i]);
            }

            for (var i = _preambleSize; i < numbers.Count; i++)
            {
                var next = numbers[i];
                var lookup = new HashSet<long>(q);
                var valid = false;
                foreach (var num in lookup)
                {
                    var tmp = next - num;
                    if (lookup.Contains(tmp) && tmp * 2 != next)
                    {
                        valid = true;
                        break;
                    }
                }

                if (!valid)
                {
                    return next;
                }

                q.Dequeue();
                q.Enqueue(next);
            }

            return -1;
        }
    }
}