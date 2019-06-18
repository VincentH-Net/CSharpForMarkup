using CSharpForMarkupExample.ViewModels;
using CSharpForMarkupExample.Views.Pages;
using QuickCross;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CSharpForMarkupExample
{
    public class App : Application
    {
        public static new App Current => (App)Application.Current;
        
        RegistrationCodePage registrationCodePage;
        NestedListPage nestedListPage;

        public App() {
            Resources = Styles.Implicit;
            MainViewModel = new MainViewModel(this);
            MainPage = new NavigationPage(new MainPage());
        }

        public MainViewModel MainViewModel { get; private set; }
    
        public RegistrationCodeViewModel RegistrationCodeViewModel { get; private set; }
        
        public NestedListViewModel NestedListViewModel { get; private set; }
        
        public Task ContinueToRegistration()
        {
            if (RegistrationCodeViewModel == null) RegistrationCodeViewModel = new RegistrationCodeViewModel(this);
            if (registrationCodePage == null) registrationCodePage = new RegistrationCodePage();
            return TaskHelper.RunOnUIThread(() => MainPage.Navigation.PushAsync(registrationCodePage, true));
        }
        
        public Task ContinueToNestedList()
        {
            if (NestedListViewModel == null) NestedListViewModel = new NestedListViewModel(this);
            if (nestedListPage == null) nestedListPage = new NestedListPage();
            return TaskHelper.RunOnUIThread(() => MainPage.Navigation.PushAsync(nestedListPage, true));
        }
        
        public Task DisplayAlert(string title, string message, string cancel = "OK") => MainPage.DisplayAlert(title, message, cancel);
        
        public Task ReturnToPreviousView() => MainPage.Navigation.PopAsync(true);
    }
}
