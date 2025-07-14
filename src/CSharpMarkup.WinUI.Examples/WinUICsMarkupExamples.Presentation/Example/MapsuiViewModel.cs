namespace WinUICsMarkupExamples.Presentation.Example;

public partial class MapsuiViewModel(INavigator navigator) : BaseViewModel
{
    [RelayCommand] public async Task Forward() => await navigator.NavigateViewModelAsync<FlutterViewModel>(this);
}
