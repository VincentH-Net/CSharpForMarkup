namespace WpfCsMarkupExamples;

internal static class HotReloadManager
{
    public static void ClearCache(Type[]? types) { }

    public static void UpdateApplication(Type[]? types) => 
        App.Current.Dispatcher.Invoke(() => App.Current.BuildUI());
}
