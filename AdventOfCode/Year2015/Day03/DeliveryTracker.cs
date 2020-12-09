using System.Collections.Generic;

namespace AdventOfCode.Year2015.Day03
{
    public class DeliveryTracker
    {
        private int _x;
        private int _y;
        private readonly HashSet<string> _visited;
        
        public DeliveryTracker(HashSet<string> visited)
        {
            _visited = visited;
            _visited.Add("0,0");
        }
        
        public void Move(char direction)
        {
            switch (direction)
            {
                case 'v': _y--; break;
                case '^': _y++; break;
                case '<': _x--; break;
                case '>': _x++; break;
            }
            _visited.Add($"{_x},{_y}");
        }
    }
}