using System.Collections.Generic;
using CommunityToolkit.Mvvm.Input;

namespace WinUICsMarkupExamples.Views;

sealed partial class FlutterViewModel : BaseViewModel
{
    List<string>? subTitles;

    public string Title { get; set; } = "Flutter-Like UI markup";
    public bool ShowMore { get; set; } = true;
    public string ToggleMoreText => ShowMore ? "Less" : "More";
    public List<string> Subtitles => subTitles ??= new List<string>() { "Subtitle 1", "Subtitle 2", "Subtitle 3" };

    [RelayCommand] void ToggleMore() => ShowMore = !ShowMore;
    [RelayCommand] static void Back() => App.Current.NavigateBack();
}
