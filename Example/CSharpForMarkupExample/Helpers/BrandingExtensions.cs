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
    }
}
