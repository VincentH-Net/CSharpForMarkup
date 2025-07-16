using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WinUICsMarkupExamples.Presentation.Example;

public partial class TableViewViewModel(INavigator navigator) : BaseViewModel
{
    public ObservableCollection<Item> Items { get; set; } = [
        new () { Name = "Item 1", Price = 10.0, Quantity = 1 },
        new () { Name = "Item 2", Price = 15.0, Quantity = 2 },
        new () { Name = "Item 3", Price = 20.0, Quantity = 3 }
    ];

    [RelayCommand] public async Task Forward() => await navigator.NavigateViewModelAsync<LiveCharts2ViewModel>(this);

    public partial class Item : ObservableObject
    {
        [ObservableProperty] public partial string Name { get; set; }
        [ObservableProperty] public partial double Price {  get; set; }
        [ObservableProperty] public partial int Quantity { get; set; }
    }
}
