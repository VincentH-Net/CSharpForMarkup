namespace WinUICsMarkupExamples.Presentation.Example;

[UIBindable]
public sealed partial class SearchPage : BasePage<SearchViewModel>, IBuildUI
{
    static readonly Tweet tweet = new();

    public SearchPage()
    {
        DataContextChanged += (_, _) =>
        {
            if (vm is not null) BuildUI();
        };
    }
}
