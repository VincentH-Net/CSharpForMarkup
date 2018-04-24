using System.Threading.Tasks;
using System.Windows.Input;
using QuickCross;

namespace CSharpForMarkupExample.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        readonly App app;
        
        ICommand continueToRegistrationCommand, continueToNestedListCommand;
        
        public MainViewModel(App app) { this.app = app; }

        public string Title => "C# for Markup";
        
        public string SubTitle => "Example pages";
        
        public ICommand ContinueToRegistrationCommand => continueToRegistrationCommand ?? (continueToRegistrationCommand = new RelayCommandAsync(ContinueToRegistration));
        public ICommand ContinueToNestedListCommand => continueToNestedListCommand ?? (continueToNestedListCommand = new RelayCommandAsync(ContinueToNestedList));
        
        Task ContinueToRegistration() => app.ContinueToRegistration();
        Task ContinueToNestedList() => app.ContinueToNestedList();
    }
}
