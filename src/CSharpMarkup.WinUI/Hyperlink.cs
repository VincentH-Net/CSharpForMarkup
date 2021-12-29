using System;

namespace CSharpMarkup.WinUI
{
    public static partial class Helpers
    {
        public static Hyperlink Hyperlink(Uri uri, string text = null) => Hyperlink(Inlines(Run(text ?? uri.ToString()))).NavigateUri(uri);
        public static Hyperlink Hyperlink(string uri, string text = null) => Hyperlink(Inlines(Run(text ?? uri))).NavigateUri(new Uri(uri));
    }
}