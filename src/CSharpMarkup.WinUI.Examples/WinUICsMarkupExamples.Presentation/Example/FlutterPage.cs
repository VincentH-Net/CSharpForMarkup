namespace WinUICsMarkupExamples.Presentation.Example;

partial class FlutterPage
{
    enum Row { Header, Body }

    public void BuildUI() => Content ( VStack (
        NavigationBar()
            .MainCommand(
                AppBarButton() .Icon(Icon("Images/back"))
            )
            .Content().Bind(vm?.Title),

        Button("Button with default style"),

        Button("Button with AccentButtonStyle").Style(ThemeResource.AccentButtonStyle),

        Button("Point here to see\nVisual State Manager in action!")
           .Style().AppResource("AnimatedButtonStyle") .Width(200) .Height(75),

        Button () .Template (RoundButton)
           .Foreground (Black) .Background (Gold) .Size (75)
           .Content().Bind (vm?.ToggleMoreText)
           .Bind (vm?.ToggleMoreCommand),

        vm!.ShowMore ?
            Border (
                TextBlock ("Demonstrate Flutter-like UI building features:\nConditional UI and the Spread() operator")
            )  .Background (ThemeResource.InfoBarSuccessSeverityBackgroundBrush)
            : null,

        TextBlock ("Subtitles:"),
        Spread (Subtitles),

        TextBlock ("Pairs:"),
        Spread (Pairs())
    ));

    IEnumerable<UI.Xaml.UIElement> Subtitles => vm!.Subtitles.Select(subtitle => TextBlock(subtitle).Margin(0, 5).UI);

    static IEnumerable<UI.Xaml.UIElement> Pairs()
    {
        for (int i = 1; i <= 5; i++)
        {
            yield return TextBlock($"Field {i}:").Margins(top: 20);
            yield return TextBox(PlaceholderText: $"Enter value for {i}");
        }
    }

    static ControlTemplate RoundButton => ControlTemplate(typeof(Button), () =>
        Grid(
            Ellipse()
                .Fill().BindTemplate (b?.Background)
                .Stroke().BindTemplate (b?.Foreground),
            ContentPresenter()
                .Center()
        ));
}
