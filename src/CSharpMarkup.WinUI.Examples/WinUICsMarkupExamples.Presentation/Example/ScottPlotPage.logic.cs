using ScottPlot;

namespace WinUICsMarkupExamples.Presentation.Example;

[UIBindable]
public sealed partial class ScottPlotPage : BasePage<ScottPlotViewModel>, IBuildUI
{
    public ScottPlotPage() => BuildUI();

    void ExampleGraph(UIScottPlot.WinUIPlot plot)
    {
        plot.Plot.Title("Example Graph");
        plot.Plot.Add.Signal(Generate.Sin(51));
        plot.Plot.Add.Signal(Generate.Cos(51));
        plot.Refresh();
    }
}
