using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WinUICsMarkupExamples
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();

			var app = builder.Build();

			// Configure the HTTP request pipeline.

			app.UseAuthorization();


			app.MapControllers();
			app.UseStaticFiles();

			app.Run();
		}
	}
}
