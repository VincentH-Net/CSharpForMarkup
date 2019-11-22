using System.Threading.Tasks;
using System.Windows.Input;
using QuickCross;

namespace CSharpForMarkupExample.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        readonly App app;
        
        ICommand continueToRegistrationCommand, continueToNestedListCommand, continueToCSharpForMarkupCommand, continueToAnimatedPageCommand;
        
        public MainViewModel(App app) { this.app = app; }

        public string Title => "CSharpForMarkup";
        
        public string SubTitle => "Example pages";
        
        public ICommand ContinueToRegistrationCommand => continueToRegistrationCommand ?? (continueToRegistrationCommand = new RelayCommandAsync(ContinueToRegistration));
        public ICommand ContinueToNestedListCommand => continueToNestedListCommand ?? (continueToNestedListCommand = new RelayCommandAsync(ContinueToNestedList));
        public ICommand ContinueToAnimatedPageCommand => continueToAnimatedPageCommand ?? (continueToAnimatedPageCommand = new RelayCommandAsync(ContinueToAnimatedPage));
        public ICommand ContinueToCSharpForMarkupCommand => continueToCSharpForMarkupCommand ?? (continueToCSharpForMarkupCommand = new RelayCommand(ContinueToCSharpForMarkup));

        Task ContinueToRegistration() => app.ContinueToRegistration();
        Task ContinueToNestedList() => app.ContinueToNestedList();
        Task ContinueToAnimatedPage() => app.ContinueToAnimatedPage();
        void ContinueToCSharpForMarkup() => app.OpenUri("https://github.com/VincentH-Net/CSharpForMarkup");
    }
}
