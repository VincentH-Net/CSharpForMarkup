using CSharpForMarkup;
using CSharpForMarkupExample.ViewModels;
using CSharpForMarkupExample.Views.Controls;
using Xamarin.Forms;
using static CSharpForMarkup.EnumsForGridRowsAndColumns;
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
                            .FillExpandH () .Margin (PageMarginSize)
                            .Bind (nameof(vm.ContinueToRegistrationCommand)),

                        new Button { Text = nameof(NestedListPage) } .Style (FilledButton)
                            .FillExpandH () .Margin (PageMarginSize)
                            .Bind (nameof(vm.ContinueToNestedListCommand)),
                    }}} .Row (PageRow.Body)
                 }
            };
        }
    }
}