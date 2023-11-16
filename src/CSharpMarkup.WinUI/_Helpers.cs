using Xaml = Microsoft.UI.Xaml;
#if GENERATE
using CSharpMarkup.Generate.WinUI;
using Controls = Microsoft.UI.Xaml.Controls;

[assembly: MarkupHelpers(
    markupHelpersType: typeof(CSharpMarkup.WinUI.Helpers)
)]
#endif

namespace CSharpMarkup.WinUI
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

            // TODO: Consider supporting UNO-only Reveal* brush types
            
            Microsoft.UI.Xaml.Media.ImageBrush.ImageSourceProperty,
            Microsoft.UI.Xaml.Media.SolidColorBrush.ColorProperty,
        };
        #endif
        
        /* TODO: Enable to specify DefaultBindProperties that exist in UNO but not in WinUI, e.g.:
           Microsoft.UI.Xaml.Controls.CaptureElement.SourceProperty,
           Microsoft.UI.Xaml.Controls.MediaElement.SourceProperty,
           This could be done by copying the entire array in source within #if HAS_UNO #else
           Not worth it for just two properties so postpone.
        */

        // Helper signatures - codegen will generate the method body based on the parameter names and types
        // Note that this allows full control over the generated overloads; codegen will not generate methods
        // with the same set of parameter names (irrespective of order) as in a partial helper
        // Note that for now the signature must be in the _Helpers.cs file

        public static partial TextBlock TextBlock(string Text); // Specify parameter properties
        public static partial GradientStop GradientStop(Windows.UI.Color Color, double Offset);

        static partial void Timeline_IncludeInDerived(System.TimeSpan? BeginTime, Microsoft.UI.Xaml.Duration Duration);
        // Specify parameter properties to include them in derived types

#if HAS_UNO
        /// <summary>Create a <see cref="Xaml.Controls.ContentPresenter"/></summary>
        /// <remarks>Remark: ContentPresenter().Bind() binds to <see cref="Xaml.Controls.ContentPresenter.ContentProperty"/></remarks>
        public static ContentPresenter ContentPresenter()
        {
            var ui = new Xaml.Controls.ContentPresenter();
            var markup = CSharpMarkup.WinUI.ContentPresenter.StartChain(ui);

            // In UNO the implicit binding to Content* properties that should happen when the ContentPresenter is in a ControlTemplate
            // (see https://docs.microsoft.com/en-us/windows/winui/api/microsoft.ui.xaml.controls.contentpresenter?view=winui-3.0#remarks)
            // does not happen; see UNO issues https://github.com/unoplatform/uno/issues/857 and https://github.com/unoplatform/uno/issues/6452
            // Below is a workaround to do this implicit binding if the ContentPresenter is in a ControlTemplate.
            if (buildingControlTemplate)
                markup.Content().BindTemplate("Content")
                      .ContentTemplate().BindTemplate("ContentTemplate")
                      .ContentTemplateSelector().BindTemplate("ContentTemplateSelector");

            return markup;
        }
#else // WINUI
        /// <summary>Create a <see cref="Xaml.Controls.ContentPresenter"/></summary>
        /// <remarks>Remark: ContentPresenter().Bind() binds to <see cref="Xaml.Controls.ContentPresenter.ContentProperty"/></remarks>
        public static ContentPresenter ContentPresenter()
        {
            var ui = new Xaml.Controls.ContentPresenter();
            var markup = CSharpMarkup.WinUI.ContentPresenter.StartChain(ui);

            // In WinUI we use a workaround to simulate template bindings, so we have to explicitly create equivalent bindings
            // for the bindings that ContentPresenter creates by default.
            if (DependencyObjectExtensions.TemplatedParent is not null)
                markup.Content().BindTemplate("Content")
                      .ContentTemplate().BindTemplate("ContentTemplate")
                      .ContentTemplateSelector().BindTemplate("ContentTemplateSelector");

            return markup;
        }
#endif

        /// <summary>This helper allows to configure an existing UI framework page object instance, i.e. when a page instance is created by the UI framework when specifying the page type in navigation</summary>
        /// <param name="overlayDevTools">Add am ovverlay woth developer tools - currently just a manual hot reload button for platforms that do not yet automatically update</param>
        public static Page Content(this Xaml.Controls.Page page, Xaml.UIElement content, bool overlayDevTools = false)
        {
            page.Content = overlayDevTools && (page is IBuildUI build)
            ? MonochromaticOverlayPresenter(
                content,
                Button("🔥") .Style(ThemeResource.ButtonRevealStyle) .Bottom() .Right()
                   .Invoke(b => b.Click += (_, _) => build.BuildUI())
              )
            : content;

            return page;
        }
    }
}