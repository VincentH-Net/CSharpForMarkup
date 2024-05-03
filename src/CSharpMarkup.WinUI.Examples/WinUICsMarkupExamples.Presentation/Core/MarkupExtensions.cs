using System.Windows.Input;

namespace WinUICsMarkupExamples.Presentation.Core;

static class MarkupExtensions
{
    /// <summary>Set <see cref="Xaml.Controls.AppBarButton.Icon"/></summary>
    public static TView Icon<TView>(this TView view, string appAsset) where TView : AppBarButton
    => view.Icon(MarkupHelpers.Icon(appAsset));

    public static TView OnClick<TView>(this TView view, ICommand command) where TView : ButtonBase
    { 
        view.UI.Click += (_, _) => command.Execute(null); 
        return view;
    }

    public static TextBlock OnDataContextChanged<TContext>(this TextBlock target, Action<UIControls.TextBlock, TContext> onChanged)
    => target.OnDataContextChanged<TextBlock, UIControls.TextBlock, TContext>(onChanged);

    // Add any application-specific Markup extensions here
}

static class MarkupHelpers
{
    internal static UIControls.BitmapIcon Icon(string appAsset) => BitmapIcon(UriSource: new Uri($"ms-appx:///Assets/{appAsset}.png"));

    internal static Image Image(string appAsset) => CSharpMarkup.WinUI.Helpers.Image(Source: BitmapImage(new Uri($"ms-appx:///Assets/{appAsset}.png")));

    internal static TextBlock ExampleFooter() => TextBlock(
        Span("Built with C# Markup "), Span("2") .FontSize(18), Span(" for Uno")
    )  .FontStyle().Italic()
       .Bottom() .HCenter();

    // Add more application-specific Markup helpers here
}
