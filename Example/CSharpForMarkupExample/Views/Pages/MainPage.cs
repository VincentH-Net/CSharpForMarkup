using Xamarin.Forms;
using Xamarin.Forms.Markup;
using static Xamarin.Forms.Markup.GridRowsColumns;

using CSharpForMarkupExample.ViewModels;
using CSharpForMarkupExample.Views.Controls;
using static CSharpForMarkupExample.Styles;

namespace CSharpForMarkupExample.Views.Pages
{
    class MainPage : BaseContentPage<MainViewModel>
    {
        public MainPage() => Build();

        enum PageRow { Header, Body }

        void Build()
        {
            var app = App.Current;
            var vm = ViewModel = app.MainViewModel;
            
            NavigationPage.SetHasNavigationBar(this, false);
            BackgroundColor = Color.White;

            Content = new Grid {
                RowSpacing = 0,
                RowDefinitions = Rows.Define(
                    (PageRow.Header, Auto),
                    (PageRow.Body  , Star)
                ),

                Children = {
                    PageHeader.Create (PageMarginSize, nameof(vm.Title), nameof(vm.SubTitle))
                    .Row (PageRow.Header),

                    new ScrollView { Content = new StackLayout { Children = {
                        new NavigateButton (nameof(RegistrationCodePage), nameof(vm.ContinueToRegistrationCommand)),

                        new NavigateButton (nameof(NestedListPage), nameof(vm.ContinueToNestedListCommand)),

                        new NavigateButton (nameof(AnimatedPage), nameof(vm.ContinueToAnimatedPageCommand)),

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

        class NavigateButton : Button
        {
            public NavigateButton(string text, string command)
            {
                Text = text;
                this .Style (FilledButton)
                     .FillExpandHorizontal () .Margin (PageMarginSize)
                     .Bind (command);
            }
        }
    }
}