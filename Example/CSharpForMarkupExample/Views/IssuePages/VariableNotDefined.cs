using Xamarin.Forms;
using CSharpForMarkup;

namespace CSharpForMarkupExample.Views.IssuePages
{
    public class VariableNotDefined : Pages.BaseContentPage
    {
        public VariableNotDefined() => Build();

        void Build()
        {
            var app = App.Current;
            var vm = app.RegistrationCodeViewModel;

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Edit this text and save gives InvalidOperationException variable 'vm' of type '...' referenced from scope '', but it is not defined" },

                    new Entry { BackgroundColor = Color.Green }
                    .Invoke(entry => { entry.TextChanged += (sender, e) => vm.RegistrationCode = entry.Text; })
                }
            };
        }
    }
}