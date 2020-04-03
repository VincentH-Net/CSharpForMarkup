using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMarkupTools
{
    public class Settings
    {
        public int MaxLineLength { get; set; }
        public bool FormatWhiteSpace { get; set; }
    }

    internal class Scope
    {
        public ScopeKind Kind { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public int Length => End - Start;
    }

    internal enum ScopeKind { File, CurlyBracket, SquareBracket, Parenthesis, DoubleQuote, SingleQuote }
}
