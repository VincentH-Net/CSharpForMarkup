using Xamarin.Forms;

namespace CSharpMarkupIntro
{
    public class App : Application
    {
        readonly SearchViewModel searchViewModel = new SearchViewModel();

        public App()
        {
            searchViewModel.Initialize();
            Resources = Styles.Implicit.Dictionary;
            MainPage = new SearchPage(searchViewModel);
        }
    }
}