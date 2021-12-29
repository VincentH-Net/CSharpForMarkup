using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;

namespace WinUICsMarkupExamples;

public partial class FlutterPage
{
    public void Build() => Content = 
    
    VStack (
        HStack (
            Button ("\u1438") .Style (HeaderButton)
               .Width (50)
               .Bind (vm.BackCommand),

            TextBlock ()
               .VCenter ()
               .Bind (vm.Title)
        ),

        Button ()
            .Content().Bind (vm.ToggleMoreText)
            .Bind (vm.ToggleMoreCommand),

        vm.ShowMore ?
            TextBlock ("Demonstrate Flutter-like UI building features:\nConditional UI and the Spread() operator") .Center()
            : null,

        Spread (Pairs())

    )  .Background (Black) .WithHotReloadButton();

    IEnumerable<UI.UIElement> Pairs() {
        for (int i = 1; i <= 5; i++) {
            yield return TextBlock($"Field {i}:") .Margins (top: 20);
            yield return TextBox(PlaceholderText: $"Enter value for {i}");
        }
    }
}