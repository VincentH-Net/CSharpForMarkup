namespace WinUICsMarkupExamples.Presentation.Example;

[UIBindable]
public sealed partial class FlutterViewModel : BaseViewModel
{
    readonly List<string> subTitles = ["Subtitle 1", "Subtitle 2", "Subtitle 3"];

    [ObservableProperty]
    string title = "Flutter-Like UI markup";
    
    [ObservableProperty][NotifyPropertyChangedFor(nameof(ToggleMoreText))]
    bool showMore = true;
    
    public string ToggleMoreText => ShowMore ? "Less" : "More";
    
    public List<string> Subtitles => subTitles;

    [RelayCommand] void ToggleMore() => ShowMore = !ShowMore;
}
