#if DEBUG
[assembly: System.Reflection.Metadata.MetadataUpdateHandler(typeof(HotReloadService))]

namespace WinUICsMarkupExamples.Core;

public static class HotReloadService
{
    public static event Action<Type[]?>? UpdateApplicationEvent;

    internal static void ClearCache(Type[]? _) { }
    internal static void UpdateApplication(Type[]? types) => UpdateApplicationEvent?.Invoke(types);
}
#endif
