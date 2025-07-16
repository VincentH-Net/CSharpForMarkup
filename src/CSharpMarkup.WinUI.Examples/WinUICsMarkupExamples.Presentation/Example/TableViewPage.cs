#if !WINDOWS
using static CSharpMarkup.WinUI.TableView.Helpers;
using CSharpMarkup.WinUI.TableView;
#endif

namespace WinUICsMarkupExamples.Presentation.Example;

partial class TableViewPage
{
    enum Row { Header, Body }

    public void BuildUI() => Content (
        Grid (
            Rows (
                (Row.Header, Auto),
                (Row.Body  , Star)
            ),

            NavigationBar(
                TextBlock("TableView"),
                AppBarButton() .Icon("Images/forward") .Bind(vm?.ForwardCommand)
            )  .Grid_Row(Row.Header),

#if WINDOWS
            TextBlock("TableView has a known issue when used with Windows App SDK; see ", Hyperlink(new Uri("https://github.com/w-ahmad/WinUI.TableView/issues/170"), "#170"))
               .Grid_Row(Row.Body) .Center()
#else
            TableView() .TvItemsSource() .Bind(vm?.Items)
               .Grid_Row(Row.Body)
#endif
        )
    );
}
