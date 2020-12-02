using System.Text;

namespace AoC2020
{
    public class SingleLineStringParser : InputParser<string>
    {
        public SingleLineStringParser(string inputFile) : base(inputFile) { }

        public override string GetData()
        {
            var sb = new StringBuilder();
            foreach (var line in GetInput())
            {
                sb.Append(line);
            }
            return sb.ToString();
        }
    }
}