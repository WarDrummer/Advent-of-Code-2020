namespace AdventOfCode.Year2020.Day08.Instructions
{
    public class Nop : IInstruction
    {
        public string OpCode => "nop";
        private long Value { get; }
        public Nop(long value)
        {
            Value = value;
        }
        
        public Memory Execute(Memory memory)
        {
            memory.InstructionPointer++;
            return memory;
        }
    }
}