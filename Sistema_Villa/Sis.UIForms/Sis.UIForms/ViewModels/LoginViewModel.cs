

namespace Sis.UIForms.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using Sis.UIForms.Views;
    using System;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand => new RelayCommand(Login);


        public LoginViewModel()
        {
            this.Email = "cesar.hades77@gmail.com";
            this.Password = "123456";
        }
        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error", "Debe ingresar un email", "Aceptar");

                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error", "Debe ingresar una contaseña", "Aceptar");

                return;
            }

            if (!this.Email.Equals("cesar.hades77@gmail.com") || !this.Password.Equals("123456"))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error", "Usuario o contraseña incorrectos", "Aceptar");

                return;
            }

            //await Application.Current.MainPage.DisplayAlert(
            //        "Ok", "Correcto", "Aceptar");
            MainViewModel.GetInstance().Products = new ProductsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new ProductsPage());
        }
    }
}
