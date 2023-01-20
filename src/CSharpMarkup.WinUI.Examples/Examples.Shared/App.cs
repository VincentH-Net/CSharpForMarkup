using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;
namespace WinUICsMarkupExamples;

partial class App
{
    static Frame Markup => Frame()
        .Resources(Implicit.Dictionary);
}
