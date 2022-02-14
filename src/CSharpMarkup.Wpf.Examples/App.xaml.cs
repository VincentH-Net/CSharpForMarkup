using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

[assembly: System.Reflection.Metadata.MetadataUpdateHandler(typeof(WpfCsMarkupExamples.HotReloadManager))]

namespace WpfCsMarkupExamples;

public partial class App : Application
{
    NavigationWindow? mainWindow;
    SearchPage? searchPage;
    FlutterPage? flutterPage;

    public App() => Current = this;

    protected override void OnStartup(StartupEventArgs e)
    {
        mainWindow = new NavigationWindow();
        mainWindow.SizeToContent = SizeToContent.WidthAndHeight;
        MainWindow.Resources = Styles.Implicit.Dictionary;
        mainWindow.NavigationService.Navigate(searchPage = new SearchPage());
        mainWindow.Show();

        base.OnStartup(e);
    }

    SearchViewModel? searchViewModel;
    FlutterViewModel? flutterViewModel;

    internal static new App Current { get; private set; }

    internal static void LaunchUri(Uri uri) => Process.Start("cmd.exe", $"/C \"start msedge {uri}\"");
    internal SearchViewModel SearchViewModel => searchViewModel ??= new SearchViewModel().Initialize();
    internal FlutterViewModel FlutterViewModel => flutterViewModel ??= new FlutterViewModel();

    internal void NavigateToFlutterPage() => Navigate(FlutterPage);
    internal void NavigateBack() => mainWindow?.NavigationService.GoBack();

    internal void BuildUI() => (mainWindow?.NavigationService.Content as IBuild)?.Build();

    Page SearchPage => searchPage ??= new SearchPage();
    Page FlutterPage => flutterPage ??= new FlutterPage();

    void Navigate(Page page) => mainWindow?.NavigationService?.Navigate(page);
}