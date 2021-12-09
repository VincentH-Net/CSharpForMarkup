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
            //System.Windows.Controls.AutoSuggestBox.TextProperty,
            //System.Windows.Controls.BitmapIcon.UriSourceProperty,
            //System.Windows.Controls.BitmapIconSource.UriSourceProperty,
            //System.Windows.Controls.CalendarDatePicker.DateProperty,
            //System.Windows.Controls.CalendarViewDayItem.DateProperty,
            //System.Windows.Controls.CaptureElement.SourceProperty,
            //System.Windows.Controls.ColorPicker.ColorProperty,
            System.Windows.Controls.ColumnDefinition.WidthProperty,
            System.Windows.Controls.ContentControl.ContentProperty,
            System.Windows.Controls.ContentPresenter.ContentProperty,
            //System.Windows.Controls.DatePicker.DateProperty,
            //System.Windows.Controls.DatePickerFlyout.DateProperty,
            //System.Windows.Controls.FontIcon.GlyphProperty,
            //System.Windows.Controls.FontIconSource.GlyphProperty,
            System.Windows.Controls.Image.SourceProperty,
            System.Windows.Controls.ItemsControl.ItemsSourceProperty,
            //System.Windows.Controls.ListPickerFlyout.ItemsSourceProperty,
            System.Windows.Controls.MediaElement.SourceProperty,
            //System.Windows.Controls.PasswordBox.PasswordProperty,
            //System.Windows.Controls.PathIcon.DataProperty,
            //System.Windows.Controls.PathIconSource.DataProperty,
            System.Windows.Controls.Primitives.ButtonBase.CommandProperty,
            //System.Windows.Controls.Primitives.ColorSpectrum.ColorProperty,
            System.Windows.Controls.Primitives.RangeBase.ValueProperty,
            //System.Windows.Controls.Primitives.SelectorItem.IsSelectedProperty,
            System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty,
            //System.Windows.Controls.ProgressRing.IsActiveProperty,
            //System.Windows.Controls.RatingControl.ValueProperty,
            System.Windows.Controls.RowDefinition.HeightProperty,
            //System.Windows.Controls.SplitButton.CommandProperty,
            //System.Windows.Controls.SwipeItem.CommandProperty,
            //System.Windows.Controls.SymbolIcon.SymbolProperty,
            //System.Windows.Controls.SymbolIconSource.SymbolProperty,
            System.Windows.Controls.TextBlock.TextProperty,
            System.Windows.Controls.TextBox.TextProperty,
            //System.Windows.Controls.TimePicker.TimeProperty,
            //System.Windows.Controls.TimePickerFlyout.TimeProperty,
            //System.Windows.Controls.ToggleMenuFlyoutItem.IsCheckedProperty,
            //System.Windows.Controls.ToggleSwitch.IsOnProperty,
            System.Windows.Controls.TreeView.ItemsSourceProperty,
            System.Windows.Controls.TreeViewItem.ItemsSourceProperty,
            //System.Windows.Controls.TreeViewNode.ContentProperty,

            // TODO: Complete items after last one above + from subnamespaces Documents, Input, Media, Media.Animation, Shapes

            System.Windows.Media.SolidColorBrush.ColorProperty
        };
        #endif

        // Helper signatures - codegen will generate the method body based on the parameter names and types
        // Note that for now the signature must be in the _Helpers.cs file

        public static partial TextBlock TextBlock(string Text); // Specify parameter properties

        // TODO: already defined? public static partial Run Run(string Text);
    }
}