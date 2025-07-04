namespace WinUICsMarkupExamples.Presentation.Example;

partial class ScottPlotPage
{
    enum Row { Header, Body }

    public void BuildUI() => Content (
        Grid (
            Rows (
                (Row.Header, Auto),
                (Row.Body  , Star)
            ),

        NavigationBar(
            TextBlock("ScottPlot"),
            AppBarButton() .Icon("Images/forward") .Bind(vm?.ForwardCommand)
        )  .Grid_Row(Row.Header),

        WinUIPlot() .Invoke(ExampleGraph)
           .Grid_Row(Row.Body) .HVStretch()
        )
    );
}
