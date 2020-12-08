using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Problem;

namespace AdventOfCode.Year2020.Day08
{
    public class Day08B : ProblemWithInput
    {
        public Day08B() : this(string.Empty) { }
        public Day08B(string path) : base(path) { }
        
        public override string Solve()
        {
            var data = ParserFactory.CreateMultiLineStringParser().GetData().ToList();

            foreach (var program in GetVariantPrograms(data))
            {
                try
                {
                    var computer = Computer.Load(data);
                    computer.RunProgram();
                    return computer.Memory.Accumulator.ToString();
                }
                catch { /* Do nothing */ }
            }
                
            return "No Solution";
        }

        private IEnumerable<List<string>> GetVariantPrograms(List<string> program)
        {
            for (var i = 0; i < program.Count; i++)
            {
                var opcode = program[i].Substring(0, 3);
                if (opcode == "acc")
                    continue;

                var opcodeSwap = opcode == "jmp" ? "nop" : "jmp";
                program[i] = program[i].Replace(opcode, opcodeSwap);
                
                yield return program;
                
                program[i] = program[i].Replace(opcodeSwap, opcode);
            }
        }
    }
}