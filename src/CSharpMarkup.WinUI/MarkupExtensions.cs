using Color = Windows.UI.Color;

namespace Microsoft.UI.Markup
{
    public static class MarkupExtensions
    {
        public static Color ToColor(this string color) => (Color)Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(Color), color);
    }
}