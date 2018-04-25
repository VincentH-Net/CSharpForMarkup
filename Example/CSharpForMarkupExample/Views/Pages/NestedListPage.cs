using System;
using CSharpForMarkup;
using CSharpForMarkupExample.ViewModels;
using CSharpForMarkupExample.Views.Controls;
using Xamarin.Forms;

namespace CSharpForMarkupExample.Views.Pages
{
    public class NestedListPage : BaseContentPage<NestedListViewModel>
    {
        public NestedListPage()
        {
            var app = App.Current;

            var vm = ViewModel = app.NestedListViewModel;

            NavigationPage.SetHasNavigationBar(this, false);

            BackgroundColor = Colors.BgGray3.ToColor();

            Content = new Grid
            {
                RowSpacing = 0,
                RowDefinitions = {
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { },
                },

                Children =
                {
                    // Header
                    PageHeader.Create(PageMarginSize, nameof(vm.Title), nameof(vm.Subtitle), nameof(vm.ReturnToPreviousViewCommand)),

                    new ListView(ListViewCachingStrategy.RecycleElement)
                    {
                        IsGroupingEnabled = true,
                        HasUnevenRows = true,
                        
                        BackgroundColor = Colors.BgGray3.ToColor(),
                        SeparatorColor = Colors.BgGray3.ToColor(),
                        
                        GroupHeaderTemplate = new DataTemplate(() => new ViewCell { Height = 40, View = new Grid {
                            BackgroundColor = Colors.BgGray3.ToColor(),
                            RowSpacing = 0,
                            RowDefinitions = { new RowDefinition { }, new RowDefinition { Height = 2 } },
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
                                }},
                                
                                new BoxView { } .Color (Colors.Gray2)
                                .Row (1)
                            }
                        }}),

                        ItemTemplate = new ListItemSelector(vm),
                        
                        Footer = new Button { Text = " Add Group " }
                        .Bind(nameof(vm.AddGroupCommand)),
                    }.Row(1)
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

            public ListItemSelector(NestedListViewModel vm)
            {
                this.vm = vm;
                
                template = new DataTemplate(() => new ViewCell { View = 
                    new StackLayout { Spacing = 0, Children = { new Grid { // TODO: When Xamarin fixes Grid layout in ListView, use additional row instead of StackLayout
                        Margin = new Thickness(PageMarginSize, 6, PageMarginSize, 0),
                        BackgroundColor = Colors.White.ToColor(),
                    
                        RowDefinitions = {
                            new RowDefinition { Height = GridLength.Auto },
                            new RowDefinition { Height = 10 },
                            new RowDefinition { Height = GridLength.Auto },
                            new RowDefinition { Height = GridLength.Auto }
                        },
                        
                        ColumnSpacing = 0,
                        ColumnDefinitions = {
                            new ColumnDefinition { Width = 24 },
                            new ColumnDefinition { },
                            new ColumnDefinition { Width = 11 },
                            new ColumnDefinition { Width = 24 },
                            new ColumnDefinition { },
                            new ColumnDefinition { Width = 55 }
                        },
                        
                        Children = {
                            new Label { Text = "\u2b50 " } .TextColor (Colors.Green)
                            .Left() .CenterV(),
                            
                            new Label { Text = "Item", LineBreakMode = LineBreakMode.TailTruncation } .Font (FontSizes._15, FontAttributes.Bold)
                            .Col (1, 4) .CenterV(),
    
                            new Label { } .Font (FontAttributes.Bold) .TextColor (Colors.Gray1)
                            .Col (5) .Center()
                            .Bind(nameof(ListItem.Title)),
                            
    
                            new Label { Text = "\U0001f60e " }
                            .Row (2) .Left() .CenterV(),
                        
                            new Label { } .Font (FontSizes._14, FontAttributes.Bold)
                            .RowCol (2, 1) .CenterV() .TextCenterH() .TextBottom()
                            .Bind(nameof(ListItem.CountText)),
                            
                            new BoxView { } .Color (Colors.BgBlue1)
                            .Row (2, 2) .Col (2) .CenterH() .Bottom() .Size (2, 30) .Margin (0, 0, 0, 3),
                            
                            new Label { Text = "\U0001f60e " }
                            .RowCol (2, 3) .Left() .CenterV(),
                        
                            new Label { } .Font (FontSizes._14, FontAttributes.Bold)
                            .RowCol (2, 4) .CenterV() .TextCenterH() .TextBottom()
                            .Bind(nameof(ListItem.CountText)),
                            
    
                            new Button { Text = "-" } .Font (FontSizes._14) .TextColor (Colors.White) .BackgroundColor (Colors.ColorValueAccent)
                            .Row (3) .ColSpan (2) .FillH() .CenterV()
                            .Invoke(b => b.Clicked += DecreaseCount),
                            
                            new Button { Text = "+" } .Font (FontSizes._14) .TextColor (Colors.White) .BackgroundColor (Colors.ColorValueAccent)
                            .Row (3) .Col (3, 2) .FillH() .CenterV()
                            .Invoke(b => b.Clicked += IncreaseCount),
                        }}.Padding(CellHorizontalMarginSize, CellVerticalMarginSize),
    
                        new BoxView { }
                        .FillExpandH() .Height (3) .Margin (PageMarginSize, 0, PageMarginSize, 6)
                        .Bind(nameof(ListItem.Count), converter: countToColorConverter),
                        
                        new Button { Text = " Remove item " }
                        .Bind(nameof(vm.RemoveItemCommand), source: vm)
                        .Bind(Button.CommandParameterProperty)
                    }}
                });
                
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
