using MVVM.Login.ViewModels;

namespace MVVM.Login.Views.Dashboard;

public partial class DashboardPage : ContentPage
{
	public DashboardPage(InfoViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}