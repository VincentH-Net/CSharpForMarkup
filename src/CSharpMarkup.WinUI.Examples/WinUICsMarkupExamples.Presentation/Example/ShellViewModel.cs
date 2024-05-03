namespace WinUICsMarkupExamples.Presentation.Example;

[UIBindable]
public class ShellViewModel : BaseViewModel
{
    readonly INavigator _navigator;

    public ShellViewModel(INavigator navigator)
    {
        _navigator = navigator;
        _ = Start();
    }

    public async Task Start() => await _navigator.NavigateViewModelAsync<SearchViewModel>(this);
}
