using System;
using System.Linq;

namespace AdventOfCode.Year2015.Day02
{
    public class PresentWrapping
    {
        public int Length { get; }
        public int Width { get; }
        public int Height { get; }

        public int RequiredPaper => 2 * Length * Width + 
                                    2 * Width * Height + 
                                    2 * Height * Length +
                                    Math.Min(Length*Width, Math.Min(Width*Height, Length*Height));
        
        public PresentWrapping(string dimensions)
        {
            var split = dimensions
                .Split(new[] {"x"}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            Length = split[0];
            Width = split[1];
            Height = split[2];
        }
    }
}