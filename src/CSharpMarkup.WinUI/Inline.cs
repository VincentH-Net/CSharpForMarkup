using System.Collections.Generic;
using Xaml = Microsoft.UI.Xaml;

namespace CSharpMarkup.WinUI
{
    public static partial class Helpers
    {
        //TODO: check XAML and if consistent try for convert string to Run inline - give InLines() param list element converting type

        public static IEnumerable<Xaml.Documents.Inline> Inlines(params Xaml.Documents.Inline[] inlines) => inlines;
    }
}