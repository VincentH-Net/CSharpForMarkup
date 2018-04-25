using System;
using Xamarin.Forms;

namespace CSharpForMarkupExample
{
    public static partial class BrandingExtensions
    {
        public static Color ToColor(this Colors color) => Xamarin.Forms.Color.FromUint((uint)color);

        public static T BackgroundColor<T>(this T visualElement, Colors color) where T : VisualElement { visualElement.BackgroundColor = color.ToColor(); return visualElement; }

        public static BoxView Color(this BoxView boxView, Colors color) { boxView.Color = color.ToColor(); return boxView; }

        public static Label TextColor(this Label label, Colors color) { label.TextColor = color.ToColor(); return label; }

        public static Button TextColor(this Button button, Colors color) { button.TextColor = color.ToColor(); return button; }

        public static Entry TextColor(this Entry entry, Colors color) { entry.TextColor = color.ToColor(); return entry; }


        public static Label Font(this Label label, FontSizes size) { label.FontSize = (double)size; return label; }

        public static Button Font(this Button button, FontSizes size) { button.FontSize = (double)size; return button; }

        public static Entry Font(this Entry entry, FontSizes size) { entry.FontSize = (double)size; return entry; }


        public static Label Font(this Label label, FontAttributes attributes) { label.FontAttributes = attributes; return label; }

        public static Button Font(this Button button, FontAttributes attributes) { button.FontAttributes = attributes; return button; }

        public static Entry Font(this Entry entry, FontAttributes attributes) { entry.FontAttributes = attributes; return entry; }

        public static Label Font(this Label label, FontSizes size, FontAttributes attributes) => label.Font(size).Font(attributes);

        public static Button Font(this Button button, FontSizes size, FontAttributes attributes) => button.Font(size).Font(attributes);

        public static Entry Font(this Entry entry, FontSizes size, FontAttributes attributes) => entry.Font(size).Font(attributes);
    }
}
