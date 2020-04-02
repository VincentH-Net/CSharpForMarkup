using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CSharpMarkupTools
{
    public class Formatter
    {
        static Dictionary<char, (ScopeKind, char)> scopesDelimiters = new Dictionary<char, (ScopeKind, char)>
        {
            // Opening char, kind, closing char
            { '{' , (ScopeKind.CurlyBracket , '}' ) },
            { '[' , (ScopeKind.SquareBracket, ']' ) },
            { '(' , (ScopeKind.Parenthesis  , ')' ) },
            { '\"', (ScopeKind.DoubleQuote  , '\"') },
            { '\'', (ScopeKind.SingleQuote  , '\'') }
        };

        readonly string source;
        readonly Settings settings;
        readonly int endPos;
        int pos;

        public Formatter(string source, Settings settings)
        {
            this.source = source;
            this.settings = settings;
            endPos = source?.Length ?? 0;
        }

        public string Format()
        {
            if (source == null) return null;

            pos = 0;
            var scopeTree = new Tree<Scope>(new Scope { Kind = ScopeKind.File, Start = pos, End = endPos });
            AddChildScopes(scopeTree);

            pos = 0;
            var sb = new StringBuilder();
            Render(sb, scopeTree);
            Debug.WriteLine(sb);

            // TODO: Traverse tree and isolate new expressions, then reformat them to output string
            // - Scope content has indent if the first whitespace stretch contains a line end
            //   new indent is stored in scope, so child scope reformat can format relative to new parent indent
            // - Process scope content without child scopes - easyer to split comma-separated list of news.


            return source;
        }

        void AddChildScopes(Tree<Scope> scopeTreeNode, char closingChar = '\0')
        {
            var scope = scopeTreeNode.Value;
            var kind = scope.Kind;
            bool isInterpolatedString = kind == ScopeKind.DoubleQuote && FirstNonWhitespaceCharBefore(pos - 1) == '$';
            // TODO: support @"" strings including "" escape and no '\' escape; check C# grammar for strings

            while (pos < scope.End)
            {
                char c = source[pos++];

                // Skip escape character + next character
                if (kind == ScopeKind.SingleQuote || kind == ScopeKind.DoubleQuote && c == '\\')
                {
                    if (++pos >= scope.End) { pos = scope.End; return; }
                    c = source[pos++];
                }

                // Check for end of current scope
                if (c == closingChar)
                {
                    scope.End = pos;
                    return;
                }

                if (scopesDelimiters.TryGetValue(c, out var scopeDelimiters) &&
                    !(isInterpolatedString && scopeDelimiters.Item1 != ScopeKind.CurlyBracket))
                {
                    var childScope = new Tree<Scope>(new Scope { Kind = scopeDelimiters.Item1, Start = pos - 1, End = endPos });
                    scopeTreeNode.Add(childScope);
                    AddChildScopes(childScope, scopeDelimiters.Item2);
                }
            }
        }

        void Render(StringBuilder sb, Tree<Scope> scopeNode)
        {
            var scope = scopeNode.Value;

            RenderTo(sb, scope.Start);
            sb.Append("<").Append(scope.Kind).Append(">");
            foreach (var childNode in scopeNode.Children) Render(sb, childNode);
            RenderTo(sb, scope.End);
            sb.Append("</").Append(scope.Kind).Append(">");
        }

        void RenderTo(StringBuilder sb, int end)
        {
            sb.Append(source.Substring(pos, end - pos));
            pos = end;
        }

        char FirstNonWhitespaceCharBefore(int position)
        {
            while (position > 0)
            {
                char c = source[--position];
                if (!" \t\r\n".Contains(c)) return c;
            }
            return '\0';
        }

        public class Settings
        {
            public int MaxLineLength { get; set; }
            public bool FormatWhiteSpace { get; set; }
        }

        class Scope
        {
            public ScopeKind Kind { get; set; } 
            public int Start { get; set; }
            public int End { get; set; }
        }

        enum ScopeKind { File, CurlyBracket, SquareBracket, Parenthesis, DoubleQuote, SingleQuote }
    }
}
