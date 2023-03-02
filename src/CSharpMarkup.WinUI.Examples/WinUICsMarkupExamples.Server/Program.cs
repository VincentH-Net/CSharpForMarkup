using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Uno.Wasm.Bootstrap.Server;

namespace WinUICsMarkupExamples;

public sealed class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        _ = builder.Services.AddControllers();

        var app = builder.Build();

        // Configure the HTTP request pipeline.

        _ = app.UseAuthorization();

        /*#if (WebAssembly)

                _ = app.UseUnoFrameworkFiles()
                       .MapFallbackToFile("index.html");

        #endif */

        _ = app.MapControllers();
        _ = app.UseStaticFiles();

        app.Run();
    }
}
