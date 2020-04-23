using Xamarin.Forms;

namespace CSharpMarkupIntro
{
    public partial class SearchPage : ContentPage
    {
        readonly SearchViewModel vm;

        public SearchPage(SearchViewModel vm)
        {
            BindingContext = this.vm = vm;
            Build();
        }
    }
}
