/* This partial class file contains the App code that is specific to the example

Note: the implementation for navigation and viewmodel access below are simplistic;
consider appropriate patterns for more complex apps */

using Microsoft.UI.Xaml.Controls;

namespace WinUICsMarkupExamples;

public partial class App
{
    Frame navigationFrame;

    SearchViewModel searchViewModel;
    FlutterViewModel flutterViewModel;

    public static new App Current { get; private set; }

    internal SearchViewModel SearchViewModel => searchViewModel ??= new SearchViewModel().Initialize();
    internal FlutterViewModel FlutterViewModel => flutterViewModel ??= new FlutterViewModel();

    internal bool NavigateToSearchPage(object parameter) => navigationFrame.Navigate(typeof(SearchPage), parameter);
    internal bool NavigateToFlutterPage() => navigationFrame.Navigate(typeof(FlutterPage));
    internal void NavigateBack() => navigationFrame.GoBack();

    #if DEBUG && !HAS_UNO_WASM
    internal void BuildUI() => _ = navigationFrame.DispatcherQueue.TryEnqueue(() => (navigationFrame.Content as IBuild)?.Build());
    #endif

    void SetCurrentApp() => Current = this;

    Frame CreateRootFrame() => new Frame { Resources = Styles.Implicit.Dictionary };

    void InitializeNavigation(Frame navigationFrame) => this.navigationFrame = navigationFrame;

    void EnableHotReloadKeyboardWatcher()
    {
        #if WINDOWS && DEBUG && !HAS_UNO_SKIA_WPF
        // TODO: Replace with MetadataUpdateHandler attribute when MS has fixed that for .NET hot reload in WinUI 3
        CSharpMarkup.WinUI.HotReloadKeyboardWatcher.Enable(true);
        CSharpMarkup.WinUI.HotReloadKeyboardWatcher.CtrlUpAfterS += BuildUI;
        #endif
    }
}
