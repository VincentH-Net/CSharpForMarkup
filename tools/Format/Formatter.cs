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

            /*
             TODO: Traverse tree and isolate new expressions, then reformat them to output string
             - Scope content has indent if the first whitespace stretch contains a line end
               new indent is stored in scope, so child scope reformat can format relative to new parent indent
             - Process scope content without child scopes - easyer to split comma-separated list of news.
             - Operations: 
               - filter out new expression scopes
               - split new expression into: ctor, list of property assignments, list of helpers
               - rebuild new expression into new string:
                 - new type(ctor) { p1 = v1, p2 = v2 } .H1 () .H2 () // Property equivalent helpers Style, Font, ...
                                   .H3 () // Non-property helpers: logic, gestures, ... 
                                   .LH1 () .LH2 () .LH3 ()  // Layout line
                                   .Bind1 ()
                                   .BindDefault ()
            
                 - new type(ctor) { p1 = v1, p2 = v2, Content =
                       new type(ctor) { p1 = v1, p2 = v2 } .H1 () .H2 () // Property equivalent helpers Style, Font, ...
                                       .H3 () // Non-property helpers: logic, gestures, ... 
                                       .LH1 () .LH2 () .LH3 ()  // Layout line
                                       .Bind1 ()
                                       .BindDefault ()
                   } .H1 () .H2 () // Property equivalent helpers Style, Font, ...
                     .H3 () // Non-property helpers: logic, gestures, ... 
                     .LH1 () .LH2 () .LH3 ()  // Layout line
                     .Bind1 ()
                     .BindDefault ()
                   
                 - new type(ctor) { p1 = v1, p2 = v2, Children = {
                       new type(ctor) { p1 = v1, p2 = v2 } .H1 () .H2 () // Property equivalent helpers Style, Font, ...
                                       .H3 () // Non-property helpers: logic, gestures, ... 
                                       .LH1 () .LH2 () .LH3 ()  // Layout line
                                       .Bind1 ()
                                       .BindDefault (),
            
                       new type(ctor) { p1 = v1, p2 = v2 } .H1 () .H2 () // Property equivalent helpers Style, Font, ...
                                       .H3 () // Non-property helpers: logic, gestures, ... 
                                       .LH1 () .LH2 () .LH3 ()  // Layout line
                                       .Bind1 ()
                                       .BindDefault ()
                   }}.H1 () .H2 () // Property equivalent helpers Style, Font, ...
                     .H3 () // Non-property helpers: logic, gestures, ... 
                     .LH1 () .LH2 () .LH3 ()  // Layout line
                     .Bind1 ()
                     .BindDefault ()
                   
                 - Indentation: 
                   Only change indentation within new expressions. 
                   Preserve base indentation (before the new keyword) of outermost new expression.
                   Then calculate indentation of everything within the new expression.
                   ?If a new expression is nested within another new expression -> indent = parent indent + indentsize
                   ?If there is e.g. a multiline code block -> indent = parent scope indent + indentsize
                   Preserve multiline string literals (treat as single line)

                 Doublecheck https://docs.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/get-started/syntax-analysis
                 and stand-alone tools: https://docs.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/get-started/syntax-analysis
                 Maybe roslyn is not too much complexity after all.
                 */

            parser.PrintScopesWithoutSubscopes(scopeTree);

            return source;
        }
    }
}
