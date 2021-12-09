using System.Collections.Generic;
using Windows = System.Windows;

namespace CSharpMarkup.Wpf
{
    public static partial class Helpers
    {
        //TODO: check XAML and if consistent try for convert string to Run inline - give InLines() param list element converting type

        public static IEnumerable<Windows.Documents.Inline> Inlines(params Windows.Documents.Inline[] inlines) => inlines;
    }
}