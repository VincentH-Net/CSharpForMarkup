namespace WinUICsMarkupExamples.Presentation.Example;

partial class Shell
{
    public void BuildUI() => Content (
        Border (
            ExtendedSplashScreen()
               .HVStretch() .StretchContent()
               .LoadingContentTemplate(DataTemplate(() =>
                    Grid(
                        Rows(Stars(2), Star),

                        ProgressRing() .Grid_Row(1) .Center() .Size(100)
                    )
                ))
               .Invoke(splash => ContentControl = splash)
        )  .Background(ThemeResource.ApplicationPageBackgroundThemeBrush)
    );
}
