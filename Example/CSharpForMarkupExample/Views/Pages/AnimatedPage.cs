using CSharpForMarkup;
using Xamarin.Forms;

namespace CSharpForMarkupExample.Views.Pages
{
    public partial class AnimatedPage : BaseContentPage
    {
        void Build() {
            Title = "AnimatedPage";

            Content = new StackLayout { Children = {
                new Label { Text = "Animation example" } .FontSize (32) .CenterH (),
                new Label { Text = "to illustrate"     } .FontSize (32) .CenterH (),
                new Label { Text = "separation"        } .FontSize (32) .CenterH (),
                new Label { Text = "of"                } .FontSize (32) .CenterH (),
                new Label { Text = "UI Markup", TextColor = Colors.Green.ToColor() } .FontSize (32) .Bold () .CenterH (),
                new Label { Text = "and"               } .FontSize (32) .CenterH (),
                new Label { Text = "UI Logic" , TextColor = Colors.Red.ToColor()   } .FontSize (32) .Bold () .CenterH ()
            } } .Assign (out animatedStackLayout);
        }
    }
}
