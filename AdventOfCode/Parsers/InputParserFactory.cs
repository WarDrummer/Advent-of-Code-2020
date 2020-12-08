namespace AdventOfCode.Parsers
{
    public class InputParserFactory
    {
        private readonly string _path;

        public InputParserFactory(string path)
        {
            _path = path;
        }
        public SingleLineStringParser CreateSingleLineStringParser()
        {
            return new SingleLineStringParser(_path);
        }
        
        public MultiLineStringParser CreateMultiLineStringParser()
        {
            return new MultiLineStringParser(_path);
        }
        
        public MultiLineIntParser CreateMultiLineIntParser()
        {
            return new MultiLineIntParser(_path);
        }
    }
}