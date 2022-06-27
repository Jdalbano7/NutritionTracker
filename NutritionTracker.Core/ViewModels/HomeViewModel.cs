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
        public int CaloriesAmount => 2000;
        public string CaloriesLabel => "cal";
        public int FatAmount => 120;
        public string FatLabel => "Fats";
        public int CarbAmount => 80;
        public string CarbLabel => "Carbs";
        public int ProteinAmount => 900;
        public string ProteinLabel => "Protein";

        private void GoToSettings()
        {
            _navigationService.Navigate<SettingsViewModel>();
        }
    }
}
