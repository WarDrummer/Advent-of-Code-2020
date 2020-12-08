using System;
using System.Linq;
using AdventOfCode.Parsers;

namespace AdventOfCode.Problem
{
    public class ProblemWithInput : IProblem
    {
        protected InputParserFactory ParserFactory { get; }
        
        public ProblemWithInput() : this(string.Empty)
        {
        }
        
        public ProblemWithInput(string fileName)
        {
            ParserFactory = new InputParserFactory(GetPathFromType(GetType(), fileName));
        }

        private string GetPathFromType(Type currentType, string fileName)
        {
            var fullNameParts = currentType.FullName?
                .Split(new[] {"."}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (fullNameParts == null)
            {
                return "";
            }

            var fileIndex = fullNameParts.Length - 1;
            if (!string.IsNullOrEmpty(fileName))
            {
                fullNameParts[fileIndex] = fileName;
            }
            else
            {
                var fileLength = fullNameParts[fileIndex].Length;
                fullNameParts[fileIndex] = $"{fullNameParts[fileIndex].Substring(0,fileLength - 1)}.in";
            }

            var pathFromNamespace =
                string.Join("/", fullNameParts.Skip(fullNameParts.Length - 3))
                    .ToLower();

            return pathFromNamespace;

        }
        
        public virtual string Solve()
        {
            return "Not Solved";
        }
    }
}