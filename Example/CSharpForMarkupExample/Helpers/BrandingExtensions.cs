using System;
using Xamarin.Forms;

namespace CSharpForMarkupExample
{
    public static partial class BrandingExtensions
    {

        public static Color ToColor(this ThemeColors color) => Color.FromUint((uint)color);

        public static Label SetFontSize(this Label label, ThemeFontSizes size)
        {
            if (label != null) label.FontSize = (double)size;
            return label;
        }

        public static Button SetFontSize(this Button button, ThemeFontSizes size)
        {
            if (button != null) button.FontSize = (double)size;
            return button;
        }

        public static Entry SetFontSize(this Entry entry, ThemeFontSizes size)
        {
            if (entry != null) entry.FontSize = (double)size;
            return entry;
        }
    }
}
