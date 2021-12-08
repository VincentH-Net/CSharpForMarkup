using Color = System.Windows.Media.Color;

namespace CSharpMarkup.Wpf
{
    public static class MarkupExtensions
    {
        public static Color ToColor(this string color) => (Color)System.Windows.Media.ColorConverter.ConvertFromString(color);
    }
}