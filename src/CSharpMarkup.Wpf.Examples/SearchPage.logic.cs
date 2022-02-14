using System.Windows.Controls;
using System.Windows.Media.Imaging;
// Note: in code behind we do NOT use CSharpMarkup.WinUI, only the UI object model.
// That is why Assign and Invoke pass the UI object to the logic, not the markup object.
// Markup object instances are not safe to use outside of a markup expression.

namespace WpfCsMarkupExamples;

public sealed partial class SearchPage : Page, IBuild
{
    static SearchViewModel.Tweet tweet = new();
    readonly SearchViewModel vm;
    StackPanel header;

    public SearchPage()
    {
        DataContext = vm = App.Current.SearchViewModel;
        Build();
    }

    static BitmapImage UriImage(string uri)
    {
        BitmapImage bitmap = new BitmapImage();
        bitmap.BeginInit();
        bitmap.UriSource = new Uri(uri, UriKind.Absolute);
        bitmap.EndInit();
        return bitmap;
    }
}