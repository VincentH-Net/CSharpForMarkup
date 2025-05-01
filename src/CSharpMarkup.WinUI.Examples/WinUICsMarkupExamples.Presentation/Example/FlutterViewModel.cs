namespace WinUICsMarkupExamples.Presentation.Example;

[UIBindable]
public sealed partial class FlutterViewModel : BaseViewModel
{
    readonly List<string> subTitles = ["Subtitle 1", "Subtitle 2", "Subtitle 3"];

    [ObservableProperty]
    public partial string Title { get; set; } = "Flutter-Like UI markup";
    
    [ObservableProperty][NotifyPropertyChangedFor(nameof(ToggleMoreText))]
    public partial bool ShowMore { get; set; } = true;
    
    public string ToggleMoreText => ShowMore ? "Less" : "More";
    
    public List<string> Subtitles => subTitles;

    [RelayCommand] void ToggleMore() => ShowMore = !ShowMore;
}
