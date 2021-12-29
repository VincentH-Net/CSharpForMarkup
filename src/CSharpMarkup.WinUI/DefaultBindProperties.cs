using Xaml = Microsoft.UI.Xaml;
using Controls = Microsoft.UI.Xaml.Controls;

namespace CSharpMarkup.WinUI
{
    public interface IDefaultBindProperty // TODO: Generate this automatically if only one possibility
    {
        Xaml.DependencyProperty DefaultBindProperty { get; }
    }

    public interface IDefaultBindCommandProperties // TODO: Generate this automatically if only one possibility, and from helpers where specified (if needed) ? only if there is a property <name>CommandParameterProperty and <name>CommandProperty?
    {
        Xaml.DependencyProperty DefaultBindCommandProperty { get; }
        Xaml.DependencyProperty DefaultBindCommandParameterProperty { get; }
    }

    public partial class MenuFlyoutItem : IDefaultBindCommandProperties
    {
        public Xaml.DependencyProperty DefaultBindCommandProperty => Controls.MenuFlyoutItem.CommandProperty;
        public Xaml.DependencyProperty DefaultBindCommandParameterProperty => Controls.MenuFlyoutItem.CommandParameterProperty;
    }

    public partial class SplitButton : IDefaultBindCommandProperties
    {
        public Xaml.DependencyProperty DefaultBindCommandProperty => Controls.SplitButton.CommandProperty;
        public Xaml.DependencyProperty DefaultBindCommandParameterProperty => Controls.SplitButton.CommandParameterProperty;
    }

    public partial class SwipeItem : IDefaultBindCommandProperties
    {
        public Xaml.DependencyProperty DefaultBindCommandProperty => Controls.SwipeItem.CommandProperty;
        public Xaml.DependencyProperty DefaultBindCommandParameterProperty => Controls.SwipeItem.CommandParameterProperty;
    }

    public partial class TabView : IDefaultBindCommandProperties
    {
        public Xaml.DependencyProperty DefaultBindCommandProperty => Controls.TabView.AddTabButtonCommandProperty;
        public Xaml.DependencyProperty DefaultBindCommandParameterProperty => Controls.TabView.AddTabButtonCommandParameterProperty;
    }

    public partial class ButtonBase : IDefaultBindCommandProperties
    {
        public Xaml.DependencyProperty DefaultBindCommandProperty => Controls.Primitives.ButtonBase.CommandProperty;
        public Xaml.DependencyProperty DefaultBindCommandParameterProperty => Controls.Primitives.ButtonBase.CommandParameterProperty;
    }
}