using Microsoft.Toolkit.Mvvm.Input;
using MVVM.Login.ViewModels.Base;
using MVVM.Login.Views.Dashboard;

namespace MVVM.Login.ViewModels.Startup
{
    public partial class LoginViewModel : BaseViewModel
    {

        private string _email;
        private string _password;

        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        #region Commands 

        [ICommand]
        async Task LoginAsync()
        {
            if (Email == "richard" && Password == "12345")
            {
                await Shell.Current.GoToAsync($"{nameof(DashboardPage)}");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Usuario o contraseña incorrectos", "Aceptar");
            }
        }

        #endregion
    }
}
