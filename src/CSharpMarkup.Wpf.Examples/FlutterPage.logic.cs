// IMPORTANT:
// In <page>.cs:
// Include CSharpMarkup namespace usings but no UI objectmodel usings.
// You *can* also use the UI objectmodel safely in <page>.cs; a good practice then is to
// define a "global using TypeName_UI = <UI objectmodel namespace>.TypeName" alias in GlobalUsings.cs

// In <page>.logic.cs:
// DO NOT include CSharpMarkup namespace usings and DO NOT use CSharpMarkup objects.
// Markup object instances are not safe to use outside of a markup expression (due to performance features).
// That is why Assign and Invoke pass the UI object to the logic, not the markup object.
using System.ComponentModel;
namespace WpfCsMarkupExamples;

internal sealed partial class FlutterPage : BasePage, IBuild
{
    readonly FlutterViewModel vm;

    public FlutterPage()
    {
        DataContext = vm = App.Current!.FlutterViewModel;
        Build();

        vm.PropertyChanged += Vm_PropertyChanged; // This is MVVM, but other update models can be hooked up here as well
    }

    void Vm_PropertyChanged(object? _, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(vm.ShowMore)) Build();
    }
}