using QuickCross;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Text.RegularExpressions;

namespace CSharpForMarkupExample.ViewModels
{
    public class RegistrationCodeViewModel : BaseViewModel
    {
        string registrationCode;
        ICommand verifyRegistrationCodeCommand;
        
        public string RegistrationTitle => "Registration";

        public string RegistrationSubTitle => "LiveXAML coded UI test page";

        public string RegistrationPrompt { get; set; } = "Your test registration code is 123456.\n\nPlease enter it below";

        public string RegistrationCode {
            get { return registrationCode; }
            set {
                registrationCode = value;
                if (Regex.IsMatch(registrationCode, @"^\d{6}$")) {
                    IsRegistrationCodeFormatValid = true;
                    RegistrationCodeValidationMessage = null;
                } else {
                    IsRegistrationCodeFormatValid = false;
                    RegistrationCodeValidationMessage = "6 digits";
                }
            }
        }

        public bool IsRegistrationCodeFormatValid { get; set; }
        
        public bool CanVerifyRegistrationCode => IsRegistrationCodeFormatValid;

        public string RegistrationCodeValidationMessage { get; set; }

        public ICommand VerifyRegistrationCodeCommand { get { return verifyRegistrationCodeCommand ?? (verifyRegistrationCodeCommand = new RelayCommandAsync(SaveRegistrationCode)); } }

        async Task SaveRegistrationCode()
        {
            await App.Current.MainPage.DisplayAlert("Registration", $"Registered code { RegistrationCode }", "OK");
        }
    }
}
