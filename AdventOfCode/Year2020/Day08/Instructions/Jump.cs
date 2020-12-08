namespace AdventOfCode.Year2020.Day08.Instructions
{
    public class Jump : IInstruction
    {
        private long Value { get; }
        public string OpCode => "acc";

        public Jump(long value)
        {
            Value = value;
        }
        public Memory Execute(Memory memory)
        {
            memory.InstructionPointer += (int)Value;
            return memory;
        }
    }
}