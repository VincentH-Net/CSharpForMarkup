using UIKit;
using Uno.UI.Hosting;
using WinUICsMarkupExamples;

var host = UnoPlatformHostBuilder.Create()
    .App(() => new App())
    .UseAppleUIKit()
    .Build();

host.Run();
