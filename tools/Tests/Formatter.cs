using NUnit.Framework;

namespace CSharpMarkupTools.Tests
{
    public class Formatter
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CorrectFormatRemainsIdentical()
        {
            string source = @"
using CSharpForMarkup;
using Xamarin.Forms;

namespace CSharpForMarkupExample.Views.Pages
{
    public partial class AnimatedPage : BaseContentPage
    {
        void Build() {
            Title = ""AnimatedPage"";

            Content = new StackLayout { Children = {
                new Label { Text = $""Animation example {1}"" } .FontSize (32) .CenterHorizontal (),
                new Label { Text = ""to illustrate""     } .FontSize (32) .CenterHorizontal (),
                new Label { Text = ""separation""        } .FontSize (32) .CenterHorizontal (),
                new Label { Text = ""of""                } .FontSize (32) .CenterHorizontal (),
                new Label { Text = ""UI Markup"", TextColor = Color.Green } .FontSize (32) .Bold () .CenterHorizontal (),
                new Label { Text = ""and""               } .FontSize (32) .CenterH (),
                new Label { Text = ""UI Logic"" , TextColor = Color.Red   } .FontSize (32) .Bold () .CenterHorizontal ()
            } }.Assign(out animatedStackLayout);
        }
    }
}
";
            var formatter = new CSharpMarkupTools.Formatter(new Settings { });
            Assert.That(source, Is.EqualTo(formatter.Format(source)));
        }
    }
}