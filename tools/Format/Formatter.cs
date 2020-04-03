using System;
using System.Text;

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
            if (source == null) return null;

            var parser = new ScopesParser(settings);
            var scopeTree = parser.Parse(source);

            var sb = new StringBuilder();
            parser.Render(sb, scopeTree);
            Console.WriteLine(sb);

            // TODO: Traverse tree and isolate new expressions, then reformat them to output string
            // - Scope content has indent if the first whitespace stretch contains a line end
            //   new indent is stored in scope, so child scope reformat can format relative to new parent indent
            // - Process scope content without child scopes - easyer to split comma-separated list of news.
            // - Operations: 
            //   - filter out new expression scopes
            //   - split new expression into: ctor, list of property assignments, list of helpers
            //   - rebuild new expression into new string:
            //     - new type(ctor) { p1 = v1, p2 = v2 } .H1 () .H2 () // Property equivalent helpers Style, Font, ...
            //                       .H3 () // Non-property helpers: logic, gestures, ... 
            //                       .LH1 () .LH2 () .LH3 ()  // Layout line
            //                       .Bind1 ()
            //                       .BindDefault ()
            parser.PrintScopesWithoutSubscopes(scopeTree);

            return source;
        }
    }
}
