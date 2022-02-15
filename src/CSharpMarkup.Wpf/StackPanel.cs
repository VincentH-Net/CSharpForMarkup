using Windows = System.Windows;

namespace CSharpMarkup.Wpf
{
    public static partial class Helpers
    {
        ///<summary>Short for:<code>StackPanel().Orientation().Horizontal()</code></summary>  // TODO: see if we can generate this from the attribute
        [ShortFor("StackPanel().Orientation().Horizontal()")]
        public static StackPanel HStack(params Windows.UIElement[] children) => StackPanel(children).Orientation().Horizontal();

        ///<summary>Short for:<code>StackPanel().Orientation().Vertical()</code></summary>
        [ShortFor("StackPanel().Orientation().Vertical()")]
        public static StackPanel VStack(params Windows.UIElement[] children) => StackPanel(children).Orientation().Vertical();

        /// <summary>Add children to a Panel</summary>
        /// <remarks>This method is only safe when used stand-alone or at the end of a fluent call chain. To enforce this, it does not return the this parameter</remarks>
        public static void Children(this Panel panel, params Windows.UIElement[] children)
        {
            foreach (var child in children) panel.UI.Children.Add(child);
        }
    }
}