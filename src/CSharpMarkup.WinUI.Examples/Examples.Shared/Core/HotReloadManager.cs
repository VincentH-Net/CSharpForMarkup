#if FALSE
[assembly: System.Reflection.Metadata.MetadataUpdateHandler(typeof(WinUICsMarkupExamples.HotReloadManager))]

namespace WinUICsMarkupExamples;

internal static class HotReloadManager
{
    public static void ClearCache(Type[]? types) { }

    public static void UpdateApplication(Type[]? types) => App.Current.BuildUI();
}
#endif
