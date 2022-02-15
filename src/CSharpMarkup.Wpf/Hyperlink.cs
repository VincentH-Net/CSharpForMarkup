using System;

namespace CSharpMarkup.Wpf
{
    public static partial class Helpers
    {
        public static Hyperlink Hyperlink(Uri uri, params InlineCollectionItem[] content) => Hyperlink(content).NavigateUri(uri);
    }
}