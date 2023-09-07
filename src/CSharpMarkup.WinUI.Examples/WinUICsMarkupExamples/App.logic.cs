using Windows.ApplicationModel.Activation;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using WinUICsMarkupExamples.Views;
using System.Diagnostics.CodeAnalysis;
#if DEBUG
using System.Linq;
#endif
// IMPORTANT: do not use CSharpMarkup.WinUI objects in this UI logic file; only use them in C# markup files
// See https://github.com/VincentH-Net/CSharpForMarkup#namespace-separation-of-markup-and-ui-logic

namespace WinUICsMarkupExamples;

/// <summary>
/// Provides application-specific behavior to supplement the default Application class.
/// </summary>
public partial class App : Application
#if DEBUG
, IBuildUI
#endif
{
    Frame? rootFrame;

    /// <summary>
    /// Initializes the singleton application object.  This is the first line of authored code
    /// executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    /// <remarks>
    /// This is the base class for AppHead, which is present in each platform head project (AppHead.xaml + AppHead.xaml.cs)
    /// </remarks>
    [SuppressMessage("Build", "IDE0021", Justification = "False positive due to conditional compilation")]
    public App()
    {
        SetCurrentApp();
#if HAS_UNO 
        Uno.UI.FeatureConfiguration.ContentPresenter.UseImplicitContentFromTemplatedParent = true; // Workaround for Uno issue - see https://github.com/unoplatform/uno/issues/857#issuecomment-536522828
#endif
    }

#if DEBUG
    public virtual void BuildUI() => UpdateUI(true);

    void UpdateUI(Type[]? types) => UpdateUI(types?.Contains(typeof(Styles)) == true);

    // Change this method as needed to match your application UI object hierarchy
    void UpdateUI(bool updateStyles) => _ = rootFrame?.DispatcherQueue.TryEnqueue(() =>
    {
        if (updateStyles)
        {
            ClearStyles();
            rootFrame!.Resources = Implicit.Dictionary;
        }

        (rootFrame?.Content as IBuildUI)?.BuildUI();
    });
#endif

    /// <summary>
    /// Gets the main window of the app.
    /// </summary>
    protected internal static Window? MainWindow { get; private set; }

    /// <summary>
    /// Invoked when the application is launched normally by the end user.  Other entry points
    /// will be used such as when the application is launched to open a specific file.
    /// </summary>
    /// <param name="args">Details about the launch request and process.</param>
    protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
    {
#if DEBUG
		if (System.Diagnostics.Debugger.IsAttached)
		{
			// this.DebugSettings.EnableFrameRateCounter = true;
		}
#endif

#if NET6_0_OR_GREATER && WINDOWS && !HAS_UNO
		MainWindow = new Window();
        {   // Set startup window size
            nint hWnd = WinRT.Interop.WindowNative.GetWindowHandle(MainWindow);
            var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow?.Resize(new(500, 1180));
        }
		MainWindow.Activate();
#else
        MainWindow = Microsoft.UI.Xaml.Window.Current;
#endif

        // Do not repeat app initialization when the Window already has content,
        // just ensure that the window is active
        if (MainWindow.Content is null || rootFrame is null)
        {
            // Create a Frame to act as the navigation context and place the frame in the current Window
            MainWindow.Content = MainWindowContent.UI;

            rootFrame!.NavigationFailed += OnNavigationFailed;

            if (args.UWPLaunchActivatedEventArgs.PreviousExecutionState == ApplicationExecutionState.Terminated)
            {
                // TODO: Load state from previously suspended application
            }
        }

#if !(NET6_0_OR_GREATER && WINDOWS)
        if (args.UWPLaunchActivatedEventArgs.PrelaunchActivated == false)
#endif
        {
            if (rootFrame.Content == null)
            {
                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
                rootFrame.Navigate(typeof(Views.SearchPage), args.Arguments);
            }
            // Ensure the current window is active
            MainWindow.Activate();
        }

#if DEBUG
        HotReloadService.UpdateApplicationEvent += UpdateUI;
#endif
    }

    /// <summary>
    /// Invoked when Navigation to a certain page fails
    /// </summary>
    /// <param name="sender">The Frame which failed navigation</param>
    /// <param name="e">Details about the navigation failure</param>
    void OnNavigationFailed(object sender, NavigationFailedEventArgs e) => throw new InvalidOperationException($"Failed to load {e.SourcePageType.FullName}: {e.Exception}");
}

/* Below partial class contains the App code that is specific to the example

   Note: the implementation for navigation and viewmodel access below are simplistic;
   consider appropriate patterns for more complex apps
*/
public partial class App
{
    SearchViewModel? searchViewModel;
    FlutterViewModel? flutterViewModel;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable. Justification: false positive, value is set in ctor via SetCurrentApp()
    public static new App Current { get; private set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    internal SearchViewModel SearchViewModel => searchViewModel ??= new SearchViewModel().Initialize();
    internal FlutterViewModel FlutterViewModel => flutterViewModel ??= new FlutterViewModel();

    internal void NavigateToSearchPage(object? parameter) => rootFrame?.Navigate(typeof(SearchPage), parameter);
    internal void NavigateToFlutterPage() => rootFrame?.Navigate(typeof(FlutterPage));
    internal void NavigateBack() => rootFrame?.GoBack();

    void SetCurrentApp() => Current = this;
}
