using System;
using CSharpForMarkup;
using CSharpForMarkupExample.ViewModels;
using CSharpForMarkupExample.Views.Controls;
using Xamarin.Forms;
using static CSharpForMarkup.EnumsForGridRowsAndColumns;

namespace CSharpForMarkupExample.Views.Pages
{
    public class NestedListPage : BaseContentPage<NestedListViewModel>
    {
        enum PageRow { Header, Body }
        enum GroupRow { Body, Separator }

        public NestedListPage()
        {
            var app = App.Current;

            var vm = ViewModel = app.NestedListViewModel;

            NavigationPage.SetHasNavigationBar(this, false);

            BackgroundColor = Colors.BgGray3.ToColor();

            Content = new Grid
            {
                RowSpacing = 0,

                RowDefinitions = Rows.Define(
                    (PageRow.Header, GridLength.Auto),
                    (PageRow.Body  , GridLength.Star)
                ),

                Children =
                {
                    PageHeader.Create(PageMarginSize, nameof(vm.Title), nameof(vm.Subtitle), nameof(vm.ReturnToPreviousViewCommand))
                    .Row(PageRow.Header),

                    new ListView(ListViewCachingStrategy.RecycleElement)
                    {
                        IsGroupingEnabled = true,
                        HasUnevenRows = true,

                        BackgroundColor = Colors.BgGray3.ToColor(),
                        SeparatorColor = Colors.BgGray3.ToColor(),

                        GroupHeaderTemplate = new DataTemplate(() => new ViewCell { Height = 40, View = new Grid {
                            BackgroundColor = Colors.BgGray3.ToColor(),
                            RowSpacing = 0,
                            RowDefinitions = Rows.Define(
                                (GroupRow.Body     , GridLength.Star),
                                (GroupRow.Separator, 2)
                            ),

                            Children = {
                                new StackLayout { Orientation = StackOrientation.Horizontal, Spacing = 5, Children = {
                                    new Label { } .Font(FontSizes._15, FontAttributes.Bold) .TextColor(Colors.ColorValuePrimary)
                                    .Margin (PageMarginSize, 0, 0, 0) .LeftExpand() .CenterV()
                                    .Bind(nameof(ListGroup.Title)),

                                    new Frame { CornerRadius = 4, HasShadow = false, BackgroundColor = Colors.Green.ToColor(), Content =
                                        new Label { Text = "Odd" } .TextColor (Colors.White)
                                    }.CenterV() .Margin (0, 0, 10, 0) .Padding (9, 3)
                                    .Bind(Frame.IsVisibleProperty, nameof(ListGroup.IsOdd)),

                                    new Button { Text = " Add Item " }
                                    .CenterV()
                                    .Bind(nameof(ListGroup.AddItemCommand)),

                                    new Button { Text = " Remove Group " }
                                    .CenterV() .Margin (0, 0, PageMarginSize, 0)
                                    .Bind(Button.CommandProperty, nameof(vm.RemoveGroupCommand), source: vm)
                                    .Bind(Button.CommandParameterProperty)
                                }}
                                .Row (GroupRow.Body),

                                new BoxView { } .Color (Colors.Gray2)
                                .Row (GroupRow.Separator)
                            }
                        }}),

                        ItemTemplate = new ListItemSelector(vm),

                        Footer = new Button { Text = " Add Group " }
                        .Bind(nameof(vm.AddGroupCommand)),
                    }.Row(PageRow.Body)
                     .Bind(nameof(vm.Groups))
                     .Invoke(l => l.ItemSelected += List_ItemSelected)
                }
            };
        }

        void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null; // Prevent item selection
        }

        class ListItemSelector : DataTemplateSelector
        {
            readonly NestedListViewModel vm;
            readonly DataTemplate template, emptyTemplate;
            readonly FuncConverter<int> countToColorConverter = new FuncConverter<int>(count => count % 2 == 1 ? Colors.Green.ToColor() : Colors.Red.ToColor());

            enum Row { Header, Separator, Piles, Buttons, Last = Buttons }
            enum Col { LeftPileIcon, LeftPile, PileSeparator, RightPileIcon, RightPile, Nr, Last = Nr }

