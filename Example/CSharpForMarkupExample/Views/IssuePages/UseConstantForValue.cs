using Xamarin.Forms;
using CSharpForMarkup;

namespace CSharpForMarkupExample.Views.IssuePages
{
    public class UseConstantForValue : Pages.BaseContentPage // Verified fixed in LiveSharp server 0.9.10 and NuGet 1.1.13
    {
        const double aConstant = 8;

        public UseConstantForValue() => Build();

        void Build()
        {
            Content = new StackLayout { Children = {
                new Label { Text = "Edit this text and save gives InvalidCastException" }
                .Margins (left: aConstant)
            } };
        }
    }
}