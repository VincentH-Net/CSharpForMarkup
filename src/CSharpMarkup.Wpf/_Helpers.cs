#if GENERATE
using CSharpMarkup.Generate.WinUI;
using Controls = System.Windows.Controls;

[assembly: MarkupHelpers(
    markupHelpersType: typeof(CSharpMarkup.Wpf.Helpers),
    baseViewType: typeof(System.Windows.DependencyObject),
    contentPropertyName: "Content",
    contentControlBaseClass: typeof(Controls.ContentControl),
    childrenPropertyName: "Children",
    childrenPropertyType: typeof(Controls.UIElementCollection),
    bindablePropertyType: typeof(System.Windows.DependencyProperty)
)]
#endif

namespace CSharpMarkup.Wpf
{
    public static partial class Helpers
    {
        #if GENERATE
        /// <summary>Used by codegen to generate a <see cref="IDefaultBindProperty"/> implementation on markup types. Not used at runtime.</summary>
        /// <remarks>Types must be fully specified for codegen to work</remarks>
        static System.Windows.DependencyProperty[] DefaultBindProperties => new System.Windows.DependencyProperty[]
        {
            System.Windows.Controls.ColumnDefinition.WidthProperty,
            System.Windows.Controls.ContentControl.ContentProperty,
            System.Windows.Controls.ContentPresenter.ContentProperty,

            System.Windows.Controls.Image.SourceProperty,
            System.Windows.Controls.ItemsControl.ItemsSourceProperty,

            System.Windows.Controls.MediaElement.SourceProperty,

            System.Windows.Controls.Primitives.ButtonBase.CommandProperty,

            System.Windows.Controls.Primitives.RangeBase.ValueProperty,

            System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty,

            System.Windows.Controls.RowDefinition.HeightProperty,

            System.Windows.Controls.TextBlock.TextProperty,
            System.Windows.Controls.TextBox.TextProperty,

            System.Windows.Controls.TreeView.ItemsSourceProperty,
            System.Windows.Controls.TreeViewItem.ItemsSourceProperty,

            // TODO: Complete items after last one above + from subnamespaces Documents, Input, Media, Media.Animation, Shapes

            System.Windows.Media.SolidColorBrush.ColorProperty
        };
        #endif

        // Helper signatures - codegen will generate the method body based on the parameter names and types
        // Note that for now the signature must be in the _Helpers.cs file

        public static partial TextBlock TextBlock(string Text); // Specify parameter properties
    }
}