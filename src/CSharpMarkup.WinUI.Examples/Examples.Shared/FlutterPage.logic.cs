using Microsoft.UI.Xaml.Controls;

namespace WinUICsMarkupExamples;

sealed partial class FlutterPage : Page, IBuild
{
#pragma warning disable CS0649
    static readonly Button? b;
#pragma warning restore

    readonly FlutterViewModel vm;

    public FlutterPage()
    {
        InitializeComponent();
        DataContext = vm = App.Current.FlutterViewModel;
        Build();

        vm.PropertyChanged += Vm_PropertyChanged;
    }

    public void Build() => this.SetContent(Markup);

    void Vm_PropertyChanged(object? _, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(vm.ShowMore)) Build();
    }
}
