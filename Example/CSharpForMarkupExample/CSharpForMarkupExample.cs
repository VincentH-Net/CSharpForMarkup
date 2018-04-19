using CSharpForMarkupExample.ViewModels;
using CSharpForMarkupExample.Views.Pages;
using Xamarin.Forms;

namespace CSharpForMarkupExample
{
    public class App : Application
    {
        public RegistrationCodeViewModel RegistrationCodeViewModel { get; private set; } = new RegistrationCodeViewModel();
        
        public static new App Current => (App)Application.Current;
    
        public App() { MainPage = new RegistrationCodePage(); }
    }
}
