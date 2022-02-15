using Windows = System.Windows;

namespace CSharpMarkup.Wpf
{
    public static partial class Helpers
    {
        public static Windows.Thickness Thickness(double uniform) => new Windows.Thickness { Left = uniform, Top = uniform, Right = uniform, Bottom = uniform };
        public static Windows.Thickness Thickness(double horizontal, double vertical) => new Windows.Thickness { Left = horizontal, Top = vertical, Right = horizontal, Bottom = vertical };
        public static Windows.Thickness Thickness(double left, double top, double right, double bottom) => new Windows.Thickness { Left = left, Top = top, Right = right, Bottom = bottom };
        public static Windows.Thickness Thicknesses(double left = 0, double top = 0, double right = 0, double bottom = 0) => new Windows.Thickness { Left = left, Top = top, Right = right, Bottom = bottom };
    }
}