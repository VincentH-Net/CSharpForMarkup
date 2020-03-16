using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Markup.LeftToRight;
using static Xamarin.Forms.Markup.GridRowsColumns;

using CSharpForMarkupExample.ViewModels;
using CSharpForMarkupExample.Views.Controls;

namespace CSharpForMarkupExample.Views.Pages
{
    public partial class NestedListPage : BaseContentPage<NestedListViewModel>
    {
        enum PageRow { Header, Body }
        enum GroupRow { Body, Separator }

        void Build()
        {
            var app = App.Current;
            var vm = ViewModel = app.NestedListViewModel;

            NavigationPage.SetHasNavigationBar(this, false);
            BackgroundColor = Colors.BgGray3.ToColor();

            Content = new Grid {
                RowSpacing = 0,

                RowDefinitions = Rows.Define(
                    (PageRow.Header, Auto),
                    (PageRow.Body  , Star)
                ),

                Children = {
                    PageHeader.Create(PageMarginSize, nameof(vm.Title), nameof(vm.Subtitle), nameof(vm.ReturnToPreviousViewCommand))
                    .Row (PageRow.Header),

                    new ListView(ListViewCachingStrategy.RecycleElement) {
                        IsGroupingEnabled = true,
                        HasUnevenRows = true,

                        BackgroundColor = Colors.BgGray3.ToColor(),
                        SeparatorColor = Colors.BgGray3.ToColor(),

                        GroupHeaderTemplate = new DataTemplate(() => new ViewCell { Height = 40, View = new Grid {
                            BackgroundColor = Colors.BgGray3.ToColor(),
                            RowSpacing = 0,
                            RowDefinitions = Rows.Define(
                                (GroupRow.Body     , Star),
                                (GroupRow.Separator, 2   )
                            ),

                            Children = {
                                new StackLayout { Orientation = StackOrientation.Horizontal, Spacing = 5, Children = {
                                    new Label { } .Font (15) .Bold () .TextColor (Colors.ColorValuePrimary)
                                    .Margins (left: PageMarginSize) .LeftExpand () .CenterVertical ()
                                    .Bind (nameof(ListGroup.Title)),

                                    new Frame { CornerRadius = 4, HasShadow = false, BackgroundColor = Colors.Green.ToColor(), Content =
                                        new Label { Text = "Odd" } .TextColor (Colors.White)
                                    } .CenterVertical () .Margins (right: 10) .Padding (9, 3)
                                    .Bind (Frame.IsVisibleProperty, nameof(ListGroup.IsOdd)),

                                    new Button { Text = " Add Item " }
                                    .CenterVertical ()
                                    .Bind (nameof(ListGroup.AddItemCommand)),

                                    new Button { Text = " Remove Group " }
                                    .CenterVertical () .Margins (right: PageMarginSize)
                                    .Bind (Button.CommandProperty, nameof(vm.RemoveGroupCommand), source: vm)
                                    .Bind (Button.CommandParameterProperty)
                                }}
                                .Row (GroupRow.Body),

                                new BoxView { } .Color (Colors.Gray2)
                                .Row (GroupRow.Separator)
                            }
                        }}),

                        ItemTemplate = new ListItemSelector(vm),

                        Footer = new Button { Text = " Add Group " }
                        .Bind (nameof(vm.AddGroupCommand)),
                    }.Row (PageRow.Body)
                     .Invoke (l => l.ItemSelected += List_ItemSelected)
                     .Bind (nameof(vm.Groups))
                }
            };
        }

        partial class ListItemSelector : DataTemplateSelector
        {
            enum Row { Header, Separator, Piles, Buttons, Last = Buttons }
            enum Col { LeftPileIcon, LeftPile, PileSeparator, RightPileIcon, RightPile, Nr, Last = Nr }

