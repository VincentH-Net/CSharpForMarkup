using System;
using CSharpForMarkup;
using CSharpForMarkupExample.ViewModels;
using CSharpForMarkupExample.Views.Controls;
using Xamarin.Forms;

namespace CSharpForMarkupExample.Views.Pages
{
    public class MainPage : BaseContentPage<MainViewModel>
    {
        public MainPage()
        {
            var app = App.Current;
            var vm = ViewModel = app.MainViewModel;
            
            NavigationPage.SetHasNavigationBar(this, false);

            BackgroundColor = Colors.BgGray3.ToColor();

            Content = new Grid 
            {
                RowSpacing = 0,
                RowDefinitions = { new RowDefinition { Height = GridLength.Auto }, new RowDefinition { } },
                Children = {
                    PageHeader.Create(
                        PageMarginSize, 
                        nameof(vm.Title), nameof(vm.SubTitle)
                    ),

                    new ScrollView { Content = new StackLayout { Children = {
                        new Button { Text = nameof(RegistrationCodePage), Style = Styles.ButtonFilled }
                            .FillExpandH() .Margin(PageMarginSize) .Height(44)
                            .Bind(nameof(vm.ContinueToRegistrationCommand)),

                        new Button { Text = nameof(NestedListPage), Style = Styles.ButtonFilled }
                            .FillExpandH() .Margin(PageMarginSize) .Height(44)
                            .Bind(nameof(vm.ContinueToNestedListCommand)),
                    }}} .Row(1)
                 }
            };
        }
    }
}
