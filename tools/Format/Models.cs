using System.Collections.Generic;

namespace CSharpMarkupTools
{
    public class Settings
    {
        public int IndentSize { get; set; } = 4;
        public int MaxLineLength { get; set; } = 80;
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
        public Scope CtorParameters { get; set; }
        public List<PropertyAssignment> PropertyAssignments { get; set; }
        public List<HelperInvocation> HelperInvocations { get; set; }
    }

    internal class PropertyAssignment
    {
        public string Name { get; set; }
        public string Value { get; set; } // Note this could be a new expression, e.g. Content = new View { } .H1 or Children = { new View .H1, ... }
    }

    internal class HelperInvocation
    {
        public string Name { get; set; }
        public Scope Parameters { get; set; }
    }

    internal enum ScopeKind { File, CurlyBracket, SquareBracket, Parenthesis, DoubleQuote, SingleQuote }
}
