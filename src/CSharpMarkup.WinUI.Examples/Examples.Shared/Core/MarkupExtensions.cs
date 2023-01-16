using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;

namespace WinUICsMarkupExamples;

internal static class MarkupExtensions
{
    // TODO: Generate add-event helpers as member methods on markup type itself so type arguments do not have to be specified manually
    public static TextBlock OnDataContextChanged<TContext>(this TextBlock target, Action<TextBlock_UI, TContext> onChanged)
    => target.OnDataContextChanged<TextBlock, TextBlock_UI, TContext>(onChanged);

    // TODO: Replace with MetadataUpdateHandler attribute after that works for .NET hot reload in WinUI
    public static void SetContent(this Microsoft.UI.Xaml.Controls.Page page, UIElement content) => page.Content =
    #if DEBUG && !(WINDOWS || HAS_UNO_WASM) // Windows has Ctrl+S support to refresh the page, WASM hot reload breaks the page redraw
        System.Diagnostics.Debugger.IsAttached
        ? Grid(
            content.UI,

            Button("\U0001F525") .Top().Right() .Command(new RelayCommand(App.Current.BuildUI))
          ).UI
        : content.UI;
    #else
      content.UI;
    #endif
}