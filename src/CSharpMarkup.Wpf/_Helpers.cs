#if GENERATE
using CSharpMarkup.Generate.WinUI;
using Controls = System.Windows.Controls;

[assembly: MarkupHelpers(
    markupHelpersType: typeof(CSharpMarkup.Wpf.Helpers),
    baseViewType: typeof(System.Windows.Threading.DispatcherObject),
    bindablePropertyType: typeof(System.Windows.DependencyProperty)
)]
#endif

namespace CSharpMarkup.Wpf
{
    public static partial class Helpers
    {
        #if GENERATE
        /// <summary>Used by codegen to generate a <see cref="IDefaultBindProperty"/> implementation on markup types. Not used at runtime.</summary>
        /// <remarks>
        /// - Types must be fully specified for codegen to work
        /// - A default property for a derived type hides any default properties of it's base types
        /// </remarks>
        static System.Windows.DependencyProperty[] DefaultBindProperties => new System.Windows.DependencyProperty[]
        {
            System.Windows.Controls.Calendar.SelectedDateProperty,
            System.Windows.Controls.ColumnDefinition.WidthProperty,
            System.Windows.Controls.ContentControl.ContentProperty,
            System.Windows.Controls.ContentPresenter.ContentProperty, // TODO: or remove and select more useful defaults for derived controls?
            System.Windows.Controls.DatePicker.SelectedDateProperty,
            System.Windows.Controls.Expander.IsExpandedProperty,
            System.Windows.Controls.FlowDocumentReader.DocumentProperty,
            System.Windows.Controls.FlowDocumentScrollViewer.DocumentProperty,
            System.Windows.Controls.Image.SourceProperty,
            System.Windows.Controls.InkPresenter.StrokesProperty,
            System.Windows.Controls.ItemsControl.ItemsSourceProperty,
            System.Windows.Controls.KeyTipControl.TextProperty,
            System.Windows.Controls.Label.TargetProperty,
            System.Windows.Controls.MediaElement.SourceProperty,
            System.Windows.Controls.Page.TitleProperty,
            System.Windows.Controls.RowDefinition.HeightProperty,
            System.Windows.Controls.SoundPlayerAction.SourceProperty,
            System.Windows.Controls.SpellCheck.IsEnabledProperty,
            System.Windows.Controls.TextBlock.TextProperty,
            System.Windows.Controls.TextBox.TextProperty,
            System.Windows.Controls.Viewport3D.ChildrenProperty,

            System.Windows.Controls.Primitives.ButtonBase.CommandProperty,
            System.Windows.Controls.Primitives.DocumentViewerBase.DocumentProperty,
            System.Windows.Controls.Primitives.GridViewRowPresenterBase.ColumnsProperty,
            System.Windows.Controls.Primitives.RangeBase.ValueProperty,
            System.Windows.Controls.Primitives.SelectiveScrollingGrid.SelectiveScrollingOrientationProperty,
            System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty,
            System.Windows.Controls.Primitives.Track.ValueProperty,

            // TODO: Complete items after last one above + from subnamespaces Documents, Input, Media, Media.Animation, Shapes

            System.Windows.Media.SolidColorBrush.ColorProperty
        };
        #endif

        // Helper signatures - codegen will generate the method body based on the parameter names and types
        // Note that for now the signature must be in the _Helpers.cs file

        public static partial TextBlock TextBlock(string Text); // Specify parameter properties
    }
}