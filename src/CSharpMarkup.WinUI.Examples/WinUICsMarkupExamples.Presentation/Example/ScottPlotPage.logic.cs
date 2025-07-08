using ScottPlot;

namespace WinUICsMarkupExamples.Presentation.Example;

[UIBindable]
public sealed partial class ScottPlotPage : BasePage<ScottPlotViewModel>, IBuildUI
{
    public ScottPlotPage() => BuildUI();

    void ExampleGraph(UISp.WinUIPlot winUIPlot)
    {
        var plot = winUIPlot.Plot;
        plot.Title("Example Graph");
        plot.Add.Signal(Generate.Sin(51));
        plot.Add.Signal(Generate.Cos(51));
        winUIPlot.Refresh();
    }
}
