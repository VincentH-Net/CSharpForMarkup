using Xaml = Microsoft.UI.Xaml;
using Color = Windows.UI.Color;

namespace CSharpMarkup.WinUI
{
    public static class MarkupExtensions
    {
        public static Color ToColor(this string color) => (Color)Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(Color), color);
    }
}