            public ListItemSelector(NestedListViewModel vm)
            {
                this.vm = vm;

                template = new DataTemplate(() => new ViewCell { View = new StackLayout { Spacing = 0, Children = {
                    new Grid { // TODO: When Xamarin fixes Grid layout in ListView, use additional row instead of StackLayout
                        Margin = new Thickness(PageMarginSize, 6, PageMarginSize, 0),
                        BackgroundColor = Colors.White.ToColor(),

                        RowDefinitions = Rows.Define(
                            (Row.Header   , GridLength.Auto),
                            (Row.Separator, 10),
                            (Row.Piles    , GridLength.Auto),
                            (Row.Buttons  , GridLength.Auto)
                        ),

                        ColumnDefinitions = Columns.Define(
                            (Col.LeftPileIcon , 24),
                            (Col.LeftPile     , GridLength.Star),
                            (Col.PileSeparator, 11),
                            (Col.RightPileIcon, 24),
                            (Col.RightPile    , GridLength.Star),
                            (Col.Nr           , 55)
                        ),

                        Children = {
                            new Label { Text = "\u2b50 " } .TextColor (Colors.Green)
                            .Row (Row.Header) .Col (Col.LeftPileIcon) .Left() .CenterV(),

                            new Label { Text = "Item", LineBreakMode = LineBreakMode.TailTruncation } .Font (FontSizes._15, FontAttributes.Bold)
                            .Row (Row.Header) .Col (Col.LeftPile, Col.Last) .CenterV(),

                            new Label { } .Font (FontAttributes.Bold) .TextColor (Colors.Gray1)
                            .Row (Row.Header) .Col (Col.Nr) .Center()
                            .Bind(nameof(ListItem.Title)),


                            new Label { Text = "\U0001f60e " }
                            .Row (Row.Piles) .Col (Col.LeftPileIcon) .Left() .CenterV(),

                            new Label { } .Font (FontSizes._14, FontAttributes.Bold)
                            .Row (Row.Piles) .Col (Col.LeftPile) .CenterV() .TextCenterH() .TextBottom()
                            .Bind(nameof(ListItem.CountText)),

                            new BoxView { } .Color (Colors.BgBlue1)
                            .Row (Row.Piles, Row.Buttons) .Col (Col.PileSeparator) .CenterH() .Bottom() .Size (2, 30) .Margin (0, 0, 0, 3),

                            new Label { Text = "\U0001f60e " }
                            .Row (Row.Piles) .Col (Col.RightPileIcon) .Left() .CenterV(),

                            new Label { } .Font (FontSizes._14, FontAttributes.Bold)
                            .Row (Row.Piles) .Col (Col.RightPile) .CenterV() .TextCenterH() .TextBottom()
                            .Bind(nameof(ListItem.CountText)),


                            new Button { Text = "-" } .Font (FontSizes._14) .TextColor (Colors.White) .BackgroundColor (Colors.ColorValueAccent)
                            .Row (Row.Buttons) .Col (Col.LeftPileIcon, Col.LeftPile) .FillH() .CenterV()
                            .Invoke(b => b.Clicked += DecreaseCount),

                            new Button { Text = "+" } .Font (FontSizes._14) .TextColor (Colors.White) .BackgroundColor (Colors.ColorValueAccent)
                            .Row (Row.Buttons) .Col (Col.RightPileIcon, Col.RightPile) .FillH() .CenterV()
                            .Invoke(b => b.Clicked += IncreaseCount),
                        }
                    }.Padding(CellHorizontalMarginSize, CellVerticalMarginSize),

                    new BoxView { }
                    .FillExpandH() .Height (3) .Margin (PageMarginSize, 0, PageMarginSize, 6)
                    .Bind(nameof(ListItem.Count), converter: countToColorConverter),

                    new Button { Text = " Remove item " }
                    .Bind(nameof(vm.RemoveItemCommand), source: vm)
                    .Bind(Button.CommandParameterProperty)
                }}});

                emptyTemplate = new DataTemplate(() => new ViewCell { Height = 0.1, View = new ContentView { HeightRequest = 0.1, IsVisible = false } });
                // TODO: remove workaround empty groups (crashed both iOS and Android) when Xamarin fixes: https://bugzilla.xamarin.com/show_bug.cgi?id=57561, https://github.com/xamarin/Xamarin.Forms/issues/1939, https://bugzilla.xamarin.com/show_bug.cgi?id=59412 etc
            }

            protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
            {
                var property = item as ListItem;

                return property != null && !property.IsDummy ? template : emptyTemplate;
            }

            void DecreaseCount(object sender, EventArgs args)
            {
                var button = (Button)sender;
                var listItem = (ListItem)button.BindingContext;

                listItem.DecreaseCountCommand.Execute(null);
                ForceUpdateContainingCellSize(button);
            }

            void IncreaseCount(object sender, EventArgs args)
            {
                var button = (Button)sender;
                var listItem = (ListItem)button.BindingContext;

                listItem.IncreaseCountCommand.Execute(null);
                ForceUpdateContainingCellSize(button);
            }

            void ForceUpdateContainingCellSize(Element element)
            {
                for (var parent = element?.Parent; parent != null; parent = parent.Parent) {
                    if (parent is ViewCell) { ((ViewCell)parent).ForceUpdateSize(); break; }
                }
            }
        }
    }
}
