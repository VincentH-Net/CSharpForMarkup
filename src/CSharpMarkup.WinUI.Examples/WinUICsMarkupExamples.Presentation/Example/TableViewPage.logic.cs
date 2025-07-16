namespace WinUICsMarkupExamples.Presentation.Example;

[UIBindable]
public sealed partial class TableViewPage : BasePage<TableViewViewModel>, IBuildUI
{
    public TableViewPage() => BuildUI();
}
