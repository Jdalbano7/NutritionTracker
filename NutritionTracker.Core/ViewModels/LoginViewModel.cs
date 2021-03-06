using MvvmCross.Commands;
using MvvmCross.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionTracker.Core.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        



        public LoginViewModel(IMvxNavigationService navigationService): base(navigationService)
        {
            LoginCommand = new MvxCommand(Login, CheckCanLogin);
            
        }

        public IMvxCommand LoginCommand { get; }

        public string LoginText => "Login";

        private string _username;
        public string Username
        {
            get { return _username; }
            set 
            {

                SetProperty(ref _username, value);
                
                LoginCommand.RaiseCanExecuteChanged();
            } 
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set 
            { 
                SetProperty(ref _password, value);
                LoginCommand.RaiseCanExecuteChanged();
            }
        }


        private void Login()
        {

            _navigationService.Navigate<HomeViewModel>();

        }

        private bool CheckCanLogin()
        {
            return !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);
        }
    }
}
