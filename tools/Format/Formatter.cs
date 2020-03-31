using System;

namespace CSharpMarkupTools
{
    public class Formatter
    {
        readonly Settings settings;

        public Formatter(Settings settings)
        {
            this.settings = settings;
        }

        public string Format(string source)
        {
            return source;
        }

        public class Settings
        {
            public int MaxLineLength { get; set; }
            public bool FormatWhiteSpace { get; set; }
        }
    }
}
