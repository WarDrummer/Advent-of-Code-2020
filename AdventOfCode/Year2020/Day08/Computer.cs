using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Year2020.Day08.Instructions;

namespace AdventOfCode.Year2020.Day08
{
    public class Computer
    {
        public Memory Memory { get; private set; }
        
        private readonly IList<IInstruction> _instructionSet;
        private readonly HashSet<int> _executedLines = new HashSet<int>();

        private Computer(Memory memory, IList<IInstruction> instructionSet)
        {
            Memory = memory;
            _instructionSet = instructionSet;
        }

        public static Computer Load(IEnumerable<string> instructions)
        {
            var factory = new InstructionFactory();
            var lines = instructions.ToArray();
            var instructionSet = new List<IInstruction>(lines.Length);
            foreach (var line in lines)
            {
                instructionSet.Add(factory.GetInstruction(line));
            }
            return new Computer(new Memory(), instructionSet);
        }

        public void Step()
        {
            var ip = Memory.InstructionPointer;
            _executedLines.Add(ip);
            Memory = _instructionSet[ip].Execute(Memory);
        }

        public void RunProgram()
        {
            var numberOfInstructions = _instructionSet.Count;
            while (Memory.InstructionPointer < numberOfInstructions)
            {
                Step();
                if (HasNextInstructionBeenExecuted())
                {
                    throw new Exception("FAULT: no lines should be executed more than once");
                }
            }
        }

        public bool HasNextInstructionBeenExecuted()
        {
            return _executedLines.Contains(Memory.InstructionPointer);
        }
    }
}