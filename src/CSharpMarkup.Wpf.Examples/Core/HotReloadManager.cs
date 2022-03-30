#if DEBUG
[assembly: System.Reflection.Metadata.MetadataUpdateHandler(typeof(WpfCsMarkupExamples.HotReloadManager))]

namespace WpfCsMarkupExamples;

internal static class HotReloadManager
{
    public static void ClearCache(Type[]? types) { }

    public static void UpdateApplication(Type[]? types) =>
        App.Current?.Dispatcher.Invoke(() => App.Current.BuildUI(types));
}
#endif
