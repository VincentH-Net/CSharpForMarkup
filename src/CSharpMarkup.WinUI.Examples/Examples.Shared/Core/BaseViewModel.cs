using System.ComponentModel;

namespace WinUICsMarkupExamples;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
}
