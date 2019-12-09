using Xamarin.Forms;
using CSharpForMarkup;
using CSharpForMarkupExample.Views.Controls;
using static CSharpForMarkupExample.Styles;

namespace CSharpForMarkupExample.Views.IssuePages
{
    public class KeyboardAccessoryOniOS : Pages.BaseContentPage
    {
        public KeyboardAccessoryOniOS() => Build();

        void Build()
        {
            Content = new KeyboardAccessoryLayout { 
                Content = new StackLayout { Children = {
                    new Label { Text = "Bring up the keyboard by tapping on below entry. There should be an \"ACCESSORY\" label above the keyboard, however with LiveSharp enabled the label will not be shown on iOS.\n\nDefine LIVESHARP_DISABLE in the iOS project's conditional compilation constants to make the label appear.\n\nNOTE Visual Studio for Windows 16.4 has a bug in the project property page for conditional compilation constants - you need to add/remove the LIVESHARP_DISABLE constant in the project file in a text editor" },
                    new Entry { Placeholder = "E.g. 123456", Keyboard = Keyboard.Numeric } .Font (15) .BackgroundColor (Colors.White) .TextColor (Colors.Gray1)
                } },

                Accessory = new KeyboardAccessoryLayout.AccessoryGrid { BackgroundColor = Colors.ColorValueAccent.ToColor(), Children = {
                    new Label { Text = "ACCESSORY", TextColor = Color.White }
                               .Font (13, bold: true)
                               .Height (50) .TextRight () .TextCenterV () .Margins (right: Pages.BaseContentPage.PageMarginSize)
                } }
            };
        }
    }
}