using System.Collections.Generic;
using System.Linq;
using CSharpMarkup.WinUI;
using static CSharpMarkup.WinUI.Helpers;
// IMPORTANT: avoid Microsoft.UI.Xaml namespace usings in markup files; see https://github.com/VincentH-Net/CSharpForMarkup#namespace-separation-of-markup-and-ui-logic

namespace WinUICsMarkupExamples.Views;

partial class FlutterPage
{
    public void BuildUI() => this.Content(VStack (
        HStack (
            Button ("\u1438") .Style (HeaderButton)
               .Width (50)
               .Bind (vm.BackCommand),

            TextBlock ()
               .VCenter ()
               .Bind (vm.Title)
        ),

        Button ("Point here to see\nVisual State Manager in action!")
           .Template (XamlTo<Controls.ControlTemplate>("""
            <ControlTemplate TargetType="Button">
              <Grid >
                <VisualStateManager.VisualStateGroups>
                  <VisualStateGroup x:Name="CommonStates">
                    <VisualStateGroup.Transitions>
                      <!--Take one half second to transition to the PointerOver state.-->
                      <VisualTransition To="PointerOver" GeneratedDuration="0:0:0.5"/>
                    </VisualStateGroup.Transitions>

                    <VisualState x:Name="Normal" />

                    <!--Change the SolidColorBrush, ButtonBrush, to red when the Pointer is over the button.-->
                    <VisualState x:Name="PointerOver">
                      <Storyboard>
                        <ColorAnimation Storyboard.TargetName="ButtonBrush" Storyboard.TargetProperty="Color" To="Red" />
                      </Storyboard>
                    </VisualState>
                  </VisualStateGroup>
                </VisualStateManager.VisualStateGroups>
                <Grid.Background>
                  <SolidColorBrush x:Name="ButtonBrush" Color="Green"/>
                </Grid.Background>
                <ContentPresenter />
              </Grid>
            </ControlTemplate>
            """)),

        Button () .Template (RoundButton)
           .Foreground (Black) .Background (Gold) .Size (75)
           .Content().Bind (vm.ToggleMoreText)
           .Bind (vm.ToggleMoreCommand),

        vm.ShowMore ?
            Border (
                TextBlock ("Demonstrate Flutter-like UI building features:\nConditional UI and the Spread() operator")
                   .Style().AppResource ("MyTextBlockStyle")
            )  .Background (ThemeResource.InfoBarSuccessSeverityBackgroundBrush)
            : null,

        TextBlock ("Subtitles:"),
        Spread (Subtitles),

        TextBlock ("Pairs:"),
        Spread (Pairs())
    )) .Background (Black);

    IEnumerable<UI.UIElement> Subtitles => vm.Subtitles.Select(subtitle => TextBlock(subtitle).Margin(0, 5).UI);

    static IEnumerable<UI.UIElement> Pairs()
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
            ContentPresenter ()
                .Center ()
        ));
}
