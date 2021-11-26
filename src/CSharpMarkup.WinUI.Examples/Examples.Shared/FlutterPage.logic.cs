using Microsoft.UI.Xaml.Controls;

namespace WinUICsMarkupExamples;

public sealed partial class FlutterPage : Page, IBuild
{
    readonly FlutterViewModel vm;

    public FlutterPage()
    {
        InitializeComponent();
        DataContext = vm = App.Current.FlutterViewModel;
        Build();

        vm.PropertyChanged += Vm_PropertyChanged;
    }

    void Vm_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(vm.ShowMore)) Build();
    }
}