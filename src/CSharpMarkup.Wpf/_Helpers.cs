#if GENERATE
using CSharpMarkup.Generate.WinUI;
using Controls = Microsoft.UI.Xaml.Controls;

[assembly: MarkupHelpers(
    markupHelpersType: typeof(Microsoft.UI.Markup.Helpers),
    baseViewType: typeof(Microsoft.UI.Xaml.DependencyObject),
    contentPropertyName: "Content",
    contentControlBaseClass: typeof(Controls.ContentControl),
    childrenPropertyName: "Children",
    childrenPropertyType: typeof(Controls.UIElementCollection),
    bindablePropertyType: typeof(Microsoft.UI.Xaml.DependencyProperty)
)]
#endif

namespace Microsoft.UI.Markup
{
    public static partial class Helpers
    {
        #if GENERATE
        /// <summary>Used by codegen to generate a <see cref="IDefaultBindProperty"/> implementation on markup types. Not used at runtime.</summary>
        /// <remarks>Types must be fully specified for codegen to work</remarks>
        static Xaml.DependencyProperty[] DefaultBindProperties => new Xaml.DependencyProperty[]
        {
            Microsoft.UI.Xaml.Controls.AutoSuggestBox.TextProperty,
            Microsoft.UI.Xaml.Controls.BitmapIcon.UriSourceProperty,
            Microsoft.UI.Xaml.Controls.BitmapIconSource.UriSourceProperty,
            Microsoft.UI.Xaml.Controls.CalendarDatePicker.DateProperty,
            Microsoft.UI.Xaml.Controls.CalendarViewDayItem.DateProperty,
            Microsoft.UI.Xaml.Controls.CaptureElement.SourceProperty,
            Microsoft.UI.Xaml.Controls.ColorPicker.ColorProperty,
            Microsoft.UI.Xaml.Controls.ColumnDefinition.WidthProperty,
            Microsoft.UI.Xaml.Controls.ContentControl.ContentProperty,
            Microsoft.UI.Xaml.Controls.ContentPresenter.ContentProperty,
            Microsoft.UI.Xaml.Controls.DatePicker.DateProperty,
            Microsoft.UI.Xaml.Controls.DatePickerFlyout.DateProperty,
            Microsoft.UI.Xaml.Controls.FontIcon.GlyphProperty,
            Microsoft.UI.Xaml.Controls.FontIconSource.GlyphProperty,
            Microsoft.UI.Xaml.Controls.Image.SourceProperty,
            Microsoft.UI.Xaml.Controls.ItemsControl.ItemsSourceProperty,
            Microsoft.UI.Xaml.Controls.ListPickerFlyout.ItemsSourceProperty,
            Microsoft.UI.Xaml.Controls.MediaElement.SourceProperty,
            Microsoft.UI.Xaml.Controls.PasswordBox.PasswordProperty,
            Microsoft.UI.Xaml.Controls.PathIcon.DataProperty,
            Microsoft.UI.Xaml.Controls.PathIconSource.DataProperty,
            Microsoft.UI.Xaml.Controls.Primitives.ButtonBase.CommandProperty,
            Microsoft.UI.Xaml.Controls.Primitives.ColorSpectrum.ColorProperty,
            Microsoft.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty,
            Microsoft.UI.Xaml.Controls.Primitives.SelectorItem.IsSelectedProperty,
            Microsoft.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty,
            Microsoft.UI.Xaml.Controls.ProgressRing.IsActiveProperty,
            Microsoft.UI.Xaml.Controls.RatingControl.ValueProperty,
            Microsoft.UI.Xaml.Controls.RowDefinition.HeightProperty,
            Microsoft.UI.Xaml.Controls.SplitButton.CommandProperty,
            Microsoft.UI.Xaml.Controls.SwipeItem.CommandProperty,
            Microsoft.UI.Xaml.Controls.SymbolIcon.SymbolProperty,
            Microsoft.UI.Xaml.Controls.SymbolIconSource.SymbolProperty,
            Microsoft.UI.Xaml.Controls.TextBlock.TextProperty,
            Microsoft.UI.Xaml.Controls.TextBox.TextProperty,
            Microsoft.UI.Xaml.Controls.TimePicker.TimeProperty,
            Microsoft.UI.Xaml.Controls.TimePickerFlyout.TimeProperty,
            Microsoft.UI.Xaml.Controls.ToggleMenuFlyoutItem.IsCheckedProperty,
            Microsoft.UI.Xaml.Controls.ToggleSwitch.IsOnProperty,
            Microsoft.UI.Xaml.Controls.TreeView.ItemsSourceProperty,
            Microsoft.UI.Xaml.Controls.TreeViewItem.ItemsSourceProperty,
            Microsoft.UI.Xaml.Controls.TreeViewNode.ContentProperty,

            // TODO: Complete items after last one above + from subnamespaces Documents, Input, Media, Media.Animation, Shapes

            Microsoft.UI.Xaml.Media.SolidColorBrush.ColorProperty
        };
        #endif

        // Helper signatures - codegen will generate the method body based on the parameter names and types
        // Note that for now the signature must be in the _Helpers.cs file

        public static partial TextBlock TextBlock(string Text); // Specify parameter properties

        public static partial Run Run(string Text);
    }
}