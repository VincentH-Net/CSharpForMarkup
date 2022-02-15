using System.ComponentModel;

namespace WpfCsMarkupExamples;

public class BaseViewModel : INotifyPropertyChanged
{
#pragma warning disable CS0067 // Fody generates code that uses PropertyChanged
    public event PropertyChangedEventHandler? PropertyChanged;
#pragma warning restore
}
