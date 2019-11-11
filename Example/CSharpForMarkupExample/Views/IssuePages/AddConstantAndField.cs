using Xamarin.Forms;
using CSharpForMarkup;

namespace CSharpForMarkupExample.Views.IssuePages
{
    public class AddConstantAndField : Pages.BaseContentPage
    {
        const double aConstant = 8;

        public AddConstantAndField() => Build();

        void Build()
        {
            Content = new StackLayout { Children = {
                new Label { Text = "Edit this text and save gives LiveSharp.Runtime.ExpressionDeserializer+DeserializationException" }
                .Margins (left: PageMarginSize + aConstant)
            } };
        }
    }
}