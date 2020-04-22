using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Markup.LeftToRight;
using static Xamarin.Forms.Markup.GridRowsColumns;

namespace CSharpMarkupIntro
{
    public partial class SearchPage : ContentPage
    {
        void Build()
        {
            Content = new StackLayout
            {
                Children = 
                {
                    new Label { Text = "Hello Xamarin Forms C# Markup!" }
                               .CenterHorizontal ()
                }
            };
        }
    }
}