            public ListItemSelector(NestedListViewModel vm)
            {
                template = new DataTemplate(() => new ViewCell { View = new StackLayout { Spacing = 0, Children = {
                    new Grid { // TODO: When Xamarin fixes Grid layout in ListView, use additional row instead of StackLayout
                        Margin = new Thickness(PageMarginSize, 6, PageMarginSize, 0),
                        BackgroundColor = Colors.White.ToColor(),

                        RowDefinitions = Rows.Define(
                            (Row.Header   , Auto),
                            (Row.Separator, 10),
                            (Row.Piles    , Auto),
                            (Row.Buttons  , Auto)
                        ),

                        ColumnDefinitions = Columns.Define(
                            (Col.LeftPileIcon , 24),
                            (Col.LeftPile     , Star),
                            (Col.PileSeparator, 11),
                            (Col.RightPileIcon, 24),
                            (Col.RightPile    , Star),
                            (Col.Nr           , 55)
                        ),

                        Children = {
                            new Label { Text = "\u2b50 " } .TextColor (Colors.Green)
                            .Row (Row.Header) .Column (Col.LeftPileIcon) .Left () .CenterVertical (),

                            new Label { Text = "Item", LineBreakMode = LineBreakMode.TailTruncation } .Font (15) .Bold ()
                            .Row (Row.Header) .Column (Col.LeftPile, Col.Last) .CenterVertical (),

                            new Label { } .Bold () .TextColor (Colors.Gray1)
                            .Row (Row.Header) .Column (Col.Nr) .Center ()
                            .Bind (nameof(ListItem.Title)),


                            new Label { Text = "\U0001f60e " }
                            .Row (Row.Piles) .Column (Col.LeftPileIcon) .Left () .CenterVertical (),

                            new Label { } .Font (14) .Bold ()
                            .Row (Row.Piles) .Column (Col.LeftPile) .CenterVertical () .TextCenterHorizontal () .TextBottom ()
                            .Bind (nameof(ListItem.CountText)),

                            new BoxView { } .Color (Colors.BgBlue1)
                            .Row (Row.Piles, Row.Buttons) .Column (Col.PileSeparator) .CenterHorizontal () .Bottom () .Size (2, 30) .Margins (bottom: 3),

                            new Label { Text = "\U0001f60e " }
                            .Row (Row.Piles) .Column (Col.RightPileIcon) .Left () .CenterVertical (),

                            new Label { } .Font (14) .Bold ()
                            .Row (Row.Piles) .Column (Col.RightPile) .CenterVertical () .TextCenterHorizontal () .TextBottom ()
                            .Bind (nameof(ListItem.CountText)),


                            new Button { Text = "-" } .Font (14) .TextColor (Colors.White) .BackgroundColor (Colors.ColorValueAccent)
                            .Row (Row.Buttons) .Column (Col.LeftPileIcon, Col.LeftPile) .FillHorizontal () .CenterVertical ()
                            .Invoke (b => b.Clicked += DecreaseCount),

                            new Button { Text = "+" } .Font (14) .TextColor (Colors.White) .BackgroundColor (Colors.ColorValueAccent)
                            .Row (Row.Buttons) .Column (Col.RightPileIcon, Col.RightPile) .FillHorizontal () .CenterVertical ()
                            .Invoke (b => b.Clicked += IncreaseCount),
                        }
                    } .Padding (CellHorizontalMarginSize, CellVerticalMarginSize),

                    new BoxView { }
                    .FillExpandHorizontal () .Height (3) .Margins (PageMarginSize, 0, PageMarginSize, 6)
                    .Bind (nameof(ListItem.Count), converter: countToColorConverter),

                    new Button { Text = " Remove item " }
                    .Bind (nameof(vm.RemoveItemCommand), source: vm)
                    .Bind (Button.CommandParameterProperty)
                }}});

                emptyTemplate = new DataTemplate(() => new ViewCell { Height = 0.1, View = new ContentView { HeightRequest = 0.1, IsVisible = false } });
                // TODO: remove workaround empty groups (crashed both iOS and Android) when Xamarin fixes: https://bugzilla.xamarin.com/show_bug.cgi?id=57561, https://github.com/xamarin/Xamarin.Forms/issues/1939, https://bugzilla.xamarin.com/show_bug.cgi?id=59412 etc
            }
        }
    }
}
