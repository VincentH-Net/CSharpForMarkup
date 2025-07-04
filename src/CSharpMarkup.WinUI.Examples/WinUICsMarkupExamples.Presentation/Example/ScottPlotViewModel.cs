namespace WinUICsMarkupExamples.Presentation.Example;

public partial class ScottPlotViewModel(INavigator navigator) : BaseViewModel
{
    [RelayCommand] public async Task Forward() => await navigator.NavigateViewModelAsync<FlutterViewModel>(this);
}
