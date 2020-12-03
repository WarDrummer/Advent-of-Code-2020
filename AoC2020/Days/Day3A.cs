using System.Linq;

namespace AoC2020.Days
{
    using ParserType = MultiLineStringParser;
    
    public class Day3A : IProblem
    {
        protected readonly ParserType _parser;

        public Day3A() : this(new ParserType("day03.in")) { }

        private Day3A(ParserType parser) { _parser = parser; }

        public virtual string Solve()
        {
            var trees = GetTrees();

            var yMovement = 1;
            var xMovement = 3;
            
            var treesHit = GetTreesHitForSlope(yMovement, xMovement, ref trees);

            return treesHit.ToString();
        }

        protected char[][] GetTrees()
        {
            return _parser.GetData()
                .Select(s => s.ToCharArray())
                .ToArray();
        }

        protected static long GetTreesHitForSlope(int yMovement, int xMovement, ref char[][] trees)
        {
            var rowLength = trees[0].Length;
            long treesHit = 0;
            for (int y = yMovement, x = xMovement;
                y < trees.Length;
                y += yMovement, x += xMovement)
            {
                if (trees[y][x % rowLength] == '#')
                {
                    treesHit++;
                }
            }

            return treesHit;
        }
    }
}