using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Linq;

namespace WpfCsMarkupExamples;

public partial class App : Application
{
    NavigationWindow? mainWindow;
    SearchPage? searchPage;
    FlutterPage? flutterPage;

    public App() => Current = this;

    protected override void OnStartup(StartupEventArgs e)
    {
        mainWindow = new NavigationWindow
        {
            SizeToContent = SizeToContent.WidthAndHeight,
            Resources = Styles.Implicit.Dictionary
        };
        NavigateToSearchPage();
        mainWindow.Show();
        base.OnStartup(e);
    }

    SearchViewModel? searchViewModel;
    FlutterViewModel? flutterViewModel;

    internal static new App? Current { get; private set; }

    internal static void LaunchUri(Uri uri) => Process.Start("cmd.exe", $"/C \"start msedge {uri}\"");
    internal SearchViewModel SearchViewModel => searchViewModel ??= new SearchViewModel().Initialize();
    internal FlutterViewModel FlutterViewModel => flutterViewModel ??= new FlutterViewModel();

    internal void NavigateToSearchPage() => Navigate(SearchPage);
    internal void NavigateToFlutterPage() => Navigate(FlutterPage);
    internal void NavigateBack() => mainWindow?.NavigationService.GoBack();

#if DEBUG
    internal void BuildUI(Type[]? types)
    {
        if (types is null) return;

        bool buildStyles = types.Any(t => t == typeof(Styles) || t == typeof(Styles.Implicit));
        if (buildStyles) { Styles.Implicit.ClearCache(); Styles.ClearCache(); }

        // TODO: same for control templates as for styles - use nice controltemplate example (togglebutton?), then port to WinUI example

        if (mainWindow is not null)
        {
            if (buildStyles) mainWindow.Resources = Styles.Implicit.Dictionary;
            (mainWindow.NavigationService.Content as IBuild)?.Build();
        }
    }
#endif

    Page SearchPage => searchPage ??= new SearchPage();
    Page FlutterPage => flutterPage ??= new FlutterPage();

    void Navigate(Page page) => mainWindow?.NavigationService.Navigate(page);
}