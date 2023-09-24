using MVVM.Login.Views.Dashboard;

namespace MVVM.Login;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
	}
}
