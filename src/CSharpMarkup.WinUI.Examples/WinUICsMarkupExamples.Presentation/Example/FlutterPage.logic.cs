namespace WinUICsMarkupExamples.Presentation.Example;

[UIBindable]
public sealed partial class FlutterPage : BasePage<FlutterViewModel>, IBuildUI
{
#pragma warning disable CS0649
    static readonly UIControls.Button? b;
#pragma warning restore

    public FlutterPage()
    {
        DataContextChanged += (_, _) =>
        {
            if (vm is null) return;
            BuildUI();
            vm.PropertyChanged += (_, e) => { if (e.PropertyName == nameof(vm.ShowMore)) BuildUI(); };
        };
    }
}
