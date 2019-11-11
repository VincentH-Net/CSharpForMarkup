using Xamarin.Forms;
using CSharpForMarkup;

namespace CSharpForMarkupExample.Views.IssuePages
{
    public class UseConstantForValue : Pages.BaseContentPage
    {
        const double aConstant = 8;

        public UseConstantForValue() => Build();

        void Build()
        {
            Content = new StackLayout { Children = {
                new Label { Text = "Edit this text and save LIVE gives InvalidCastException" }
                .Margins (left: aConstant)
            } };
        }
    }
}