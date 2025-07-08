using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace WinUICsMarkupExamples.Presentation.Example;

public partial class LiveCharts2ViewModel(INavigator navigator) : BaseViewModel
{
    public ISeries[] SeriesCollection { get; set; } = [
        new LineSeries<int>(Fetch())
    ];

    static int[] Fetch()
    {
        var values = new int[100];
        var r = new Random();
        var t = 0;

        for (var i = 0; i < 100; i++)
        {
            t += r.Next(-90, 100);
            values[i] = t;
        }

        return values;
    }

    [RelayCommand] public async Task Forward() => await navigator.NavigateViewModelAsync<ScottPlotViewModel>(this);
}
