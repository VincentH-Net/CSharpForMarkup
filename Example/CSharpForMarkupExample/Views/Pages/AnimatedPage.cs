using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace CSharpForMarkupExample.Views.Pages
{
    public partial class AnimatedPage : BaseContentPage
    {
        void Build() {
            Title = "AnimatedPage";

            Content = new StackLayout { Children = {
                new Label { Text = "Animation example" } .FontSize (32) .CenterHorizontal (),
                new Label { Text = "to illustrate"     } .FontSize (32) .CenterHorizontal (),
                new Label { Text = "separation"        } .FontSize (32) .CenterHorizontal (),
                new Label { Text = "of"                } .FontSize (32) .CenterHorizontal (),
                new Label { Text = "UI Markup", TextColor = Colors.Green.ToColor() } .FontSize (32) .Bold () .CenterHorizontal (),
                new Label { Text = "and"               } .FontSize (32) .CenterHorizontal (),
                new Label { Text = "UI Logic" , TextColor = Colors.Red.ToColor()   } .FontSize (32) .Bold () .CenterHorizontal ()
            } } .Assign (out animatedStackLayout);
        }
    }
}
