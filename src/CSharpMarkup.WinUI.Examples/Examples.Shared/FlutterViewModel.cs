using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Data;

namespace WinUICsMarkupExamples;

[Bindable]
public partial class FlutterViewModel : BaseViewModel
{
    List<string>? subTitles;

    public string Title { get; set; } = "Flutter-Like UI markup";
    public bool ShowMore { get; set; } = true;
    public string ToggleMoreText => ShowMore ? "Show less" : "Show more";
    public List<string> Subtitles => subTitles ??= new List<string>() { "Subtitle 1", "Subtitle 2", "Subtitle 3" };

    [RelayCommand] void ToggleMore() => ShowMore = !ShowMore;
    [RelayCommand] static void Back() => App.Current.NavigateBack();
}
