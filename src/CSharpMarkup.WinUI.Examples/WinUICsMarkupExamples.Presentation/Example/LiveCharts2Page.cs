using CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView;
using static CSharpMarkup.WinUI.LiveChartsCore.SkiaSharpView.Helpers;

namespace WinUICsMarkupExamples.Presentation.Example;

partial class LiveCharts2Page
{
    enum Row { Header, Body }

    public void BuildUI() => Content (
        Grid (
            Rows (
                (Row.Header, Auto),
                (Row.Body  , Star)
            ),

            NavigationBar(
                TextBlock("LiveCharts2"),
                AppBarButton() .Icon("Images/forward") .Bind(vm?.ForwardCommand)
            )  .Grid_Row(Row.Header),

            CartesianChart(ZoomMode: LiveChartsCore.Measure.ZoomAndPanMode.X)
               .Series().Bind(vm?.SeriesCollection)
               .Grid_Row(Row.Body) .HVStretch()
        )
    ) .Background(Microsoft.UI.Colors.White);
}
