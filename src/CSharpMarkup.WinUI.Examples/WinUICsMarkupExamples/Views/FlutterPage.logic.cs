// IMPORTANT: do not use CSharpMarkup.WinUI objects in this UI logic file; only use them in C# markup files. 
// using Microsoft.UI.Xaml.Controls here is fine; see https://github.com/VincentH-Net/CSharpForMarkup#namespace-separation-of-markup-and-ui-logic

namespace WinUICsMarkupExamples.Views;

[UI.Data.Bindable]
public sealed partial class FlutterPage : BasePage, IBuildUI
{
#pragma warning disable CS0649
    static readonly Controls.Button? b;
#pragma warning restore
    readonly FlutterViewModel vm = new();

    public FlutterPage()
    {
        DataContext = vm = App.Current.FlutterViewModel;
        BuildUI();
        vm.PropertyChanged += (s, e) => { if (e.PropertyName == nameof(vm.ShowMore)) BuildUI(); };
    }
}
