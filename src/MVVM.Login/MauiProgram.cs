using MVVM.Login.ViewModels;
using MVVM.Login.ViewModels.Startup;
using MVVM.Login.Views.Dashboard;
using MVVM.Login.Views.Startup;

namespace MVVM.Login;

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
		//Views 
		builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<DashboardPage>();


        //Views Models
        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<InfoViewModel>();
   



        return builder.Build();
	}
}
