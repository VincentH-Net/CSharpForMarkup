using Uno.UI.Hosting;
using WinUICsMarkupExamples;

var host = UnoPlatformHostBuilder.Create()
    .App(() => new App())
    .UseWebAssembly()
    .Build();

await host.RunAsync();
