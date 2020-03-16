using Xamarin.Forms;

namespace CSharpForMarkupExample.Views.Pages
{
    partial class AnimatedPage
    {
        StackLayout animatedStackLayout;

        public AnimatedPage() => Build();

        protected override void OnAppearing()
        {
            base.OnAppearing();
            animatedStackLayout.Children.StaggerIn(50, 0.5);
        }
    }
}
