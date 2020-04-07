using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpMarkupTools
{
    internal class NewViewExpressionsParser
    {
        readonly ScopesParser scopesParser;

        public NewViewExpressionsParser(ScopesParser scopesParser)
        {
            this.scopesParser = scopesParser;
        }

        public void Parse(Tree<Scope> scopeTree)
        {
            ParseRecursive(scopeTree);
        }

        void ParseRecursive(Tree<Scope> scopeNode)
        {
            var scopeTexts = scopesParser.ScopeTextWithoutSubscopes(scopeNode, replaceWithSpaces: false).Split(',');
            foreach (var scopeText in scopeTexts)
            {
                if (ContainsNew(scopeText))
                {
                    var scope = scopeNode.Value;
                    ParseNewViewExpression(scope, scopeText);
                }
            }
        }

        bool ContainsNew(string scopeText) => Regex.IsMatch(scopeText, @"\bnew\b");

        void ParseNewViewExpression(Scope scope, string scopeText)
        {
            // E.g. "new Label  .FontSize  .CenterH" or ""
        }
    }
}
