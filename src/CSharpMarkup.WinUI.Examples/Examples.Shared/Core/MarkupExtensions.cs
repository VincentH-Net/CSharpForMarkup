using Microsoft.UI.Markup;
using static Microsoft.UI.Markup.Helpers;

namespace WinUICsMarkupExamples;

internal static class MarkupExtensions
{
    internal static UI.UIElement WithHotReloadButton(this UIElement content) =>
#if WINDOWS && DEBUG // TODO: Replace with MetadataUpdateHandler attribute after that works for .NET hot reload in WinUI
        Grid(
            content.UI,

            Button("\U0001F525").Top().Right().Command(new RelayCommand(App.Current.BuildWindowContent))
        )
#else
        content
#endif
        .UI;
}