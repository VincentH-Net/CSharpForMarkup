using System.ComponentModel;

namespace WinUICsMarkupExamples.Core;

public class BaseViewModel : INotifyPropertyChanged
{
#pragma warning disable CS0067 // Justification: event is used by assembly weaver PropertyChanged.Fody
    public event PropertyChangedEventHandler? PropertyChanged;
#pragma warning restore
}
