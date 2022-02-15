// IMPORTANT:
// In <page>.cs:
// Include CSharpMarkup namespace usings but no UI objectmodel usings.
// You *can* also use the UI objectmodel safely in <page>.cs; a good practice then is to
// define a "global using TypeName_UI = <UI objectmodel namespace>.TypeName" alias in GlobalUsings.cs

// In <page>.logic.cs:
// DO NOT include CSharpMarkup namespace usings and DO NOT use CSharpMarkup objects.
// Markup object instances are not safe to use outside of a markup expression (due to performance features).
// That is why Assign and Invoke pass the UI object to the logic, not the markup object.
using System.Windows.Controls;
using System.Windows.Media.Imaging;
namespace WpfCsMarkupExamples;

internal sealed partial class SearchPage : BasePage, IBuild
{
    static SearchViewModel.Tweet tweet = new();
    readonly SearchViewModel vm;
    StackPanel? header;

    public SearchPage()
    {
        DataContext = vm = App.Current!.SearchViewModel;
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