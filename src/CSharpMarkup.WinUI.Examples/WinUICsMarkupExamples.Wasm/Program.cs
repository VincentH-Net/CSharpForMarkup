using Microsoft.UI.Xaml;

namespace WinUICsMarkupExamples.Wasm;

public sealed class Program
{
    static int Main(string[] _)
    {
        Application.Start(_ => { var __ = new AppHead(); });

        return 0;
    }
}
