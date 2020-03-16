using Xamarin.Forms;
using Xamarin.Forms.Markup;
using static Xamarin.Forms.Markup.GridRowsColumns;

using CSharpForMarkupExample.ViewModels;
using CSharpForMarkupExample.Views.Controls;
using static CSharpForMarkupExample.Styles;

namespace CSharpForMarkupExample.Views.Pages
{
    public class MainPage : BaseContentPage<MainViewModel>
    {
        public MainPage() => Build();

        enum PageRow { Header, Body }

        void Build()
        {
            var app = App.Current;
            var vm = ViewModel = app.MainViewModel;
            
            NavigationPage.SetHasNavigationBar(this, false);
            BackgroundColor = Colors.BgGray3.ToColor();

            Content = new Grid {
                RowSpacing = 0,
                RowDefinitions = Rows.Define(
                    (PageRow.Header, Auto),
                    (PageRow.Body  , Star)
                ),

                Children = {
                    PageHeader.Create(PageMarginSize, nameof(vm.Title), nameof(vm.SubTitle))
                    .Row (PageRow.Header),

                    new ScrollView { Content = new StackLayout { Children = {
                        new Button { Text = nameof(RegistrationCodePage) } .Style (FilledButton)
                            .FillExpandHorizontal () .Margin (PageMarginSize)
                            .Bind (nameof(vm.ContinueToRegistrationCommand)),

                        new Button { Text = nameof(NestedListPage) } .Style (FilledButton)
                            .FillExpandHorizontal () .Margin (PageMarginSize)
                            .Bind (nameof(vm.ContinueToNestedListCommand)),

                        new Button { Text = nameof(AnimatedPage) } .Style (FilledButton)
                            .FillExpandHorizontal () .Margin (PageMarginSize)
                            .Bind (nameof(vm.ContinueToAnimatedPageCommand)),

                        new Label { } .FontSize (20) .FormattedText (
                            new Span { Text = "Built with " },
                            new Span { Style = Link }
                            .BindTapGesture (nameof(vm.ContinueToCSharpForMarkupCommand))
                            .Bind (nameof(vm.Title)),
                            new Span { Text = " \U0001f60e" }
                        ) .CenterHorizontal ()
                    }}} .Row (PageRow.Body)
                 }
            };
        }
    }
}