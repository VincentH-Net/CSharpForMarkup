using Xamarin.Forms;
using CSharpForMarkup;

namespace CSharpForMarkupExample.Views.IssuePages
{
    public class PassIntFieldToDoubleParameter : Pages.BaseContentPage // Verified fixed in LiveSharp server 0.9.10 and NuGet 1.1.13
    {
        int marginRight = Device.RuntimePlatform == Device.iOS ? 3 : 12;

        public PassIntFieldToDoubleParameter() => Build();

        void Build()
        {
            Content = new StackLayout { Children = {
                new Label { Text = "Edit this text and save gives InvalidCastException" }
                .Margins (right: marginRight)
            } };
        }
    }
}