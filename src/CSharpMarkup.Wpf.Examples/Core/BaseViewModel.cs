using System.ComponentModel;

namespace WpfCsMarkupExamples;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
}
