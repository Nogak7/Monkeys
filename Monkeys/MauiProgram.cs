using Microsoft.Extensions.Logging;
using Monkeys.View;
using Monkeys.ViewModels;

namespace Monkeys;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<MonkeyView>();

        builder.Services.AddSingleton<MonkeyViewModels>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
