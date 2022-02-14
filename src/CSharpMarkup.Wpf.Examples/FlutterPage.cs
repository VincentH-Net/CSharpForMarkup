using System.Linq;
using CSharpMarkup.Wpf;
using static CSharpMarkup.Wpf.Helpers;
namespace WpfCsMarkupExamples;

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

        Button (TextBlock().Bind(vm.ToggleMoreText))
           .Bind (vm.ToggleMoreCommand),

        vm.ShowMore ?
            TextBlock ("Demonstrate Flutter-like UI building features:\nConditional UI and the Spread() operator") .Center()
            : null,

        TextBlock ("Subtitles:"),
        Spread (Subtitles),

        TextBlock ("Pairs:"),
        Spread (Pairs())

    )  .Background (SolidColorBrush(Black)) .TextBlock_Foreground(SolidColorBrush(White))  .WithHotReloadButton();

    IEnumerable<UI.UIElement> Subtitles => vm.Subtitles.Select(subtitle => TextBlock(subtitle) .Margin (0, 5) .UI);

    IEnumerable <UI.UIElement> Pairs() {
        for (int i = 1; i <= 5; i++) {
            yield return TextBlock($"Field {i}:") .Margins (top: 20);
            yield return TextBox(Text: $"Enter value for {i}");
        }
    }
}