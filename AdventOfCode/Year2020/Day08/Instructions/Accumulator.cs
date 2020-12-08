namespace AdventOfCode.Year2020.Day08.Instructions
{
    public class Accumulator : IInstruction
    {
        private long Value { get; }
        public string OpCode => "acc";

        public Accumulator(long value)
        {
            Value = value;
        }
        public Memory Execute(Memory memory)
        {
            memory.Accumulator += Value;
            memory.InstructionPointer++;
            return memory;
        }
    }
}