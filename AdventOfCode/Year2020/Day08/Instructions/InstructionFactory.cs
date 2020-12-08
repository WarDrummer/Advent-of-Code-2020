using System;

namespace AdventOfCode.Year2020.Day08.Instructions
{
    public class InstructionFactory
    {
        public IInstruction GetInstruction(string instruction)
        {
            var parts = instruction.Split(' ');
            switch (parts[0])
            {
                case "nop":
                    return new Nop(long.Parse(parts[1]));
                case "acc":
                    return new Accumulator(long.Parse(parts[1]));
                case "jmp":
                    return new Jump(long.Parse(parts[1]));
                default:
                    throw new Exception($"Unknown instruction: {instruction}");
            }
        }
    }
}