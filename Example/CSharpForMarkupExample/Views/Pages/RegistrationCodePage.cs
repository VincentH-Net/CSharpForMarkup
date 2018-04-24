using CSharpForMarkup;
using CSharpForMarkupExample.ViewModels;
using CSharpForMarkupExample.Views.Controls;
using Xamarin.Forms;

namespace CSharpForMarkupExample.Views.Pages
{
    public class RegistrationCodePage : BaseContentPage<RegistrationCodeViewModel>
    {
        public RegistrationCodePage()
        {
            var app = App.Current;

            var vm = ViewModel = app.RegistrationCodeViewModel;
            var fieldNameMargin = new Thickness(20, 10);
            var fieldMargin = new Thickness(PageMarginSize, 0);
            
            NavigationPage.SetHasNavigationBar(this, false);

            BackgroundColor = ThemeColors.BgGray3.ToColor();

            Content = new Grid 
            {
                RowSpacing = 0,
                RowDefinitions = { new RowDefinition { Height = GridLength.Auto }, new RowDefinition { } },
                Children = {
                    PageHeader.Create(
                        PageMarginSize, 
                        nameof(vm.RegistrationTitle), nameof(vm.RegistrationSubTitle),
                        returnToPreviousViewCommandPropertyName: nameof(vm.ReturnToPreviousViewCommand), 
                        centerTitle:true),

                    new ScrollView { Content = new Grid {
                        RowSpacing = 0,
                        RowDefinitions = {
                            new RowDefinition { Height = 170 },

                            new RowDefinition { Height = 75 },
                            new RowDefinition { Height = GridLength.Auto },
                            new RowDefinition { Height = GridLength.Auto }
                        },

                        ColumnDefinitions = {
                            new ColumnDefinition { Width = 160 },
                            new ColumnDefinition { }
                        },

                        Children = {
                            new Label { FontAttributes = FontAttributes.Bold, LineBreakMode = LineBreakMode.WordWrap }.SetFontSize(ThemeFontSizes.Size15)
                                       .ColSpan(2) .FillExpandH() .CenterV() .Margin(fieldNameMargin) .TextCenterH()
                                       .Bind(nameof(vm.RegistrationPrompt)),

                            new Label { Text = "Registration code", FontAttributes = FontAttributes.Bold }.SetFontSize(ThemeFontSizes.Size13)
                                       .Row(1) .Bottom() .Margin(fieldNameMargin),

                            new Label { FontAttributes = FontAttributes.Italic }.SetFontSize(ThemeFontSizes.Size13)
                                       .RowCol(1, 1) .Right() .Bottom() .Margin(fieldNameMargin)
                                       .Bind(nameof(vm.RegistrationCodeValidationMessage)),

                            new Entry { Placeholder = "E.g. 123456", Keyboard = Keyboard.Numeric, BackgroundColor = ThemeColors.White.ToColor(), TextColor = ThemeColors.Gray1.ToColor() }.SetFontSize(ThemeFontSizes.Size15)
                                       .Row(2) .ColSpan(2) .Margin(fieldMargin) .Height(44)
                                       .Bind(nameof(vm.RegistrationCode), BindingMode.TwoWay),

                            new Button { Text = "Verify", TextColor = ThemeColors.White.ToColor(), BackgroundColor = ThemeColors.ColorValueAccent.ToColor() }.SetFontSize(ThemeFontSizes.Size13)
                                        .Row(3) .ColSpan(2) .FillExpandH() .Margin(PageMarginSize) .Height(44)
                                        .Bind(Button.IsVisibleProperty, nameof(vm.CanVerifyRegistrationCode))
                                        .Bind(nameof(vm.VerifyRegistrationCodeCommand)),
                        }
                    }} .Row(1)
                 }
            };
        }
    }
}