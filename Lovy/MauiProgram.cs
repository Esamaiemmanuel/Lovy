namespace Lovy;

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
                fonts.AddFont("Comfortaa-VariableFont_wght.ttf", "Comfortaa");
                fonts.AddFont("JosefinSans-Italic-VariableFont_wght.ttf", "JosefinSansItalicd");
                fonts.AddFont("JosefinSans-VariableFont_wght.ttf", "JosefinSans");
                fonts.AddFont("Brands-Regular-400.otf", "FAB");
                fonts.AddFont("Free-Regular-400.otf", "FAR");
                fonts.AddFont("Free-Solid-900.otf", "FAS");

            });

		return builder.Build();
	}
}
