using MvvmCross.Commands;
using MvvmCross.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionTracker.Core.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public IMvxCommand LoginCommand { get; }
        public string LoginText => "Login";

        public LoginViewModel(IMvxNavigationService navigationService): base(navigationService)
        {
            LoginCommand = new MvxCommand(Login);
        }

        private void Login()
        {

            System.Console.WriteLine("Logged in");

        }
    }
}
