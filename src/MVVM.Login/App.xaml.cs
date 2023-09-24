using MVVM.Login.Views.Startup;
using MVVM.Login.ViewModels.Startup;
using MVVM.Login.Models;

namespace MVVM.Login;

public partial class App : Application
{
	public static UserBasicInfo UserDetails;

	public App()
	{
		InitializeComponent();


        MainPage = new AppShell();
    }
}
