using MVVM.Login.ViewModels.Startup;

namespace MVVM.Login.Views.Startup;

public partial class LoginPage : ContentPage
{
	

	public LoginPage(LoginViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;

		
	}

	
}

