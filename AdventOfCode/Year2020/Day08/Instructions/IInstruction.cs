namespace AdventOfCode.Year2020.Day08.Instructions
{
    public interface IInstruction
    {
        string OpCode { get; }
        Memory Execute(Memory memory);
    }
}