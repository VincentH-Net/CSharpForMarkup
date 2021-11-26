using System.Collections.Generic;

namespace Microsoft.UI.Markup
{
    public static partial class Helpers
    {
        //TODO: check XAML and if consistent try for convert string to Run inline - give InLines() param list element converting type

        public static IEnumerable<Xaml.Documents.Inline> Inlines(params Xaml.Documents.Inline[] inlines) => inlines;
    }
}