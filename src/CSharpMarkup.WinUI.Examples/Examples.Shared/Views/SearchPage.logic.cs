using Microsoft.UI.Xaml.Controls;
// Note: in code behind we do NOT use CSharpMarkup.WinUI, only the UI object model.
// That is why Assign and Invoke pass the UI object to the logic, not the markup object.
// Markup object instances are not safe to use outside of a markup expression.

namespace WinUICsMarkupExamples;

sealed partial class SearchPage : Page, IBuild
{
    static readonly Tweet tweet = new();
    readonly SearchViewModel vm;

    public SearchPage()
    {
        InitializeComponent();
        DataContext = vm = App.Current.SearchViewModel;
        Background = new UI.Media.SolidColorBrush(Black);
        Build();
    }

    public void Build() => this.SetContent(Markup);
}
