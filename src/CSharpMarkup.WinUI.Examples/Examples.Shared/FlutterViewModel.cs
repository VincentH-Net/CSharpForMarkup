using Microsoft.UI.Xaml.Data;

namespace WinUICsMarkupExamples;

[Bindable]
public class FlutterViewModel : BaseViewModel
{
    ICommand toggleMoreCommand, backCommand;

    List<string> subTitles;

    public string Title { get; set; } = "Flutter-Like UI markup";
    public bool ShowMore { get; set; } = true;
    public string ToggleMoreText => ShowMore ? "Show less" : "Show more";
    public List<string> Subtitles => subTitles ??= new List<string>() { "Subtitle 1", "Subtitle 2", "Subtitle 3" };

    public ICommand ToggleMoreCommand => toggleMoreCommand ??= new RelayCommand(ToggleMore);
    public ICommand BackCommand => backCommand ??= new RelayCommand(Back);

    void ToggleMore() { ShowMore = !ShowMore; }
    void Back() => App.Current.NavigateBack();
}