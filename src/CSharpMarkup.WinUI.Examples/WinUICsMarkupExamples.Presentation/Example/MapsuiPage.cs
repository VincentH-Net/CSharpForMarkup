using Mui = CSharpMarkup.WinUI.Mapsui.Helpers;

namespace WinUICsMarkupExamples.Presentation.Example;

partial class MapsuiPage
{
    enum Row { Header, Body }

    public void BuildUI() => Content (
        Grid (
            Rows (
                (Row.Header, Auto),
                (Row.Body  , Star)
            ),

            NavigationBar(
                TextBlock("Mapsui"),
                AppBarButton() .Icon("Images/forward") .Bind(vm?.ForwardCommand)
            )  .Grid_Row(Row.Header),

            Mui.MapControl() .Invoke(CenterOnLocation)
               .Grid_Row(Row.Body) .HVStretch()
        )
    );
}
