using MvvmCross.Commands;
using MvvmCross.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionTracker.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel(IMvxNavigationService navigationService) : base(navigationService)
        {
            GoToSettingsCommand = new MvxCommand(GoToSettings);
        }

        public IMvxCommand GoToSettingsCommand { get; set; }

        public string TitleText => "Nutrition Tracker";

        private void GoToSettings()
        {
            _navigationService.Navigate<SettingsViewModel>();
        }
    }
}
