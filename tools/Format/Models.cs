using System.Collections.Generic;

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

        public int Indent { get; set; }
        public List<NewViewExpression> NewViewExpressions { get; } = new List<NewViewExpression>();
    }

    internal class NewViewExpression
    {
        public string ViewType { get; set; }
        public string CtorParameters { get; set; }
        public List<PropertyAssignment> PropertiesSet { get; set; }
        public List<FluentHelper> FluentHelpers { get; set; }
        public int HangingIndent { get; set; }
    }

    internal class PropertyAssignment
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    internal class FluentHelper
    {
        public string Name { get; set; }
    }

    internal enum ScopeKind { File, CurlyBracket, SquareBracket, Parenthesis, DoubleQuote, SingleQuote }
}
