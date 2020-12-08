namespace AdventOfCode.Year2020.Day03
{
    public class Day03B : Day03A
    {
        public Day03B() : this(string.Empty) { }
        public Day03B(string path) : base(path) { }
        
        public override string Solve()
        {
            var trees = GetTrees();

            var treesHit = 
                GetTreesHitForSlope(1, 1, ref trees) *
                GetTreesHitForSlope(1, 3, ref trees) *
                GetTreesHitForSlope(1, 5, ref trees) *
                GetTreesHitForSlope(1, 7, ref trees) *
                GetTreesHitForSlope(2, 1, ref trees);

            return treesHit.ToString();
        }
    }
}