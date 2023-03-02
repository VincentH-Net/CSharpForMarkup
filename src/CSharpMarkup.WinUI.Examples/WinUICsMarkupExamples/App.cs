using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;
// IMPORTANT: avoid Microsoft.UI.Xaml namespace usings in markup files; see https://github.com/VincentH-Net/CSharpForMarkup#namespace-separation-of-markup-and-ui-logic

namespace WinUICsMarkupExamples;

partial class App
{
    UIElement MainWindowContent => 
        Frame() .Assign(out rootFrame) .Resources (Implicit.Dictionary) .HotReloadOverlay();
}
