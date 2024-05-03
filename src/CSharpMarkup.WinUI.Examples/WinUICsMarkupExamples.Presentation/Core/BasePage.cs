namespace WinUICsMarkupExamples.Presentation.Core;

partial class BasePage
{
    new protected Page Content(UIElement content) => this.Content(ShowTools,
        content
           .SafeArea_Insets().All()
           .UI
    )  .Background(ThemeResource.ApplicationPageBackgroundThemeBrush);
}
