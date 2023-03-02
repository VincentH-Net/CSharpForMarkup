// IMPORTANT: do not use CSharpMarkup.WinUI objects in this UI logic file; only use them in C# markup files. 
// using Microsoft.UI.Xaml.Controls here is fine; see https://github.com/VincentH-Net/CSharpForMarkup#namespace-separation-of-markup-and-ui-logic

namespace WinUICsMarkupExamples.Views;

[UI.Data.Bindable]
public sealed partial class SearchPage : BasePage, IBuildUI
{
    static readonly Tweet tweet = new();
    readonly SearchViewModel vm = new();

    public SearchPage()
    {
        DataContext = vm = App.Current.SearchViewModel;
        BuildUI();
    }
}
