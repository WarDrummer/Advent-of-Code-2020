using System;
using System.Linq;

namespace AdventOfCode.Year2015.Day02
{
    public class Ribbon
    {
        public int Length { get; }
        public int Width { get; }
        public int Height { get; }

        public int RequiredRibbon
        {
            get
            {
                var values = new[] {Length, Width, Height};
                Array.Sort(values);
                return values[0] * 2 + values[1] * 2 + Length * Width * Height;
            }
        }

        public Ribbon(string dimensions)
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