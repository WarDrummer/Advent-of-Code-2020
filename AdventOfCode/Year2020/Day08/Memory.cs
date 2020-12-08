using System.Collections.Generic;

namespace AdventOfCode.Year2020.Day08
{
    public class Memory
    {
        private readonly IDictionary<string, long> _memory = new Dictionary<string, long>();
        public Memory()
        {
            this["ip"] = 0;
            this["accumulator"] = 0;
        }
        public long this[string register]
        {
            get => _memory.ContainsKey(register) ? _memory[register] : default;
            set => _memory[register] = value;
        }

        public int InstructionPointer
        {
            get => (int)_memory["ip"];
            set => _memory["ip"] = value;
        }
        
        public long Accumulator
        {
            get => _memory["accumulator"];
            set => _memory["accumulator"] = value;
        }
    }
}