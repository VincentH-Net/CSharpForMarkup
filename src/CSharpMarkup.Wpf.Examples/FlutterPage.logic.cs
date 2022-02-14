using System.ComponentModel;
using System.Windows.Controls;

namespace WpfCsMarkupExamples;

public sealed partial class FlutterPage : Page, IBuild
{
    readonly FlutterViewModel vm;

    public FlutterPage()
    {
        DataContext = vm = App.Current.FlutterViewModel;
        Build();

        vm.PropertyChanged += Vm_PropertyChanged;
    }

    void Vm_PropertyChanged(object? _, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(vm.ShowMore)) Build();
    }
}