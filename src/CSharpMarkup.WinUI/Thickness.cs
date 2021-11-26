namespace Microsoft.UI.Markup
{
    public static partial class Helpers
    {
        public static Xaml.Thickness Thickness(double uniform) => new Xaml.Thickness { Left = uniform, Top = uniform, Right = uniform, Bottom = uniform };
        public static Xaml.Thickness Thickness(double horizontal, double vertical) => new Xaml.Thickness { Left = horizontal, Top = vertical, Right = horizontal, Bottom = vertical };
        public static Xaml.Thickness Thickness(double left, double top, double right, double bottom) => new Xaml.Thickness { Left = left, Top = top, Right = right, Bottom = bottom };
        public static Xaml.Thickness Thicknesses(double left = 0, double top = 0, double right = 0, double bottom = 0) => new Xaml.Thickness { Left = left, Top = top, Right = right, Bottom = bottom };
    }
}