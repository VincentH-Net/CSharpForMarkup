using Microsoft.Extensions.Logging;

namespace WinUICsMarkupExamples;

/// <summary>
/// Provides application-specific behavior to supplement the default Application class.
///
/// Code that is not specific to an application head may be placed in the WinUICsMarkupExamples/App.cs class.
/// </summary>
public sealed partial class AppHead : App
{
    static AppHead()
        => InitializeLogging();

    /// <summary>
    /// Initializes the singleton application object. This is the first line of authored code
    /// executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    public AppHead()
#if DEBUG && WINDOWS && !HAS_UNO_SKIA_WPF
    {
        this.InitializeComponent();
        // TODO: Replace with MetadataUpdateHandler attribute when MS has fixed that for .NET hot reload in WinUI 3
        HotReloadKeyboardWatcher.Enable(true);
        HotReloadKeyboardWatcher.CtrlUpAfterS += BuildUI;
    }
#else
     => this.InitializeComponent();
#endif

    /// <summary>
    /// Configures global Uno Platform logging
    /// </summary>
    static void InitializeLogging()
    {
#if DEBUG
		// Logging is disabled by default for release builds, as it incurs a significant
		// initialization cost from Microsoft.Extensions.Logging setup. If startup performance
		// is a concern for your application, keep this disabled. If you're running on the web or
		// desktop targets, you can use URL or command line parameters to enable it.
		//
		// For more performance documentation: https://platform.uno/docs/articles/Uno-UI-Performance.html

		var factory = LoggerFactory.Create(builder =>
		{
#if __WASM__
			builder.AddProvider(new global::Uno.Extensions.Logging.WebAssembly.WebAssemblyConsoleLoggerProvider());
#elif __IOS__ && !__MACCATALYST__
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

#if HAS_UNO
		global::Uno.Extensions.LogExtensionPoint.AmbientLoggerFactory = factory;
		global::Uno.UI.Adapter.Microsoft.Extensions.Logging.LoggingAdapter.Initialize();
#endif
#endif
    }
}
