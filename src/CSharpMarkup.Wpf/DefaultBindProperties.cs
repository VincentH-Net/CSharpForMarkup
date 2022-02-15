using Controls = System.Windows.Controls;

namespace CSharpMarkup.Wpf
{
    public interface IDefaultBindProperty // TODO: Generate this automatically if only one possibility
    {
        System.Windows.DependencyProperty DefaultBindProperty { get; }
    }

    public interface IDefaultBindCommandProperties // TODO: Generate this automatically if only one possibility, and from helpers where specified (if needed) ? only if there is a property <name>CommandParameterProperty and <name>CommandProperty?
    {
        System.Windows.DependencyProperty DefaultBindCommandProperty { get; }
        System.Windows.DependencyProperty DefaultBindCommandParameterProperty { get; }
    }

    //public partial class MenuFlyoutItem : IDefaultBindCommandProperties
    //{
    //    public DependencyProperty DefaultBindCommandProperty => Controls.MenuFlyoutItem.CommandProperty;
    //    public DependencyProperty DefaultBindCommandParameterProperty => Controls.MenuFlyoutItem.CommandParameterProperty;
    //}

    //public partial class SplitButton : IDefaultBindCommandProperties
    //{
    //    public DependencyProperty DefaultBindCommandProperty => Controls.SplitButton.CommandProperty;
    //    public DependencyProperty DefaultBindCommandParameterProperty => Controls.SplitButton.CommandParameterProperty;
    //}

    //public partial class SwipeItem : IDefaultBindCommandProperties
    //{
    //    public DependencyProperty DefaultBindCommandProperty => Controls.SwipeItem.CommandProperty;
    //    public DependencyProperty DefaultBindCommandParameterProperty => Controls.SwipeItem.CommandParameterProperty;
    //}

    //public partial class TabView : IDefaultBindCommandProperties
    //{
    //    public DependencyProperty DefaultBindCommandProperty => Controls.TabView.AddTabButtonCommandProperty;
    //    public DependencyProperty DefaultBindCommandParameterProperty => Controls.TabView.AddTabButtonCommandParameterProperty;
    //}

    public partial class ButtonBase : IDefaultBindCommandProperties
    {
        public System.Windows.DependencyProperty DefaultBindCommandProperty => Controls.Primitives.ButtonBase.CommandProperty;
        public System.Windows.DependencyProperty DefaultBindCommandParameterProperty => Controls.Primitives.ButtonBase.CommandParameterProperty;
    }
}