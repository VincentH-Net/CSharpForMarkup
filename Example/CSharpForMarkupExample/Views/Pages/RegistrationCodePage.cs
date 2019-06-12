using CSharpForMarkup;
using CSharpForMarkupExample.ViewModels;
using CSharpForMarkupExample.Views.Controls;
using Xamarin.Forms;
using static CSharpForMarkup.EnumsForGridRowsAndColumns;

namespace CSharpForMarkupExample.Views.Pages
{
    public class RegistrationCodePage : BaseContentPage<RegistrationCodeViewModel>
    {
        public RegistrationCodePage() => Build();

        enum PageRow { Header, Body }
        enum BodyRow { Prompt, CodeHeader, CodeEntry, Button }
        enum BodyCol { FieldLabel, FieldValidation }

        void Build()
        {
            var app = App.Current;
            var vm = ViewModel = app.RegistrationCodeViewModel;
            var fieldNameMargin = new Thickness(20, 10);
            var fieldMargin = new Thickness(PageMarginSize, 0);
            
            NavigationPage.SetHasNavigationBar(this, false);
            BackgroundColor = Colors.BgGray3.ToColor();

            Content = new Grid {
                RowSpacing = 0,
                RowDefinitions = Rows.Define(
                    (PageRow.Header, GridLength.Auto),
                    (PageRow.Body  , GridLength.Star)
                ),

                Children = {
                    PageHeader.Create(
                        PageMarginSize, 
                        nameof(vm.RegistrationTitle), nameof(vm.RegistrationSubTitle),
                        returnToPreviousViewCommandPropertyName: nameof(vm.ReturnToPreviousViewCommand), 
                        centerTitle:true
                    ) .Row (PageRow.Header),

                    new ScrollView { Content = new Grid {
                        RowSpacing = 0,
                        RowDefinitions = Rows.Define(
                            (BodyRow.Prompt    , 170),
                            (BodyRow.CodeHeader, 75),
                            (BodyRow.CodeEntry , GridLength.Auto ),
                            (BodyRow.Button    , GridLength.Auto )
                        ),

                        ColumnDefinitions = Columns.Define (
                            (BodyCol.FieldLabel, 160 ),
                            (BodyCol.FieldValidation, GridLength.Star )
                        ),

                        Children = {
                            new Label { LineBreakMode = LineBreakMode.WordWrap } .Font (FontSizes._15, FontAttributes.Bold)
                                       .Row (BodyRow.Prompt) .ColSpan (All<BodyCol>()) .FillExpandH() .CenterV() .Margin (fieldNameMargin) .TextCenterH()
                                       .Bind(nameof(vm.RegistrationPrompt)),

                            new Label { Text = "Registration code" } .Font(FontAttributes.Bold)
                                       .Row (BodyRow.CodeHeader) .Col(BodyCol.FieldLabel) .Bottom() .Margin(fieldNameMargin),

                            new Label { } .Font (FontAttributes.Italic)
                                       .Row (BodyRow.CodeHeader) .Col(BodyCol.FieldValidation) .Right() .Bottom() .Margin (fieldNameMargin)
                                       .Bind(nameof(vm.RegistrationCodeValidationMessage)),

                            new Entry { Placeholder = "E.g. 123456", Keyboard = Keyboard.Numeric } .Font (FontSizes._15) .BackgroundColor (Colors.White) .TextColor (Colors.Gray1)
                                       .Row (BodyRow.CodeEntry) .ColSpan (All<BodyCol>()) .Margin (fieldMargin) .Height (44)
                                       .Bind(nameof(vm.RegistrationCode), BindingMode.TwoWay),

                            new Button { Text = "Verify", Style = Styles.ButtonFilled }
                                        .Row (BodyRow.Button) .ColSpan (All<BodyCol>()) .FillExpandH() .Margin (PageMarginSize) .Height (44)
                                        .Bind(Button.IsVisibleProperty, nameof(vm.CanVerifyRegistrationCode))
                                        .Bind(nameof(vm.VerifyRegistrationCodeCommand)),
                        }
                    }} .Row (PageRow.Body)
                 }
            };
        }
    }
}