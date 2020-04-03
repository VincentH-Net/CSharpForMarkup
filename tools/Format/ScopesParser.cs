using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharpMarkupTools
{
    internal class ScopesParser
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

        public ScopesParser(string source, Settings settings)
        {
            this.source = source;
            this.settings = settings;
            endPos = source?.Length ?? 0;
        }

        public Tree<Scope> Parse()
        {
            pos = 0;
            var scopeTree = new Tree<Scope>(new Scope { Kind = ScopeKind.File, Start = pos, End = endPos });
            AddChildScopes(scopeTree);
            return scopeTree;
        }

        public void Render(StringBuilder sb, Tree<Scope> scopeNode)
        {
            pos = 0;
            RenderRecursive(sb, scopeNode);
        }

        public void PrintScopesWithoutSubscopes(Tree<Scope> scopeNode, int indent = 0)
        {
            PrintScopeWithoutSubscopes(scopeNode, indent);
            foreach (var childNode in scopeNode.Children)
                PrintScopesWithoutSubscopes(childNode, indent + 4);
        }

        void AddChildScopes(Tree<Scope> scopeNode, char closingChar = '\0')
        {
            var scope = scopeNode.Value;
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
                    scopeNode.Add(childScope);
                    AddChildScopes(childScope, scopeDelimiters.Item2);
                }
            }
        }

        void RenderRecursive(StringBuilder sb, Tree<Scope> scopeNode)
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

        void PrintScopeWithoutSubscopes(Tree<Scope> scopeNode, int indent) => Debug.WriteLine($"{scopeNode.Value.Kind,16}{new string(' ', indent)}{ScopeTextWithoutSubscopes(scopeNode)}");

        string ScopeTextWithoutSubscopes(Tree<Scope> scopeNode)
        {
            var scope = scopeNode.Value;
            string text = source.Substring(scope.Start, scope.Length);
            for (int i = scopeNode.Children.Count - 1; i >= 0; i--)
            {
                var childScope = scopeNode.Children[i].Value;
                text = text.Remove(childScope.Start - scope.Start, childScope.Length);
            }
            return text;
        }
    }
}
