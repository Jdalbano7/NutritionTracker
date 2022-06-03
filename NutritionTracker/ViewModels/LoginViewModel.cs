using MvvmCross.Commands;
using MvvmCross.Navigation;
using NutritionTracker.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NutritionTracker.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public IMvxCommand LoginCommand { get; }

        public LoginViewModel(IMvxNavigationService navigationService): base(navigationService)
        {
            LoginCommand = new MvxCommand(Login);
        }

        private void Login()
        {
            Application.Current.MainPage.DisplayAlert("logged in", "loged in", "Okay good");
        }
    }
}
