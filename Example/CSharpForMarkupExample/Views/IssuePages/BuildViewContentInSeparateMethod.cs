using Xamarin.Forms;
using CSharpForMarkup;

namespace CSharpForMarkupExample.Views.IssuePages
{
    public class BuildViewContentInSeparateMethod : Pages.BaseContentPage // Verified fixed in LiveSharp server 0.9.10 and NuGet 1.1.13
    {
        public BuildViewContentInSeparateMethod() => Build();

        ScrollView scrollView;

        void Build()
        {
            Content = new ScrollView { }
            .Assign(out scrollView);

            BuildScrollViewContent();
        }

        void BuildScrollViewContent()
        {
            scrollView.Content = new Label { Text = "Edit this text and save gives LiveSharp.Runtime.ExpressionDeserializer+DeserializationException" };
        }
    }
}