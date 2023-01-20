using Microsoft.Extensions.Logging;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace WinUICsMarkupExamples;

/// <summary>
/// Provides application-specific behavior to supplement the default Application class.
/// </summary>
/// <remarks>
/// This partial class file is as close as possible to what is generated with dotnet new unoapp -f net7.0
/// The only changes are that it accesses these members:
///   <see cref="SetCurrentApp"/>
///   <see cref="CreateRootFrame"/>
///   <see cref="InitializeNavigation(Frame)"/>
///   EnableHotReloadKeyboardWatcher
/// which are implemented in the App.Example.xaml.cs partial class file
/// </remarks>
public sealed partial class App : Application
{
    Window? window;

    /// <summary>
    /// Initializes the singleton application object.  This is the first line of authored code
    /// executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    public App()
    {
        SetCurrentApp();

        InitializeLogging();

        InitializeComponent();

#if HAS_UNO || NETFX_CORE
        Suspending += OnSuspending;
#endif
    }

    /// <summary>
    /// Invoked when the application is launched normally by the end user.  Other entry points
    /// will be used such as when the application is launched to open a specific file.
    /// </summary>
    /// <param name="args">Details about the launch request and process.</param>
    protected override void OnLaunched(UI.LaunchActivatedEventArgs args)
    {
#if DEBUG
        if (System.Diagnostics.Debugger.IsAttached)
        {
            // this.DebugSettings.EnableFrameRateCounter = true;
        }
#endif

#if NET6_0_OR_GREATER && WINDOWS && !HAS_UNO
        window = new Window();
        {
            nint hWnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
            var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow?.Resize(new(500, 1180));
        }
        window.Activate();
#else
        window = Microsoft.UI.Xaml.Window.Current;
#endif

        // Do not repeat app initialization when the Window already has content,
        // just ensure that the window is active
        if (window.Content is not Frame rootFrame)
        {
            // Create a Frame to act as the navigation context and navigate to the first page
            rootFrame = CreateRootFrame();

            rootFrame.NavigationFailed += OnNavigationFailed;

            if (args.UWPLaunchActivatedEventArgs.PreviousExecutionState == ApplicationExecutionState.Terminated)
            {
                // TODO: Load state from previously suspended application
            }

            // Place the frame in the current Window
            window.Content = rootFrame;

#if WINDOWS && DEBUG && !HAS_UNO_SKIA_WPF
            EnableHotReloadKeyboardWatcher();
#endif
        }

        InitializeNavigation(rootFrame);

#if !(NET6_0_OR_GREATER && WINDOWS)
        if (args.UWPLaunchActivatedEventArgs.PrelaunchActivated == false)
#endif
        {
            if (rootFrame.Content == null)
            {
                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
                NavigateToSearchPage(args.Arguments);
            }
            // Ensure the current window is active
            window.Activate();
        }
    }

    /// <summary>
    /// Invoked when Navigation to a certain page fails
    /// </summary>
    /// <param name="sender">The Frame which failed navigation</param>
    /// <param name="e">Details about the navigation failure</param>
    void OnNavigationFailed(object sender, NavigationFailedEventArgs e) => throw new InvalidOperationException($"Failed to load {e.SourcePageType.FullName}: {e.Exception}");

#if HAS_UNO || NETFX_CORE
    /// <summary>
    /// Invoked when application execution is being suspended.  Application state is saved
    /// without knowing whether the application will be terminated or resumed with the contents
    /// of memory still intact.
    /// </summary>
    /// <param name="sender">The source of the suspend request.</param>
    /// <param name="e">Details about the suspend request.</param>
    void OnSuspending(object sender, SuspendingEventArgs e)
    {
        var deferral = e.SuspendingOperation.GetDeferral();
        //TODO: Save application state and stop any background activity
        deferral.Complete();
    }
#endif

    /// <summary>
    /// Configures global Uno Platform logging
    /// </summary>
    static void InitializeLogging()
    {
#if DEBUG
        // Logging is disabled by default for release builds, as it incurs a significant
        // initialization cost from Microsoft.Extensions.Logging setup. If startup performance
        // is a concern for your application, keep this disabled. If you're running on web or 
        // desktop targets, you can use url or command line parameters to enable it.
        //
        // For more performance documentation: https://platform.uno/docs/articles/Uno-UI-Performance.html

        var factory = LoggerFactory.Create(builder =>
        {
#if __WASM__
            builder.AddProvider(new global::Uno.Extensions.Logging.WebAssembly.WebAssemblyConsoleLoggerProvider());
#elif __IOS__
            builder.AddProvider(new global::Uno.Extensions.Logging.OSLogLoggerProvider());
#elif NETFX_CORE
            builder.AddDebug();
#else
            builder.AddConsole();
#endif

            // Exclude logs below this level
            builder.SetMinimumLevel(LogLevel.Information);

            // Default filters for Uno Platform namespaces
            builder.AddFilter("Uno", LogLevel.Warning);
            builder.AddFilter("Windows", LogLevel.Warning);
            builder.AddFilter("Microsoft", LogLevel.Warning);

            // Generic Xaml events
            // builder.AddFilter("Microsoft.UI.Xaml", LogLevel.Debug );
            // builder.AddFilter("Microsoft.UI.Xaml.VisualStateGroup", LogLevel.Debug );
            // builder.AddFilter("Microsoft.UI.Xaml.StateTriggerBase", LogLevel.Debug );
            // builder.AddFilter("Microsoft.UI.Xaml.UIElement", LogLevel.Debug );
            // builder.AddFilter("Microsoft.UI.Xaml.FrameworkElement", LogLevel.Trace );

            // Layouter specific messages
            // builder.AddFilter("Microsoft.UI.Xaml.Controls", LogLevel.Debug );
            // builder.AddFilter("Microsoft.UI.Xaml.Controls.Layouter", LogLevel.Debug );
            // builder.AddFilter("Microsoft.UI.Xaml.Controls.Panel", LogLevel.Debug );

            // builder.AddFilter("Windows.Storage", LogLevel.Debug );

            // Binding related messages
            // builder.AddFilter("Microsoft.UI.Xaml.Data", LogLevel.Debug );
            // builder.AddFilter("Microsoft.UI.Xaml.Data", LogLevel.Debug );

            // Binder memory references tracking
            // builder.AddFilter("Uno.UI.DataBinding.BinderReferenceHolder", LogLevel.Debug );

            // RemoteControl and HotReload related
            // builder.AddFilter("Uno.UI.RemoteControl", LogLevel.Information);

            // Debug JS interop
            // builder.AddFilter("Uno.Foundation.WebAssemblyRuntime", LogLevel.Debug );
        });

        Uno.Extensions.LogExtensionPoint.AmbientLoggerFactory = factory;

#if HAS_UNO
        Uno.UI.Adapter.Microsoft.Extensions.Logging.LoggingAdapter.Initialize();
#endif
#endif
}
}
