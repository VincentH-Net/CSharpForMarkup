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
            //Controls.AutoSuggestBox.TextProperty,
            //Controls.BitmapIcon.UriSourceProperty,
            //Controls.BitmapIconSource.UriSourceProperty,
            //Controls.CalendarDatePicker.DateProperty,
            //Controls.CalendarViewDayItem.DateProperty,
            //Controls.CaptureElement.SourceProperty,
            //Controls.ColorPicker.ColorProperty,
            Controls.ColumnDefinition.WidthProperty,
            Controls.ContentControl.ContentProperty,
            Controls.ContentPresenter.ContentProperty,
            //Controls.DatePicker.DateProperty,
            //Controls.DatePickerFlyout.DateProperty,
            //Controls.FontIcon.GlyphProperty,
            //Controls.FontIconSource.GlyphProperty,
            Controls.Image.SourceProperty,
            Controls.ItemsControl.ItemsSourceProperty,
            //Controls.ListPickerFlyout.ItemsSourceProperty,
            Controls.MediaElement.SourceProperty,
            //Controls.PasswordBox.PasswordProperty,
            //Controls.PathIcon.DataProperty,
            //Controls.PathIconSource.DataProperty,
            Controls.Primitives.ButtonBase.CommandProperty,
            //Controls.Primitives.ColorSpectrum.ColorProperty,
            Controls.Primitives.RangeBase.ValueProperty,
            //Controls.Primitives.SelectorItem.IsSelectedProperty,
            Controls.Primitives.ToggleButton.IsCheckedProperty,
            //Controls.ProgressRing.IsActiveProperty,
            //Controls.RatingControl.ValueProperty,
            Controls.RowDefinition.HeightProperty,
            //Controls.SplitButton.CommandProperty,
            //Controls.SwipeItem.CommandProperty,
            //Controls.SymbolIcon.SymbolProperty,
            //Controls.SymbolIconSource.SymbolProperty,
            Controls.TextBlock.TextProperty,
            Controls.TextBox.TextProperty,
            //Controls.TimePicker.TimeProperty,
            //Controls.TimePickerFlyout.TimeProperty,
            //Controls.ToggleMenuFlyoutItem.IsCheckedProperty,
            //Controls.ToggleSwitch.IsOnProperty,
            Controls.TreeView.ItemsSourceProperty,
            Controls.TreeViewItem.ItemsSourceProperty,
            //Controls.TreeViewNode.ContentProperty,

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