using CSharpMarkup.Wpf;
using static CSharpMarkup.Wpf.Helpers;

namespace WpfCsMarkupExamples;

internal static class MarkupExtensions
{
    // TODO: Generate add-event helpers as member methods on markup type itself so type arguments do not have to be specified manually
    public static TextBlock OnDataContextChanged<TContext>(this TextBlock target, Action<TextBlock_UI, TContext> onChanged)
    => target.OnDataContextChanged<TextBlock, TextBlock_UI, TContext>(onChanged);

    // TODO: Replace with MetadataUpdateHandler attribute after that works for .NET hot reload in WinUI
    internal static UI.UIElement WithHotReloadButton(this UIElement content) =>
#if WINDOWS && DEBUG
        Grid(
            content.UI,

            Button("\U0001F525") .Top() .Right() .Command (new RelayCommand(App.Current.BuildUI))
        )
#else
        content
#endif
        .UI;
}