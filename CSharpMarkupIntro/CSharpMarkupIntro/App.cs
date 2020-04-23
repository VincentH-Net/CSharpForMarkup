using System.Collections.Generic;
using Xamarin.Forms;

namespace CSharpMarkupIntro
{
    public class App : Application
    {
        readonly SearchViewModel searchViewModel = new SearchViewModel();

        public App()
        {
            searchViewModel.Initialize();
            MainPage = new SearchPage(searchViewModel);
        }
    }
}